using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class HakkimizdaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}