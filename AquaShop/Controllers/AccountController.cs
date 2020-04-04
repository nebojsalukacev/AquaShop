using AquaShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(LogInViewModel logInViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(logInViewModel.Email, logInViewModel.Password,
                                                                     logInViewModel.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid Login Attempt");
            }
            return View(logInViewModel);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = registerViewModel.Email, Email = registerViewModel.Email };
                var result = await userManager.CreateAsync(user, registerViewModel.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("LoggedIn", "Account");

                }
                else
                {
                    foreach (var err in result.Errors)
                    {
                        ModelState.AddModelError("", err.Description);
                    }
                }
            }
            return View(registerViewModel);
        }

        [HttpPost]      
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult LoggedIn() => View();

    }
}
