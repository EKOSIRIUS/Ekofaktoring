using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class InsanKaynaklariController : CustomBaseController
    {
        public IActionResult InsanKaynaklariPolitikamiz()
        {
            ViewBag.ActiveTabAdmin = "InsanKaynakları";
            return View();
        }
        public IActionResult Kariyer()
        {
            ViewBag.ActiveTabAdmin = "InsanKaynakları";
            return View();
        }
        public IActionResult IsBasvuruFormu()
        {
            ViewBag.ActiveTabAdmin = "InsanKaynakları";
            return View();
        }
    }
}
