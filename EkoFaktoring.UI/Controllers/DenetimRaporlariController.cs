using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class DenetimRaporlariController : Controller
    {
        public IActionResult BagimsizDenetimRaporu()
        {
            ViewBag.ActiveTab = "DenetimRaporlari";
            return View();
        }
        public IActionResult BagimsizDerecelendirmeRaporu()
        {
            ViewBag.ActiveTab = "DenetimRaporlari";
            return View();
        }
    }
}