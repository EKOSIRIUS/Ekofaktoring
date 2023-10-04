using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EkoFaktoring.UI.Controllers
{
    public class HakkimizdaController : Controller
    {
        public HakkimizdaController()
        {
            ViewBag.ActiveTab = "Hakkimizda";
        }
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