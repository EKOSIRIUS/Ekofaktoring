using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class DuyurularController : CustomBaseController
    {
        public IActionResult EkoDuyurular()
        {
            return View();
        }
        public IActionResult Duyuru()
        {
            return View();
        }
    }
}
