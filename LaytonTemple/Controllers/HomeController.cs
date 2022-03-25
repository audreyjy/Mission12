using LaytonTemple.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var Appointments = LTContext.Tours
                .Include(x => x.AvailableTimes)
                .ToList();
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

        
        // SIGN UP FORM GET
        [HttpGet] 
        public IActionResult SignUpForm(int timeId)
        {
            ViewBag.TimeId = timeId; 
            return View("SignUpForm"); 
        }

        // SIGN UP FORM POST
        [HttpPost]
        public IActionResult SignUpForm(Tour t)
        {
            if (ModelState.IsValid)
            {
                var time = LTContext.AvailableTimes.Single(x => x.TimeId == t.TimeId); 
                time.Filled = true; 

                LTContext.Add(t);
                LTContext.SaveChanges();
                return RedirectToAction("Index");
            }

            else
            {
                ViewBag.AvailableTimes = LTContext.AvailableTimes.ToList(); // not sure I need this? 
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


        [HttpGet]
        public IActionResult TimeSlots()
        {
            ViewBag.times = LTContext.AvailableTimes.ToList();
            ViewBag.filled = LTContext.Tours.ToList();

            return View("TimeSlots");
        }

        [HttpPost]
        public IActionResult TimeSlots(AvailableTimes t)
        {

            var time = t.TimeId;
            return RedirectToAction("SignUpForm", time); 
        }

    }
}
