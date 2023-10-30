using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class HomeController : CustomBaseController
    {
        public HomeController()
        {
            ViewBag.ActiveTabAdmin = "Anasayfa";
        }
        public IActionResult Anasayfa()
        {
            return View();
        }
    }
}