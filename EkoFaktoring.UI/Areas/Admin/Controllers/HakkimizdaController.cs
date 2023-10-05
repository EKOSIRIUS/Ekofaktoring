using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class HakkimizdaController : CustomBaseController
    {
        public IActionResult FirmaProfil()
        {
            ViewBag.ActiveTabAdmin = "Hakkımızda";
            return View();
        }
        public IActionResult VizyonMisyon()
        {
            ViewBag.ActiveTabAdmin = "Hakkımızda";
            return View();
        }
    }
}
