using Microsoft.AspNetCore.Mvc;

namespace Neweeb.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
