using LaytonTemple.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaytonTemple.Controllers
{
    public class HomeController : Controller
    {
        private LaytonTempleContext LTContext { get; set; } // add this to connect to db

        public HomeController(LaytonTempleContext someName)
        {
            LTContext = someName;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
