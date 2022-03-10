using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Workshop.Models;
using Workshop.Models.ViewModels;
using Workshop.Services;

namespace Workshop.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerServices;
        private readonly DepartamentService _departamentService;

        public SellersController(SellerService sellerService, DepartamentService departamentService) //construtor para injetar a dependencia
        {
            _sellerServices = sellerService;
            _departamentService = departamentService;
        }

        public IActionResult Index()
        {
            var list = _sellerServices.FindAll();

            return View(list);
        }

        public IActionResult Create()
        {
            var departaments = _departamentService.FindAll();
            var viewModel = new SellerFormViewModel { Departaments = departaments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Seller seller)
        {
            _sellerServices.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}