﻿using Microsoft.AspNetCore.Mvc;

namespace SocialMediaWebMVC.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
