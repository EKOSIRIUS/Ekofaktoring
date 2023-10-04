using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class InsanKaynaklariController : Controller
    {
        public InsanKaynaklariController()
        {
            ViewBag.ActiveTab = "InsanKaynaklari";

        }
        public IActionResult Kariyer()
        {
            return View();
        }
        public IActionResult Politika()
        {
            return View();
        }
        public IActionResult IsBasvuruFormu()
        {
            return View();
        }
    }
}