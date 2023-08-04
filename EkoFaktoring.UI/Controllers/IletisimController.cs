using EkoFaktoring.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EkoFaktoring.UI.Controllers
{
    public class IletisimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(IletisimMailGonderModel model)
        {
            // TODO: EmailService yazılacak
            model.Status = true;
            return View(model);
        }
    }
}