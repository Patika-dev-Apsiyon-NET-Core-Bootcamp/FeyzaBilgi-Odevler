using BookListApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookListApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<UserViewModel> users = new List<UserViewModel>() 
        {
          new UserViewModel
          {
            Id = 1,
            Name = "Feyza",
            SurName = "Bilgiç",
            Email = "feyzabilgic00@gmail.com",
            Password = "1234",
            UserName = "feyzabilgic00"
          },
           new UserViewModel
          {
            Id = 1,
            Name = "Emine",
            SurName = "Bilgiç",
            Email = "emine123@gmail.com",
            Password = "123",
            UserName = "emine123"
          }
        };
               
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
             HttpContext.Session.Set<List<UserViewModel>>("users", users);
        
            return RedirectToAction("Index","Home");
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
