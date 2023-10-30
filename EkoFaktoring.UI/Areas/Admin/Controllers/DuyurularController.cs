using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class DuyurularController : CustomBaseController
    {
        public DuyurularController()
        {
            ViewBag.ActiveTabAdmin = "Duyurular";
        }
        public IActionResult Duyurular()
        {
            return View();
        }
        public IActionResult DuyuruYaz()
        {
            return View();
        }
    }
}
