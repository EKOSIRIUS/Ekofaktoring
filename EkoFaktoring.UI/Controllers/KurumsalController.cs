using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class KurumsalController : CustomBaseController
    {
        public IActionResult SirketProfili()
        {
            return View();
        }
        public IActionResult OrganizasyonSemasi()
        {
            return View();
        }
        public IActionResult YatirimciIliskileri()
        {
            return View();
        }
        public IActionResult DenetimRaporlari()
        {
            return View();
        }
        public IActionResult InsanKaynaklari()
        {
            return View();
        }
    }
}
