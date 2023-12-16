using EkoFaktoring.Core.Models.Kurumsal;
using EkoFaktoring.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class KurumsalController : CustomBaseController
    {
		//public async Task<IActionResult> SirketProfili([FromServices]IPageService<FirmaProfil> _firmaProfilService)
		//{
		//    var result = await _firmaProfilService.GetPageAsync();
		//    return View(result);
		//}
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
		//public async Task<IActionResult> InsanKaynaklari([FromServices] IPageService<InsanKaynaklariPolitikasi> _politikaService)
		//{
		//    var result = await _politikaService.GetPageAsync();
		//    return View(result);
		//}
	}
}
