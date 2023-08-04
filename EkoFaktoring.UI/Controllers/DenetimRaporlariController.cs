using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class DenetimRaporlariController : Controller
    {
        public IActionResult BagimsizDenetimRaporu()
        {
            return View();
        }
        public IActionResult BagimsizDerecelendirmeRaporu()
        {
            return View();
        }
    }
}