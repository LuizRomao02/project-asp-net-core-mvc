using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Workshop.Models;

namespace Workshop.Controllers
{
    public class HomeController : Controller
    {

        // IActionResult --> é uma interface do tipo generico para todo resultado de uma ação
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "teste description page.";
            ViewData["email"] = "lh168205@gmail.com";

            return View(); // metode biulder,metodo auxiliar -- estou instanciando a View() e estou no about
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View(); 
        }

        public IActionResult Privacy()
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
