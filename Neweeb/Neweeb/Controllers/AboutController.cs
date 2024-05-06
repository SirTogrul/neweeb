using Microsoft.AspNetCore.Mvc;

namespace Neweeb.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
