using anamportalboletas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace anamportalboletas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Boletas()
        {
            //mis cambios se deben reflejar en el repositorio
            return View();
        }
        
        public IActionResult BoletasImprime()
        {
            return View();
        }


        //create function to validate an email

        public IActionResult Formulario()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}