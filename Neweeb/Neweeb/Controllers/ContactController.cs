using Microsoft.AspNetCore.Mvc;

namespace Neweeb.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
