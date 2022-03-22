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

        [HttpGet]
        public IActionResult Appointments()
        {
            var Appointments = LTContext.Tours.ToList();
            
            return View(Appointments);
        }

        [HttpGet]
        public IActionResult Delete(int groupid)
        {
            var response_to_delete = LTContext.Tours.Single(x => x.GroupId == groupid);

            return View(response_to_delete);
        }

        [HttpPost]
        public IActionResult Delete(Tour del) //This loads the object you want to delete into the variable "del"
        {
            LTContext.Tours.Remove(del); //Go to blahContext, then the Movies table, then remove the record stored in the "del" variable
            LTContext.SaveChanges();

            return RedirectToAction("Appointments");
        }
    }
}
