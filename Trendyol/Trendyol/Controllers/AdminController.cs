using BusinessLayer.Abstract;
using DataAccessLayer.Concrete.EFCore;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Trendyol.Identity;
using Trendyol.Models;

namespace Trendyol.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {

        private IProductService _productService;
        private ICategoryService _categoryService;
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;
        private IQuestionsService _questionsService;
        private IOrderService _orderService;
        public AdminController(IOrderService orderService,IQuestionsService questionsService,UserManager<User> userManager,ICategoryService categoryService,IProductService productService,RoleManager<IdentityRole> roleManager) {
        
            _orderService = orderService;
          _roleManager= roleManager;
            _categoryService= categoryService;
            _productService= productService;
            _userManager = userManager;
            _questionsService = questionsService;
        }    

        public IActionResult Index()
        {
            return View();
        }

       public IActionResult Categories()
        {
            return View(_categoryService.GetAll());

            
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(CategoryViewModel model)
        {
            var category = new Category()
            {
                CategoryName= model.CategoryName
            };

            _categoryService.Create(category);

            return RedirectToAction("categories");
        }

        [HttpGet]
        public ActionResult EditCategory(int id)
        {
          var category=_categoryService.GetById(id);

            return View(category);
        }

        [HttpPost]
        public IActionResult EditCategory(Category category)
        {
            _categoryService.Update(category);


            return RedirectToAction("categories"); 
        }

        public IActionResult DeleteCategory(int id)
        {
            _categoryService.Delete(id);
            return RedirectToAction("categories");

        }

        public IActionResult Products()
        {
            
            return View(_productService.GetAlls());
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> values = (from i in _categoryService.GetAll().ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.CategoryName,
                                               Value = i.Id.ToString()
                                           }).ToList();
            ViewBag.Values = values;
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductViewModel model)
        {
            var extension = Path.GetExtension(model.ProductImageUrl1.FileName);
            var newImageName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", newImageName);
            var stream = new FileStream(location, FileMode.Create);
            model.ProductImageUrl1.CopyTo(stream);
            model.Product1 = newImageName;


            var extension2 = Path.GetExtension(model.ProductImageUrl2.FileName);
            var newImageName2 = Guid.NewGuid() + extension2;
            var location2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", newImageName2);
            var stream2 = new FileStream(location2, FileMode.Create);
            model.ProductImageUrl2.CopyTo(stream2);
            model.Product2 = newImageName2;

            var extension3 = Path.GetExtension(model.ProductImageUrl3.FileName);
            var newImageName3 = Guid.NewGuid() + extension3;
            var location3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", newImageName3);
            var stream3 = new FileStream(location3, FileMode.Create);
            model.ProductImageUrl2.CopyTo(stream3);
            model.Product3 = newImageName3;

            var product = new Product()
            {
                ProductName = model.ProductName,
                CategoryId = model.CategoryId,
                ProductDespcription = model.ProductDespcription,
                ProductPrice = model.ProductPrice,
                ProductImageUrl1 =model. Product1,
                ProductImageUrl2 = model.Product2,
                ProductImageUrl3 = model.Product3,
                ProductStarNumber = model.ProductStarNumber,
                ProductSalePrice = model.ProductSalePrice,
                ProductSize = model.ProductSize,
                ProductStock = model.ProductStock,
                ProductTitle = model.ProductTitle,
                ProductClassName= model.ProductClassName,
                Color= model.Color
            };

            _productService.Create(product);

            return RedirectToAction("products");
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            List<SelectListItem> values = (from i in _categoryService.GetAll().ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.CategoryName,
                                               Value = i.Id.ToString()
                                           }).ToList();
            ViewBag.Values = values;
            var product=_productService.GetById(id);


            var productModel = new ProductViewModel()
            {
                CategoryId = product.CategoryId,
                ProductName = product.ProductName,
                ProductDespcription = product.ProductDespcription,
                ProductPrice = product.ProductPrice,
                Product1 = product.ProductImageUrl1,
                Product2 = product.ProductImageUrl2,
                Product3 = product.ProductImageUrl3,
                ProductStarNumber = product.ProductStarNumber,
                Id = product.Id,
                ProductTitle = product.ProductTitle,
                ProductStock = product.ProductStock,
                ProductSize = product.ProductSize,
                ProductSalePrice = product.ProductSalePrice
            };

            return View(productModel);
        }

        public IActionResult EditProduct(ProductViewModel model)
        {
            if (model.ProductImageUrl1 == null && model.ProductImageUrl2 == null && model.ProductImageUrl3 == null)
            {

                var productModel = new Product()
                {
                    CategoryId = model.CategoryId,
                    ProductName = model.ProductName,
                    ProductDespcription = model.ProductDespcription,
                    ProductPrice = model.ProductPrice,
                    ProductStarNumber = model.ProductStarNumber,
                    Id = model.Id,
                    ProductTitle = model.ProductTitle,
                    ProductStock = model.ProductStock,
                    ProductSize = model.ProductSize,
                    ProductSalePrice = model.ProductSalePrice
                };

                _productService.Update(productModel);
                return Redirect("/admin/productdetails/" + model.Id);
            }

            else
            {
                var extension = Path.GetExtension(model.ProductImageUrl1.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                model.ProductImageUrl1.CopyTo(stream);
                model.Product1 = newImageName;


                var extension2 = Path.GetExtension(model.ProductImageUrl2.FileName);
                var newImageName2 = Guid.NewGuid() + extension2;
                var location2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", newImageName2);
                var stream2 = new FileStream(location2, FileMode.Create);
                model.ProductImageUrl2.CopyTo(stream2);
                model.Product2 = newImageName2;

                var extension3 = Path.GetExtension(model.ProductImageUrl3.FileName);
                var newImageName3 = Guid.NewGuid() + extension3;
                var location3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", newImageName3);
                var stream3 = new FileStream(location3, FileMode.Create);
                model.ProductImageUrl2.CopyTo(stream3);
                model.Product3 = newImageName3;
                var product = new Product()
                {
                    ProductName = model.ProductName,
                    CategoryId = model.CategoryId,
                    ProductDespcription = model.ProductDespcription,
                    ProductPrice = model.ProductPrice,
                    ProductImageUrl1 = model.Product1,
                    ProductImageUrl2 = model.Product2,
                    ProductImageUrl3 = model.Product3,
                    ProductStarNumber = model.ProductStarNumber,
                    ProductSalePrice = model.ProductSalePrice,
                    ProductSize = model.ProductSize,
                    ProductStock = model.ProductStock,
                    ProductTitle = model.ProductTitle
                };

                _productService.Update(product);
                return Redirect("/admin/productdetails/" + model.Id);
            }
        }

        public IActionResult ProductDetails(int id)
        {
           var product= _productService.GetByIds(id);


            return View(product);
        }

        public IActionResult DeleteProduct(int id)
        {
         
            _productService.Delete(id);
            return RedirectToAction("products");
        }


        public IActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(model.Name));
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        public IActionResult RoleList()
        {
            return View(_roleManager.Roles);
        }


        public async Task<IActionResult> RoleEdit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            var members = new List<User>();
            var nonmembers = new List<User> ();

            foreach (var user in _userManager.Users.ToList())
            {
                var list = await _userManager.IsInRoleAsync(user, role.Name)
                                ? members : nonmembers;
                list.Add(user);
            }
            var model = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonmembers
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }


                foreach (var userId in model.IdsToDelete ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }

            }

            return Redirect("/admin/roleedit/" + model.RoleId);
        }

        public async Task<IActionResult> UserEdit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var selectedRoles = await _userManager.GetRolesAsync(user);
                var roles = _roleManager.Roles.Select(i => i.Name);

                ViewBag.Roles = roles;
                return View(new UserDetailsModel()
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    SelectedRoles = selectedRoles
                });
            }
            return Redirect("~/admin/userlist");
        }


        [HttpPost]
        public async Task<IActionResult> UserEdit(UserDetailsModel model, string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    user.EmailConfirmed = model.EmailConfirmed;

                    var result = await _userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        selectedRoles = selectedRoles ?? new string[] { };
                        await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles).ToArray<string>());
                        await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRoles).ToArray<string>());

                        return Redirect("/admin/userlist");
                    }
                }
                return Redirect("/admin/useredit/list");
            }

            return View(model);

        }

        public IActionResult UserList()
        {
            return View(_userManager.Users);
        }


        public IActionResult AddAnswer(string answer,int questionsId,int productId)
        {
            var date = DateTime.Now;
            _questionsService.AddAnswer(answer, questionsId, productId, date);

            return Redirect("/product/details/" + productId);
        }

        public IActionResult Orders()
        {
            var userId = _userManager.GetUserId(User);
            using (var db=new Context())
            {
                var orders = db.Orders.Include(i => i.OrderItems).ThenInclude(i => i.Product).Where(i=>i.OrderState!=EnumOrderState.waiting).ToList();

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
    
        }

        public IActionResult ActiveOrders()
        {
            var userId = _userManager.GetUserId(User);
            using (var db = new Context())
            {
                var orders = db.Orders.Include(i => i.OrderItems).ThenInclude(i => i.Product).Where(i => i.OrderState == EnumOrderState.waiting).ToList();

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
        }

        public IActionResult Onay(string id)
        {
            using (var db=new Context())
            {
              var order= db.Orders.Where(i => i.OrderNumber == id).FirstOrDefault();
                order.OrderState= EnumOrderState.completed;
                db.SaveChanges();
            }
            return RedirectToAction("Orders");
        }
        public IActionResult Kargo(string id)
        {
            using (var db = new Context())
            {
                var order = db.Orders.Where(i => i.OrderNumber == id).FirstOrDefault();
                order.OrderState = EnumOrderState.unpaid;
                db.SaveChanges();
            }
            return RedirectToAction("Orders");
        }
        public IActionResult Cancel(string id)
        {
            using (var db = new Context())
            {
                var order = db.Orders.Where(i => i.OrderNumber == id).FirstOrDefault();
                order.OrderState = EnumOrderState.cancel;
                db.SaveChanges();
            }
            return RedirectToAction("Orders");
        }
    }
}
