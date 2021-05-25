using Abp.Net.Mail;
using Business.Abstract;
using Business.WebModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private ICartService _cartService;
        public AccountController(ICartService cartService,UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _cartService = cartService;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View(new RegisterWM());
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterWM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new ApplicationUser
            {
                UserName = model.Username,
                Email = model.Email,
                FullName = model.Fullname
            };

            var result = await _userManager.CreateAsync(user, model.Passwd);

            if (result.Succeeded)
            {
                
                return RedirectToAction("Login", "Account");
            }
            
            //kayıt oluşmadığında
            ModelState.AddModelError("", "Kayıt oluşturulamadı. Lütfen tekrar deneyiniz");

            return View(model);
        }

        public IActionResult Login(string ReturnUrl = null)
        {
            return View(new LoginWM()
            {
                ReturnUrl = ReturnUrl
            }); ;

          
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginWM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            //kullanıcı al

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Kullanıcı Bulunamadı");
                return View(model);
            }

            _cartService.InitializeCart(user.Id);
            var result = await _signInManager.PasswordSignInAsync(user, model.Passwd, true, false);
            

            if (result.Succeeded)
            {
                
                return Redirect(model.ReturnUrl?? "~/");
            }
            ModelState.AddModelError("", "Mail adresiniz veya parola yanlış");
              
            return View(model);

        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }

        //public IActionResult ForgotPasswd()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> ForgotPasswd(string Email)
        //{
        //    if (string.IsNullOrEmpty(Email)
        //    {
        //        return View();
        //    }

        //    var user = await _userManager.FindByEmailAsync(Email);

        //    if (user == null)
        //    {
        //        return View();
        //    }

        //    var code = await _userManager.GeneratePasswordResetTokenAsync(user);
        //    var callBackUrl = Url.Action("ResetPasswd", "Account", new
        //    {
        //        userId = user.Id,
        //        token = code
        //    });
        //    return View();


        }

    }

