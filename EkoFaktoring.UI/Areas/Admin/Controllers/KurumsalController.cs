using EkoFaktoring.Core.Models.Kurumsal;
using EkoFaktoring.Core.Models.Kurumsal.DenetimRaporu;
using EkoFaktoring.Core.Models.Kurumsal.TahvilBono;
using EkoFaktoring.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class KurumsalController : CustomBaseController
    {
        private readonly IService<FirmaProfil> _profilService;
        private readonly IService<YillikBonoTahvil> _yillikBonoService;
        private readonly IService<TahvilBono> _bonoService;
        private readonly IService<InsanKaynaklariPolitikasi> _politikaService;
        private readonly IService<BagimsizDenetimRaporu> _denetimService;
        private readonly IService<BagimsizDerecelendirmeRaporu> _derecelendirmeService;
        private readonly IWebHostEnvironment _hostEnvironment;
        public KurumsalController(IService<FirmaProfil> profilService, IService<InsanKaynaklariPolitikasi> politikaService, IService<YillikBonoTahvil> yillikBonoService, IService<TahvilBono> bonoService, IWebHostEnvironment hostEnvironment, IService<BagimsizDenetimRaporu> denetimService, IService<BagimsizDerecelendirmeRaporu> derecelendirmeService)
        {
            _profilService = profilService;
            _politikaService = politikaService;
            _yillikBonoService = yillikBonoService;
            _bonoService = bonoService;
            _hostEnvironment = hostEnvironment;
            _denetimService = denetimService;
            _derecelendirmeService = derecelendirmeService;
        }

        public IActionResult FirmaProfil()
        {
            return View(_profilService.GetAllAsync().Result.ToList()[0]);
        }
        [HttpPost]
        public async Task<IActionResult> FirmaProfil(FirmaProfil input)
        {
            var res = _profilService.GetAllAsync().Result.ToList()[0];
            res.Icerik = input.Icerik;
            await _profilService.UpdateAsync(res);
            return RedirectToAction("FirmaProfil");
        }
        public IActionResult TahvilBono()
        {
            ViewBag.TahvilBono = _bonoService.GetAllAsync().Result.ToList();
            ViewBag.YillikTahvilBono = _yillikBonoService.GetAllAsync().Result.ToList();

            return View();
        }
        public IActionResult TahvilBonoSil(int id)
        {
            _bonoService.RemoveAsync(_bonoService.GetByIdAsync(id).Result);
            return RedirectToAction("TahvilBono");
        }
        public IActionResult YillikTahvilBonoSil(int id)
        {
            _yillikBonoService.RemoveAsync(_yillikBonoService.GetByIdAsync(id).Result);
            return RedirectToAction("TahvilBono");
        }
        [HttpPost]
        public async Task<IActionResult> TahvilBono(TahvilBono tahvil)
        {
            await _bonoService.AddAsync(tahvil);
            return RedirectToAction("TahvilBono");
        }
        [HttpPost]
        public async Task<IActionResult> YillikTahvilBono(YillikBonoTahvil tahvil)
        {
            await _yillikBonoService.AddAsync(tahvil);
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
        public IActionResult InsanKaynaklari()
        {
            return View(_politikaService.GetAllAsync().Result.ToList()[0]);
        }

        [HttpPost]
        public async Task<IActionResult> InsanKaynaklari(InsanKaynaklariPolitikasi politika)
        {
            var res = _politikaService.GetAllAsync().Result.ToList()[0];
            res.Icerik = politika.Icerik;
            await _politikaService.UpdateAsync(res);
            return RedirectToAction("InsanKaynaklari");
        }
    }
}
