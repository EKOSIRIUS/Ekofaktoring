﻿using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class IletisimController : CustomBaseController
    {
        public IActionResult Subelerimiz()
        {
            return View();
        }
        public IActionResult BizeUlasin()
        {
            return View();
        }
    }
}
