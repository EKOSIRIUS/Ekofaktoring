using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class InsanKaynaklariController : Controller
    {
        public IActionResult Kariyer()
        {
            ViewBag.ActiveTab = "InsanKaynaklari";
            return View();
        }
        public IActionResult Politika()
        {
            ViewBag.ActiveTab = "InsanKaynaklari";
            return View();
        }
        public IActionResult IsBasvuruFormu()
        {
            ViewBag.ActiveTab = "InsanKaynaklari";
            return View();
        }
    }
}