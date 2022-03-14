using Microsoft.AspNetCore.Mvc;
using Site1.Models;
using System.Diagnostics;

namespace Site1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductsList()
        {
            return View();
        }
        
    }
}