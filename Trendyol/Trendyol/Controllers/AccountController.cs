using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Threading.Tasks;
using Trendyol.EmailService;
using Trendyol.Identity;
using Trendyol.Models;
using DataAccessLayer.Concrete.EFCore;
using System.Linq;
using EntityLayer;

namespace Trendyol.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<Identity.User> _userManager;
        private SignInManager<Identity.User> _signInManager;
        private IEmailSender _emailSender;
        private ICartService _cartService;
        private IFavoriService _favoriService;
        private ApplicationContext _context;
        public AccountController(ApplicationContext context,IFavoriService favoriService,UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender,ICartService cartService)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _cartService = cartService;
            _favoriService= favoriService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                FirstName = model.Name,
                UserName = model.UserName,
                Email = model.Email,
                
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                // generate token
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                });
                //InitialCart
                _cartService.InitilazerCart(user.Id);
                //initilazerfavori
                _favoriService.InitilazerFavori(user.Id);
                // email
                await _emailSender.SendEmailAsync(model.Email, "Hesabınızı onaylayınız.", $"Lütfen email hesabınızı onaylamak için linke <a href='https://localhost:44311{url}'>tıklayınız.</a>");
                return RedirectToAction("Login", "Account");


               
            }

            ModelState.AddModelError("", "Bilinmeyen hata oldu lütfen tekrar deneyiniz.");
            return View(model);
        }
        public IActionResult Login(string ReturnUrl = null)
        {
            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // var user = await _userManager.FindByNameAsync(model.UserName);
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Bu kullanıcı adı ile daha önce hesap oluşturulmamış");
                return View(model);
            }

            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Lütfen email hesabınıza gelen link ile üyeliğinizi onaylayınız.");
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);

            if (result.Succeeded)
            {
              
                return Redirect(model.ReturnUrl ?? "~/");
            }

            ModelState.AddModelError("", "Girilen kullanıcı adı veya parola yanlış");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
          
            return Redirect("~/");
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
               
                return View("error");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                
                    return View();
                }
            }
            return View("error");
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(Email);

            if (user == null)
            {
                return View();
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);

            var url = Url.Action("ResetPassword", "Account", new
            {
                userId = user.Id,
                token = code
            });

            // email
            await _emailSender.SendEmailAsync(Email, "Reset Password", $"Parolanızı yenilemek için linke <a href='https://localhost:44311{url}'>tıklayınız.</a>");

            return View();
        }

        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return RedirectToAction("Home", "Index");
            }

            var model = new ResetPasswordModel { Token = token };

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return RedirectToAction("Home", "Index");
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }

            return View(model);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }


        public IActionResult AccountSetting()
        {
            using (var db=new Context())
            {
              var order= db.Orders.Where(i=>i.UserId==_userManager.GetUserId(User)).FirstOrDefault();
               if(order.OrderState==EnumOrderState.completed)
                {
                    ViewBag.state = "Teslim Edildi";
                }
                if (order.OrderState == EnumOrderState.cancel)
                {
                    ViewBag.state = "İptal Edildi";
                }
                if (order.OrderState == EnumOrderState.unpaid)
                {
                    ViewBag.state = "Kargoya Verildi";
                }
                if (order.OrderState == EnumOrderState.waiting)
                {
                    ViewBag.state = "İşleme Alındı";
                }
            }
            


            var user = _context.Users.Where(i => i.Id == _userManager.GetUserId(User)).FirstOrDefault();
            

            var model = new AccountSettingsViewModel()
            {
          
                Id = user.Id,
                Name = user.FirstName,
                Surname = user.LastName,
                Email = user.Email,
                UserName = user.UserName,
                PhoneNumber = user.PhoneNumber
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> AccountSettingUpdate(AccountSettingsViewModel model)
        {
   
            var entity = _context.Users.Where(i => i.Id == model.Id).FirstOrDefault();

            if (entity == null)
            {
                return View(model);
            }
            else
            {
                
                    if (entity.UserName != model.UserName)
                    {


                        entity.LastName = model.Surname;
                        entity.Email = model.Email;
                        entity.FirstName = model.Name;
                        entity.UserName = model.UserName;
                        entity.PhoneNumber = model.PhoneNumber;
                        entity.PasswordHash = _userManager.PasswordHasher.HashPassword(entity, model.Password);



                        await _userManager.UpdateAsync(entity);

                        return RedirectToAction("logout");
                    }
                    else
                    {


                        entity.LastName = model.Surname;
                        entity.Email = model.Email;
                        entity.FirstName = model.Name;
                        entity.UserName = model.UserName;
                        entity.PasswordHash = _userManager.PasswordHasher.HashPassword(entity, model.Password);
                        entity.PhoneNumber = model.PhoneNumber;


                        await _userManager.UpdateAsync(entity);

                        return RedirectToAction("AccountSetting");
                    }
               



            }


        }

    }
}
