using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class IletisimController : CustomBaseController
    {
        public IletisimController()
        {
            ViewBag.ActiveTabAdmin = "Iletisim";
        }
        public IActionResult Iletisim()
        {
            return View();
        }
    }
}
