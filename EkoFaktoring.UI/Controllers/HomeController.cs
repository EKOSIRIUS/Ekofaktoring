﻿using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            ViewBag.ActiveTab = "Anasayfa";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}