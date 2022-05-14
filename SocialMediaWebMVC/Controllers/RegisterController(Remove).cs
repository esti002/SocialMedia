using Microsoft.AspNetCore.Mvc;

namespace SocialMediaWebMVC.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
