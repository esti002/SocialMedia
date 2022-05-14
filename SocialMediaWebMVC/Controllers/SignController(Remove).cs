using BusinessLayer.Concrete;
using EntityLayer.MSSQL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMediaWebMVC.Models;

namespace SocialMediaWebMVC.Controllers
{
    public class SignController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public SignController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
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
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInViewModel p)
        {
            if (!ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, true, true);//burada ilk verilen true cerezlerde kullanici girisini tutmasini saglar,ikincisi ise belli sayida yanlis giris denemesinde timeout atar
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Register");
                }
                else
                {
                    return RedirectToAction("SignIn", "Sign");
                }
            }
            return View();
        }

        /*
au.Name = data["nameInput"];
au.Surname = data["surnameInput"];
au.UserName = data["usernameInput"];
au.Email = data["mailInput"];
au.PasswordHash = data["passwordInput"];
au.EmailConfirmed = false;
au.SocialPoint = 5;
au.FollowerCount = 0;
au.FollowingCount = 0;
au.RegisterDate = DateTime.Now;
au.Gender = 0;
au.Birthday = System.Convert.ToDateTime(data["birthdayInput"]);
au.ImageUrl = " ";
appUserManager.GenericAdd(au);*/




        /*AppUserManager appUserManager = new AppUserManager();
        private readonly ILogger<HomeController> _logger;

        public SignController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(IFormCollection data)
        {
            AppUser au = new AppUser();

            au.Name = data["nameInput"];
            au.Surname = data["surnameInput"];
            au.UserName = data["usernameInput"];
            au.Email = data["mailInput"];
            au.PasswordHash = data["passwordInput"];
            au.EmailConfirmed = false;
            au.SocialPoint = 5;
            au.FollowerCount = 0;
            au.FollowingCount = 0;
            au.RegisterDate = DateTime.Now;
            au.Gender = 0;
            au.Birthday = System.Convert.ToDateTime(data["birthdayInput"]);
            au.ImageUrl = " ";
            appUserManager.GenericAdd(au);

            return View();
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(IFormCollection data)
        {


            return View();
        }*/
    }
}
