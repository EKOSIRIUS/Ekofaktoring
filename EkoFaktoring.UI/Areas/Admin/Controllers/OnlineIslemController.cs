using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class OnlineIslemController : CustomBaseController
    {
        public OnlineIslemController()
        {
            ViewBag.ActiveTabAdmin = "OnlineIslem";
        }
        public IActionResult OnlineIslem()
        {
            return View();
        }
    }
}
