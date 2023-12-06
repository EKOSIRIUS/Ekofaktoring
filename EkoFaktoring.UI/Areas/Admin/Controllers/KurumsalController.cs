using EkoFaktoring.Core.Models.Kurumsal;
using EkoFaktoring.Core.Models.Kurumsal.DenetimRaporu;
using EkoFaktoring.Core.Models.Kurumsal.TahvilBono;
using EkoFaktoring.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class KurumsalController : CustomBaseController
    {
        private readonly IService<BagimsizDenetimRaporu> _denetimService;
        private readonly IService<BagimsizDerecelendirmeRaporu> _derecelendirmeService;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IPageService<FirmaProfil> _firmaProfilService;
        private readonly ITableService<TahvilBono> _tahvilService;
        private readonly ITableService<YillikBonoTahvil> _yillikTahvilService;
        private readonly IPageService<InsanKaynaklariPolitikasi> _politikaService;

        public KurumsalController(IPageService<FirmaProfil> firmaProfilService, ITableService<TahvilBono> tahvilService, ITableService<YillikBonoTahvil> yillikTahvilService)
        {
            _firmaProfilService = firmaProfilService;
            _tahvilService = tahvilService;
            _yillikTahvilService = yillikTahvilService;
        }

        public async Task<IActionResult> FirmaProfilAsync()
        {
            var result = await _firmaProfilService.GetPageAsync();
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> FirmaProfil(FirmaProfil input)
        {
            await _firmaProfilService.UpdateAsync(input);
            return RedirectToAction("FirmaProfil");
        }
        public async Task<IActionResult> TahvilBono()
        {
            ViewBag.TahvilBono = await _tahvilService.GetDataAsync();
            ViewBag.YillikTahvilBono = await _yillikTahvilService.GetDataAsync();

            return View();
        }
        public IActionResult TahvilBonoSil(int id)
        {
            //silme
            return RedirectToAction("TahvilBono");
        }
        public IActionResult YillikTahvilBonoSil(int id)
        {
            //silme
            return RedirectToAction("TahvilBono");
        }
        [HttpPost]
        public async Task<IActionResult> TahvilBono(TahvilBono tahvil)
        {
            await _tahvilService.SaveDataAsync(tahvil);
            return RedirectToAction("TahvilBono");
        }
        [HttpPost]
        public async Task<IActionResult> YillikTahvilBono(YillikBonoTahvil tahvil)
        {
            await _yillikTahvilService.SaveDataAsync(tahvil);
            return RedirectToAction("TahvilBono");
        }
        public IActionResult DenetimRaporlari()
        {
            ViewBag.BagimsizDerecelendirmeRaporlari = _derecelendirmeService.GetAllAsync().Result;
            ViewBag.BagimsizDenetimRaporlari = _denetimService.GetAllAsync().Result;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BagimsizDenetimRaporu(BagimsizDenetimRaporu denetimRaporu, IFormFile pdf)
        {
            var dosya_yolu = Path.Combine(_hostEnvironment.WebRootPath, "BagimsizDenetimRaporlari");
            if (!Directory.Exists(dosya_yolu))
            {
                Directory.CreateDirectory(dosya_yolu);
            }
            var tamDosyaAdi = Path.Combine(dosya_yolu, pdf.FileName);
            using (var dosyaAkisi = new FileStream(tamDosyaAdi, FileMode.Create))
            {
                await pdf.CopyToAsync(dosyaAkisi);
            }
            denetimRaporu.RaporYolu = "/BagimsizDenetimRaporlari/" + pdf.FileName;

            _denetimService.AddAsync(denetimRaporu);
            return RedirectToAction("DenetimRaporlari");
        }
        [HttpPost]
        public async Task<IActionResult> BagimsizDerecelendirmeRaporu(BagimsizDerecelendirmeRaporu derecelendirmeRaporu, IFormFile pdf)
        {
            var dosya_yolu = Path.Combine(_hostEnvironment.WebRootPath, "DerecelendirmeRaporlari");
            if (!Directory.Exists(dosya_yolu))
            {
                Directory.CreateDirectory(dosya_yolu);
            }
            var tamDosyaAdi = Path.Combine(dosya_yolu, pdf.FileName);
            using (var dosyaAkisi = new FileStream(tamDosyaAdi, FileMode.Create))
            {
                await pdf.CopyToAsync(dosyaAkisi);
            }
            derecelendirmeRaporu.RaporYolu = "/DerecelendirmeRaporlari/" + pdf.FileName;

            _derecelendirmeService.AddAsync(derecelendirmeRaporu);
            return RedirectToAction("DenetimRaporlari");
        }

        public async Task<IActionResult> InsanKaynaklari()
        {
            var result = await _politikaService.GetPageAsync();
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> InsanKaynaklari(InsanKaynaklariPolitikasi politika)
        {
            _politikaService.UpdateAsync(politika);
            return RedirectToAction("InsanKaynaklari");
        }
    }
}
