using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class AnasayfaController : CustomBaseController
    {
        public IActionResult Anasayfa()
        {
            ViewBag.ActiveTabAdmin = "Anasayfa";
            return View();
        }
    }
}