using EntityLayer.MSSQL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMediaWebMVC.Models;

namespace SocialMediaWebMVC.Controllers
{
    public class SignUpController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SignUpController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpViewModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    UserName = p.Username,
                    Email = p.Mail,
                    EmailConfirmed = false,
                    FollowerCount = 0,
                    FollowingCount = 0,
                    RegisterDate = DateTime.Now,
                    Gender = 0,
                    Birthday = System.Convert.ToDateTime(p.Birthday),
                    ImageUrl = " "
                };
                var result = await _userManager.CreateAsync(user, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Sign");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", errorMessage: item.Description);
                    }
                }
            }
            return View();
        }
    }
}
