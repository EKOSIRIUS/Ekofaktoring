using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EkoFaktoring.UI.Controllers
{
    public class HakkimizdaController : Controller
    {
        public IActionResult FirmaProfili()
        {
            ViewBag.ActiveTab = "Hakkimizda";
            return View();
        }
        public IActionResult Misyon()
        {
            ViewBag.ActiveTab = "Hakkimizda";
            return View();
        }
        public IActionResult OrganizasyonSemasi()
        {
            ViewBag.ActiveTab = "Hakkimizda";
            return View();
        }
        public IActionResult KisiselVerilerinKorunmasi()
        {
            ViewBag.ActiveTab = "Hakkimizda";
            return View();
        }
    }
}