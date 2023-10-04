using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class YatirimciIliskileriController : Controller
    {
        public YatirimciIliskileriController()
        {
            ViewBag.ActiveTab = "YatirimciIliskileri";
        }
        public IActionResult Bono()
        {
            return View();
        }
    }
}