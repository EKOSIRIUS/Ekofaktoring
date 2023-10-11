using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class OnlineIslemlerController : CustomBaseController
    {
        public IActionResult OnlineIslem()
        {
            return View();
        }

        public IActionResult BasvuruTakip()
        {
            return View();
        }
    }
}
