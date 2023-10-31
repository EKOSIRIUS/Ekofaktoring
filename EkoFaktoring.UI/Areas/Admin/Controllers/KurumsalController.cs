using EkoFaktoring.Core.Models.Kurumsal;
using EkoFaktoring.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class KurumsalController : CustomBaseController
    {
        private readonly IService<FirmaProfil> _profilService;

        public KurumsalController(IService<FirmaProfil> profilService)
        {
            _profilService = profilService;
        }

        public IActionResult FirmaProfil()
        {
            return View(_profilService.GetAllAsync().Result.ToList()[0]);
        }
        [HttpPost]
        public async Task<IActionResult> FirmaProfilAsync(FirmaProfil input)
        {
            var res = _profilService.GetAllAsync().Result.ToList()[0];
            res.Icerik = input.Icerik;
            await _profilService.UpdateAsync(res);
            return RedirectToAction("FirmaProfil");
        }
        public IActionResult TahvilBono()
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
