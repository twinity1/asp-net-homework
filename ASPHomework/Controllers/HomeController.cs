﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
 using ASPHomework.Persistence.Repositories;
 using ASPHomework.Persistence.Repositories.Interfaces;
 using Microsoft.AspNetCore.Mvc;
using ASPNetCoreHomework.Models;

namespace ASPNetCoreHomework.Controllers
{
    public class HomeController : Controller
    {
        private IDestinationRepository _destinationRepository;

        public HomeController(IDestinationRepository destinationRepository)
        {
            _destinationRepository = destinationRepository;
        }


        public IActionResult Index()
        {
            var model = new HomeIndexViewModel()
            {
                Destinations = _destinationRepository.FindAll()
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}