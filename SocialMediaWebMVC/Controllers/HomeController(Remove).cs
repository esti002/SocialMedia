using BusinessLayer.Concrete;
using EntityLayer.MSSQL;
using Microsoft.AspNetCore.Mvc;
using SocialMediaWebMVC.Models;
using System.Diagnostics;
using System.Net;

namespace SocialMediaWebMVC.Controllers
{
    public class HomeController : Controller
    {
        AppUserManager memberManager = new AppUserManager();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
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
            AppUser m = new AppUser();

            /*m.Name = data["deneme11"];
            m.Surname = "a";
            m.Date = DateTime.Now;
            m.Mail = "sdasad";
            m.SocialityPoint = 5;
            m.FollowerCount = 10;  
            m.FollowingCount = 10;
            m.Password = "asdad";
            m.VerifyMail = false;
            memberManager.GenericAdd(m);*/

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}