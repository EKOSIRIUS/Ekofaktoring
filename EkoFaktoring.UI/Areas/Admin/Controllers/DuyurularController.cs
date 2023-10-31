using EkoFaktoring.Core.Models.Duyurular;
using EkoFaktoring.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class DuyurularController : CustomBaseController
    {
        public IActionResult Duyurular()
        {
            return View();
        }
        public IActionResult DuyuruYaz()
        {
            return View();
        }
    }
}
