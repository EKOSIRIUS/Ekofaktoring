using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class KurumsalController : CustomBaseController
    {
        public KurumsalController()
        {
            ViewBag.ActiveTabAdmin = "Kurumsal";
        }
        public IActionResult FirmaProfil()
        {
            return View();
        }
        public IActionResult TahvilBono()
        {
            return View();
        }
        public IActionResult DenetimRaporlari()
        {
            return View();
        }
        public IActionResult InsanKaynaklari()
        {
            return View();
        }
    }
}
