using class28Demo.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
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

                var user = await _userManger.FindByEmailAsync(lvm.Email);

                // THIS IS CHANGED FROM OUR DEMO IN CLASS
                var result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, lvm.RememberMe, false);
                if(result.Succeeded)
                {

                    const string issuer = "www.amanda.com";
                    //Create a list where my claims will be added to
                    List<Claim> myClaims = new List<Claim>();

                    // claim for the User's role
                    Claim claim1 = new Claim(ClaimTypes.Name, user.FirstName + " " + user.LastName, ClaimValueTypes.String, issuer);
                    myClaims.Add(claim1);

                    //Claim for the user's name
                    Claim claim2 = new Claim(ClaimTypes.Role, "Administrator", ClaimValueTypes.String);
                    myClaims.Add(claim2);

                    Claim dateOfBirth = new Claim(ClaimTypes.DateOfBirth, user.Birthday.Date.ToString(), ClaimValueTypes.Date);

                    myClaims.Add(dateOfBirth);

                    var userIdentity = new ClaimsIdentity("Registration");
                    userIdentity.AddClaims(myClaims);

                    var userPrinciple = new ClaimsPrincipal(userIdentity);

                    User.AddIdentity(userIdentity);
                   


                    await HttpContext.SignInAsync(
                        "MyCookieLogin", userPrinciple,
                            new AuthenticationProperties
                            {
                                ExpiresUtc = DateTime.UtcNow.AddMinutes(30),
                                IsPersistent = false,
                                AllowRefresh = false

                            });
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

                    const string issuer = "www.amanda.com";
                    //Create a list where my claims will be added to
                    List<Claim> myClaims = new List<Claim>();

                    // claim for the User's role
                    Claim claim1 = new Claim(ClaimTypes.Name, rvm.FirstName + " " + rvm.LastName, ClaimValueTypes.String, issuer);
                    myClaims.Add(claim1);

                    //Claim for the user's name
                    Claim claim2 = new Claim(ClaimTypes.Role, "Administrator", ClaimValueTypes.String);
                    myClaims.Add(claim2);

                    Claim dateOfBirth = new Claim(ClaimTypes.DateOfBirth, rvm.Birthday.Date.ToString(), ClaimValueTypes.Date);

                    myClaims.Add(dateOfBirth);


                    // var addRole = await _userManger.AddClaimAsync(user, (new Claim(ClaimTypes.Role, "Administrator", ClaimValueTypes.String)));
                   var addClaims = await _userManger.AddClaimsAsync(user, myClaims);

                    return RedirectToAction("Index", "Home");
   
                }

              
            }
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View("Forbidden");
        }

        [Authorize]
        public IActionResult Logout()
        {
            _signInManager.SignOutAsync();
            return View();
        }
    }
}
