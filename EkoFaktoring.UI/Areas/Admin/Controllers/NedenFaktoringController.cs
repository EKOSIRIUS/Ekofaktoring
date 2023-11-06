

using EkoFaktoring.Core.Models.NedenFaktoring;
using EkoFaktoring.Core.Services;
using EkoFaktoring.Repository.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Areas.Admin.Controllers
{
    public class NedenFaktoringController : CustomBaseController
    {
        private readonly IService<FaktoringNedir> _faktoringNedirService;
        private readonly IService<GerekliBelgeler> _gerekliBelgeService;

        public NedenFaktoringController(IService<FaktoringNedir> faktoringNedirService, IService<GerekliBelgeler> gerekliBelgeService)
        {
            _faktoringNedirService = faktoringNedirService;
            _gerekliBelgeService = gerekliBelgeService;
        }

        public IActionResult FaktoringNedir()
        {
            return View(_faktoringNedirService.GetAllAsync().Result.ToList()[0]);
        }
        [HttpPost]
        public async Task<IActionResult> FaktoringNedir(FaktoringNedir nedir)
        {
            var res = _faktoringNedirService.GetAllAsync().Result.ToList()[0];
            res.Icerik = nedir.Icerik;
            await _faktoringNedirService.UpdateAsync(res);
            return RedirectToAction("FaktoringNedir");
        }
        public IActionResult GerekliBelgeler()
        {
            return View(_gerekliBelgeService.GetAllAsync().Result.ToList());
        }
        public IActionResult UpdateGerekliBelge(int id)
        {
            return View(_gerekliBelgeService.GetByIdAsync(id).Result);
        }
        [HttpPost]
        public IActionResult UpdateGerekliBelge(GerekliBelgeler belge)
        {
            var eskiBelge = _gerekliBelgeService.GetByIdAsync(belge.Id).Result;
            eskiBelge.Aciklama = belge.Aciklama;
            eskiBelge.Adi = belge.Adi;
            eskiBelge.Updated_Date = DateTime.Now;
            return RedirectToAction("GerekliBelgeler");
        }
        public IActionResult SikcaSorulanSorular()
        {
            return View();
        }
    }
}
