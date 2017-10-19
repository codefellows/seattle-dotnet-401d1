using class28Demo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace class28Demo.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManger;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManger = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel lvm)
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, lvm.RememberMe, lockoutOnFailure: true);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = rvm.Email, Email = rvm.Email, FirstName = rvm.FirstName, LastName = rvm.LastName, Birthday = rvm.Birthday };
                var result = await _userManger.CreateAsync(user, rvm.Password); 
                
                if(result.Succeeded)
                {
                    //Create a list where my claims will be added to
                    List<Claim> myClaims = new List<Claim>();

                    // claim for the User's role
                    Claim claim1 = new Claim(ClaimTypes.Name, rvm.FirstName + " " + rvm.LastName, ClaimValueTypes.String);
                    myClaims.Add(claim1);

                    //Claim for the user's name
                    Claim claim2 = new Claim(ClaimTypes.Role, "Administrator", ClaimValueTypes.String);
                    myClaims.Add(claim2);

                    // var addRole = await _userManger.AddClaimAsync(user, (new Claim(ClaimTypes.Role, "Administrator", ClaimValueTypes.String)));
                   var addClaims = await _userManger.AddClaimsAsync(user, myClaims);

                    // Make sure the claims were successfully added
                    if(addClaims.Succeeded)
                    {
                        await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, true, lockoutOnFailure: false);

                        return RedirectToAction("Index", "Home");
                    }
   
                }

              
            }
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View("Forbidden");
        }
    }
}
