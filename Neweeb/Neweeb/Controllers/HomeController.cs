using Microsoft.AspNetCore.Mvc;
using Neweeb.Models;

namespace Neweeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new Customer()
            {
                Fullname="Vladimir Putin",
                Comment="Veli hardadir? onu gozleryirem rusyetde",
                Profilphoto="download.jpeg"
            };
            Customer customer1 = new Customer()
            {
                Fullname = "Haschbullah Magomedovich Magomedov",
                Comment = "Fight me!!!",
                Profilphoto="hasbullah.jpeg"
            };
            List<Customer> customers = new List<Customer>();
            customers.Add(customer);
            customers.Add(customer1);
            return View(customers);
        }
    }
}
