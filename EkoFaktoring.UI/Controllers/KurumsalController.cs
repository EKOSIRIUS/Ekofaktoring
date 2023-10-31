using EkoFaktoring.Core.Models.Kurumsal;
using EkoFaktoring.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class KurumsalController : CustomBaseController
    {
        private readonly IService<FirmaProfil> _profilService;

        public KurumsalController(IService<FirmaProfil> profilService)
        {
            _profilService = profilService;
        }

        public IActionResult SirketProfili()
        {
            return View(_profilService.GetAllAsync().Result.ToList()[0]);
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
