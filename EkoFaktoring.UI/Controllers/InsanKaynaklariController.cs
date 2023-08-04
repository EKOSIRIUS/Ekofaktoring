using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class InsanKaynaklariController : Controller
    {
        public IActionResult Kariyer()
        {
            return View();
        }
        public IActionResult Politika()
        {
            return View();
        }
        public IActionResult AcikPozisyonlar()
        {
            return View();
        }
    }
}