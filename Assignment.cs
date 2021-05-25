using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    public class Assignment : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult RegistrationForm()
        {
            return View(new Person());
        }
        public IActionResult DisplayForm(Person person)
        {
            if (person != null)
            {
                ViewBag.CommonMessage = "Thank You  " + person.Name;
                if (person.WillAttend == "yes")
                {
                    ViewBag.message = "Thank You for Coming";
                }
                if (person.WillAttend == "no")
                {
                    ViewBag.message = "Sorry  to hear you";
                }
            }
            return View();
                
            }


        }
    }

