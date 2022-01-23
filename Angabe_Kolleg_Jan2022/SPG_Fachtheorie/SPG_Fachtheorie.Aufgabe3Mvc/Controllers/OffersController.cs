using Microsoft.AspNetCore.Mvc;

namespace SPG_Fachtheorie.Aufgabe3Mvc.Controllers
{
    public class OffersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
