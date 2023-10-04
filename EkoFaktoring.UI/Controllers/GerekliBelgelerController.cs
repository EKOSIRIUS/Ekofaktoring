using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class GerekliBelgelerController : Controller
    {
        public GerekliBelgelerController()
        {
            ViewBag.ActiveTab = "GerekliBelgeler";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
