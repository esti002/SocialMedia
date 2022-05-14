using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.MSSQL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SocialMediaWebMVC.Controllers
{
    public class ProfileController : Controller
    {
        AppUserManager appUserManager = new AppUserManager();

        private readonly UserManager<AppUser> _userManager;

        Context c = new Context();

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            //var username = await _userManager.FindByNameAsync(User.Identity.Name);
            var username = User.Identity.Name;
            ViewBag.name = username;
            var usermail = c.Users.Where(x => x.UserName == username).Select(x => x.Email).FirstOrDefault();
            ViewBag.mail=usermail;
            
            return View();
        }
    }
}
