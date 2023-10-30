

using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class NedenFaktoringController : CustomBaseController
    {
        public NedenFaktoringController()
        {
            ViewBag.ActiveTabAdmin = "NedenFaktoring";
        }
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
