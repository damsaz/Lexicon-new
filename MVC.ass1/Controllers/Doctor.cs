using Microsoft.AspNetCore.Mvc;
using MVC.ass1.Models;
using System.Diagnostics;

namespace MVC.ass1.Controllers
    {
    public class Doctor : Controller
        {
               
        private readonly ILogger<Doctor> _logger;

        public Doctor(ILogger<Doctor> logger)
            {
            _logger = logger;
            }

        public IActionResult fever()
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
