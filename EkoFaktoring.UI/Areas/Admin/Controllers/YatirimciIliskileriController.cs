using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class YatirimciIliskileriController : CustomBaseController
    {
        public IActionResult TahvilBono()
        {
            ViewBag.ActiveTabAdmin = "Yatırımcıİliskileri";
            return View();
        }
    }
}
