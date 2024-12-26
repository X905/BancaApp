using Microsoft.AspNetCore.Mvc;

namespace BancaApp.Web.Controllers
{
    public class HistorialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
