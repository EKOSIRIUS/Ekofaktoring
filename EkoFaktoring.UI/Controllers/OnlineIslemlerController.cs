using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class OnlineIslemlerController : CustomBaseController
    {
        [NonAction]
        public IActionResult OnlineIslem()
        {
            return View();
        }
        [NonAction]
        public IActionResult BasvuruTakip()
        {
            return View();
        }
    }
}
