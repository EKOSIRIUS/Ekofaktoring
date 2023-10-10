using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class HomeController : CustomBaseController
    {
        [Route("/")]
        public IActionResult Anasayfa()
        {
            return View();
        }
        public IActionResult KisiselVerilerinKorunmasi()
        {
            return View();
        }
    }
}