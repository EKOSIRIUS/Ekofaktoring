﻿using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class IletisimController : CustomBaseController
    {
        public IActionResult Iletisim()
        {
            return View();
        }
    }
}
