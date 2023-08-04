using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class HakkimizdaController : Controller
    {
        public IActionResult FirmaProfili()
        {
            return View();
        }
        public IActionResult Misyon()
        {
            return View();
        }
        public IActionResult OrganizasyonSemasi()
        {
            return View();
        }
        public IActionResult KisiselVerilerinKorunmasi()
        {
            return View();
        }
    }
}