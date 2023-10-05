using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class IletisimController : CustomBaseController
    {
        public IActionResult Iletisim()
        {
            ViewBag.ActiveTabAdmin = "Iletisim";
            return View();
        }
    }
}
