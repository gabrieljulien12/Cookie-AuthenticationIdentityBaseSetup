using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities;
using Cookie_Based_AuthenticationWithIdenty.Models.ViewModels.AppUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using IdentitySign = Microsoft.AspNetCore.Identity.SignInResult;

namespace Cookie_Based_AuthenticationWithIdenty.Controllers
{
    
    public class AuthController : Controller
    {
        readonly UserManager<AppUser> _userManeger;
        readonly SignInManager<AppUser> _signInManager;

        public AuthController(UserManager<AppUser> userManeger, SignInManager<AppUser> signInManager)
        {
            _userManeger = userManeger;
            _signInManager = signInManager;
        }

        public IActionResult Index()    
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
        
        public IActionResult Register ()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterRequestModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new()
                {
                    UserName = model.UserName,
                    Email = model.Email,

                };
                IdentityResult resault = await _userManeger.CreateAsync(appUser,model.Password);

                if (resault.Succeeded)
                {
                    TempData["Message"] = "Create User";
                    return RedirectToAction("Index");
                }
                foreach (IdentityError eror in resault.Errors)
                {
                    ModelState.AddModelError("",eror.Description);
                }
            }

            return View(model);
        }

        public IActionResult SıgIn(string ReturnUrl)
        {
            UserSignInRequestModel usModel = new()
            {
                ReturnUrl = ReturnUrl,
            };
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> SıgIn(UserSignInRequestModel model)
        {
            if (ModelState.IsValid) 
            {
                AppUser appUser =  await _userManeger.FindByNameAsync(model.UserName);
                IdentitySign signinresault = await _signInManager.PasswordSignInAsync(appUser, model.Password, model.RememberMe,false); //buna true verirsen örnek olarak 3 kez yanlıs girildimi hesabı engelle 
                if(signinresault.Succeeded)
                {
                    if(!string.IsNullOrEmpty(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }
                else if(appUser== null)
                {
                    ModelState.AddModelError("", "User Not Found");
                }

            }
            return View(model);
        }
    }
}
