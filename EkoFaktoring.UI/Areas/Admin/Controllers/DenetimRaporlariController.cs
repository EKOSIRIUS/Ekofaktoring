using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class DenetimRaporlariController : CustomBaseController
    {
        public IActionResult BagimsizDenetimRaporlari()
        {
            ViewBag.ActiveTabAdmin = "DenetimRaporları";
            return View();
        }
        public IActionResult BagimsizDerecelendirmeRaporlari()
        {
            ViewBag.ActiveTabAdmin = "DenetimRaporları";
            return View();
        }
    }
}
