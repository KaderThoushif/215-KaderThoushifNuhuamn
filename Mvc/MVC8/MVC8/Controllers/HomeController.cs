﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC8.Models;
using MVC8.myLogger;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace MVC8.Controllers
{
    public class HomeController : Controller
    {
        ILog _log;

        public HomeController(ILog log)
        {
            _log = log;
        }
        public IActionResult Index()
        {
            _log.info("Executing/home/index");

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
