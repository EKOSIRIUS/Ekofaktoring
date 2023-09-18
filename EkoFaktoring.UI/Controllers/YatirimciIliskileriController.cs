using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class YatirimciIliskileriController : Controller
    {
        public IActionResult Bono()
        {
            ViewBag.ActiveTab = "YatirimciIliskileri";
            return View();
        }
    }
}