using BusinessLayer.Abstract;
using DataAccessLayer.Concrete.EFCore;
using EntityLayer;
using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using Trendyol.Identity;
using Iyzipay;
using Trendyol.Models;
using Newtonsoft.Json;
using Trendyol.Migrations;
using Microsoft.Exchange.WebServices.Data;
using DataAccessLayer.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Trendyol.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private ICartService _cartService;
        private UserManager<User> _userManager;
        private IProductService productService;
        private IOrderService _orderService;
        public CartController(ICartService cartService, UserManager<User> userManager, IProductService productService, IOrderService orderService)
        {
            _userManager = userManager;
            _cartService = cartService;
            this.productService = productService;
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            int count = 0;
            var cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));
            foreach (var item in cart.CartItems)
            {
                if (item.StatusVisibilty == false)
                {
                    count++;
                }
            }
            ViewBag.Count = count;

            var sum = cart.CartItems.Where(i => i.StatusVisibilty == false).Sum(i => i.Product.Price * i.Quantity);
            ViewBag.Sum = sum;

            var onceden = cart.CartItems.Where(i => i.StatusVisibilty == true).ToList();
            ViewBag.Onceden = onceden;

            string a;
            var list = new List<Product>();
            foreach (var item in cart.CartItems)
            {
                if (item.StatusVisibilty == false)
                {
                    a = item.Product.ProductClassName;

                    using (var db = new Context())
                    {
                        var prd = db.Products.Where(i => i.ProductClassName == a).ToList();
                        foreach (var urun in prd)
                        {
                            list.Add(urun);
                        }
                    }
                }



            }

            ViewBag.Onerilen = list;
            return View(cart);
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, int quantity, string size)
        {
            var userId = _userManager.GetUserId(User);
            _cartService.AddToCart(userId, productId, quantity, size);


            return RedirectToAction("index");
        }

        public IActionResult DeleteToCart(int id)
        {

            _cartService.DeleteFromCart(_userManager.GetUserId(User), id);

            return RedirectToAction("index");

        }

        public IActionResult Checkout()
        {
           


            var cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));
            ViewBag.UserId = _userManager.GetUserId(User);
            ViewBag.CartId = cart.Id;

            using (var db = new Context())
            {
              var adress=  db.Adresses.Where(i => i.UserId == _userManager.GetUserId(User) && i.CartId == cart.Id).FirstOrDefault();
                ViewBag.Adress=adress;

                var total = cart.CartItems.Where(i => i.StatusVisibilty == false).Sum(i => i.Product.Price * i.Quantity);
                ViewBag.Totals=total;
            }
            var orderModel = new OrderModel();

            orderModel.CartModel = new CartModel()
            {
                CartId = cart.Id,
                CartItems = cart.CartItems.Where(i=>i.StatusVisibilty==false).Select(i => new CartItemModel()
                {
                    CartItemId = i.Id,
                    ProductId = i.ProductId,
                    Name = i.Product.ProductTitle,
                    Price = (double)i.Product.Price,
                    ImageUrl = i.Product.ProductImageUrl1,
                    Quantity = i.Quantity,
                    Status=i.StatusVisibilty

                }).ToList()
            };

            return View(orderModel);
        }

        [HttpPost]
        public IActionResult Checkout(OrderModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
          
                var cart = _cartService.GetCartByUserId(userId);

                model.CartModel = new CartModel()
                {
                    CartId = cart.Id,
                    CartItems = cart.CartItems.Where(i=>i.StatusVisibilty==false).Select(i => new CartItemModel()
                    {
                        CartItemId = i.Id,
                        ProductId = i.ProductId,
                        Name = i.Product.ProductTitle,
                        Price = (double)i.Product.Price,
                        ImageUrl = i.Product.ProductImageUrl1,
                        Quantity = i.Quantity,
                        Status=i.StatusVisibilty
                    }).ToList()
                };

                using (var db=new Context())
                {
                   var adres= db.Adresses.Where(i => i.UserId == userId && i.CartId==cart.Id).FirstOrDefault();
                    model.Address = adres.Address;
                    model.City = adres.City;
                    model.Email = adres.Email;
                    model.Phone = adres.Phone;
                    model.FirstName = adres.FirstName;
                    model.LastName = adres.LastName;

                }

                var payment = PaymentProcess(model);

                if (payment.Status == "success")
                {
                    SaveOrder(model, payment, userId);
                    ClearCart(model.CartModel.CartId);
                    return View("Success");
                }
              
            }
            return View(model);
        }

        public IActionResult GetOrders()
        {
            var userId = _userManager.GetUserId(User);
            var orders = _orderService.GetOrders(userId);

            var orderListModel = new List<OrderListModel>();
            OrderListModel orderModel;
            foreach (var order in orders)
            {
                orderModel = new OrderListModel();

                orderModel.OrderId = order.Id;
                orderModel.OrderNumber = order.OrderNumber;
                orderModel.OrderDate = order.OrderDate;
                orderModel.Phone = order.Phone;
                orderModel.FirstName = order.FirstName;
                orderModel.LastName = order.LastName;
                orderModel.Email = order.Email;
                orderModel.Address = order.Address;
                orderModel.City = order.City;
                orderModel.OrderState = order.OrderState;
                orderModel.PaymentType = order.PaymentType;

                orderModel.OrderItems = order.OrderItems.Select(i => new OrderItemModel()
                {
                    OrderItemId = i.Id,
                    Name = i.Product.ProductTitle,
                    Price = (double)i.Price,
                    Quantity = i.Quantity,
                    ImageUrl = i.Product.ProductImageUrl1
                }).ToList();

                orderListModel.Add(orderModel);
            }


            return View("Orders", orderListModel);
        }

        private void ClearCart(int cartId)
        {
            _cartService.ClearCart(cartId);
        }

        private void SaveOrder(OrderModel model, Payment payment, string userId)
        {
            var order = new Order();

            order.OrderNumber = new Random().Next(111111, 999999).ToString();
            order.OrderState = EnumOrderState.waiting;
            order.PaymentType = EnumPaymentType.CreditCard;
            order.PaymentId = payment.PaymentId;
            order.ConversationId = payment.ConversationId;
            order.OrderDate = DateTime.Now;
            order.FirstName = model.FirstName;
            order.LastName = model.LastName;
            order.UserId = userId;
            order.Address = model.Address;
            order.Phone = model.Phone;
            order.Email = model.Email;
            order.City = model.City;
            order.Note = model.Note;

            order.OrderItems = new List<EntityLayer.OrderItem>();

            foreach (var item in model.CartModel.CartItems.Where(i=>i.Status==false))
            {
                var orderItem = new EntityLayer.OrderItem()
                {
                    Price = item.Price,
                    Quantity = item.Quantity,
                    ProductId = item.ProductId
                };
                order.OrderItems.Add(orderItem);
            }
            _orderService.Create(order);
        }

        private Payment PaymentProcess(OrderModel model)
        {
            Iyzipay.Options options = new Iyzipay.Options();
            options.ApiKey = "sandbox-mLi76Eq5GYGOkSR2VvIRASk6neCBO51T";
            options.SecretKey = "sandbox-hnXLxEPg7L0WqU3iYnQnWlAdXOPiEfoO";
            options.BaseUrl = "https://sandbox-api.iyzipay.com";

            CreatePaymentRequest request = new CreatePaymentRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = new Random().Next(111111111, 999999999).ToString();
            request.Price = model.CartModel.TotalPrice().ToString();
            request.PaidPrice = model.CartModel.TotalPrice().ToString();
            request.Currency = Currency.TRY.ToString();
            request.Installment = 1;
            request.BasketId = "B67832";
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = model.CardName;
            paymentCard.CardNumber = model.CardNumber;
            paymentCard.ExpireMonth = model.ExpirationMonth;
            paymentCard.ExpireYear = model.ExpirationYear;
            paymentCard.Cvc = model.Cvc;
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            //  paymentCard.CardNumber = "5528790000000008";
            // paymentCard.ExpireMonth = "12";
            // paymentCard.ExpireYear = "2030";
            // paymentCard.Cvc = "123";

            Buyer buyer = new Buyer();
            buyer.Id = "BY789";
            buyer.Name = model.FirstName;
            buyer.Surname = model.LastName;
            buyer.GsmNumber = "+905350000000";
            buyer.Email = "email@email.com";
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            buyer.Ip = "85.34.78.112";
            buyer.City = "Istanbul";
            buyer.Country = "Turkey";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            Address shippingAddress = new Address();
            shippingAddress.ContactName = "Jane Doe";
            shippingAddress.City = "Istanbul";
            shippingAddress.Country = "Turkey";
            shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = "Jane Doe";
            billingAddress.City = "Istanbul";
            billingAddress.Country = "Turkey";
            billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

            List<BasketItem> basketItems = new List<BasketItem>();
            BasketItem basketItem;

            foreach (var item in model.CartModel.CartItems.Where(i=>i.Status==false))
            {
                basketItem = new BasketItem();
                basketItem.Id = item.ProductId.ToString();
                basketItem.Name = item.Name;
                basketItem.Category1 = "Telefon";
                basketItem.Price = item.Price.ToString();
                basketItem.ItemType = BasketItemType.PHYSICAL.ToString();
                basketItems.Add(basketItem);
            }
            request.BasketItems = basketItems;
            return Payment.Create(request, options);
        }

        public IActionResult Adres(Adress adress)
        {
            _cartService.AddAddres(adress);
            return Redirect("/cart/checkout");
        }

        public IActionResult GetOrder()
        {
            var userId = _userManager.GetUserId(User);

            var orders = _orderService.GetOrders(userId);

            var orderListModel = new List<OrderListModel>();
            OrderListModel orderlist;
            foreach (var order in orders)
            {
                orderlist = new OrderListModel();
                orderlist.OrderNumber = order.OrderNumber;
                orderlist.OrderDate = order.OrderDate;
                orderlist.OrderState = order.OrderState;
                orderlist.OrderId = order.Id;
                orderlist.FirstName = order.FirstName;
                orderlist.LastName = order.LastName;

                orderlist.OrderItems = order.OrderItems.Select(i => new OrderItemModel()
                {
                    ImageUrl = i.Product.ProductImageUrl1,
                    Name = i.Product.ProductName,
                    OrderItemId = i.Id,
                    Price = i.Price,
                    Quantity = i.Quantity,
                   

                }).ToList();

                orderListModel.Add(orderlist);
            }
            return View(orderListModel);
        }

        public string OrdersByUserId()
        {
            var userId= _userManager.GetUserId(User);
            using (var db= new Context())
            {
             var order= db.Orders.Where(i => i.UserId == userId).FirstOrDefault();
                return order.OrderState.ToString();
            }

           
        }

        public IActionResult OrderDetail(int id)
        {
            using (var db=new Context())
            {

                var orders=db.Orders.Include(i=>i.OrderItems).ThenInclude(i=>i.Product).Where(i=>i.Id== id).FirstOrDefault();
                return View(orders);
            }

            
        }
    }
}
