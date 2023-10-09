using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class NedenFaktoringController : CustomBaseController
    {
        public IActionResult FaktoringNedir()
        {
            return View();
        }
        public IActionResult GerekliBelgeler()
        {
            return View();
        }
        public IActionResult SikcaSorulanSorular()
        {
            return View();
        }
    }
}
