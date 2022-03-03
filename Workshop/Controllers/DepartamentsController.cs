using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Workshop.Models;

namespace Workshop.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {

            List<Departament> list = new List<Departament>();
            list.Add(new Departament { Id = 1, Name = "Eletronico" });
            list.Add(new Departament { Id = 2, Name = "Moda" });

            return View(list);
        }
    }
}