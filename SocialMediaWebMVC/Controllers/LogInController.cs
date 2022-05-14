using EntityLayer.MSSQL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMediaWebMVC.Models;

namespace SocialMediaWebMVC.Controllers
{
    public class LogInController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LogInController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, true, true);//burada ilk verilen true cerezlerde kullanici girisini tutmasini saglar,ikincisi ise belli sayida yanlis giris denemesinde timeout atar
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "HomePage");
                }
                else
                {
                    return RedirectToAction("Index", "LogIn");
                }
            }
            return View();
        }
    }
}
