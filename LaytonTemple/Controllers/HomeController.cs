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
            var AppointmentTable = LTContext.Tours.ToList();
            
            return View(AppointmentTable);
        }

        
        // SIGN UP FORM GET
        [HttpGet] 
        public IActionResult SignUpForm()
        {
            return View(); 
        }

        // SIGN UP FORM POST
        [HttpPost]
        public IActionResult SignUpForm(Tour t)
        {
            if (ModelState.IsValid)
            {
                LTContext.Add(t);
                LTContext.SaveChanges();
                return View("Index", t);
            }

            else
            {
                ViewBag.Categories = LTContext.AvailableTimes.ToList(); // not sure I need this? 
                return View(t);
            }
            
        }


        // EDIT BUTTON GET
        [HttpGet]
        public IActionResult Edit(int groupId)
        {
            ViewBag.Categories = LTContext.AvailableTimes.ToList(); // may not need this line - we will see? 

            var group = LTContext.Tours.Single(x => x.GroupId == groupId); 

            return View("SignUpForm", group);
            
        }

        // EDIT BUTTON POST
        [HttpPost]
        public IActionResult Edit (Tour t)
        {
            if (ModelState.IsValid)
            {
                LTContext.Update(t);
                LTContext.SaveChanges();
                return RedirectToAction("Appointments");
            }

            else
            {
                ViewBag.Categories = LTContext.AvailableTimes.ToList();
                return View("SignUpForm", t);
            }
        }


    }
}
