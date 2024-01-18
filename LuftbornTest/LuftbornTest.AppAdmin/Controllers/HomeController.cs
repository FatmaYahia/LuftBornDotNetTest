using DAL;
using LuftbornTest.AppAdmin.Filter;
using LuftbornTest.AppAdmin.Models;
using LuftbornTest.AppAdmin.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LuftbornTest.AppAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext DB;
        public HomeController(ILogger<HomeController> logger,DataContext DB)
        {
            _logger = logger;
            this.DB = DB;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View(new HomeVM
            {
                employess = DB.Employees.Count(),
                Department = DB.Departments.Count(),
              
            });
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