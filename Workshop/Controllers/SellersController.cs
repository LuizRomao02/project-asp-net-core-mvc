﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Workshop.Services;

namespace Workshop.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerServices;

        public SellersController(SellerService sellerService) //construtor para injetar a dependencia
        {
            _sellerServices = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerServices.FindAll();

            return View(list);
        }
    }
}