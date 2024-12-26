using Microsoft.AspNetCore.Mvc;

namespace BancaApp.Web.Controllers
{
    public class PagosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registrar()
        {
            return View();
        }
    }
}
