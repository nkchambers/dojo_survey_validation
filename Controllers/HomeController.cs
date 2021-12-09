using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dojo_survey_validation.Models;


namespace dojo_survey_validation.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public ViewResult Index() //View Result = always render on this route
        {
            return View();
        }


        [HttpPost("")]
        public ViewResult NewNinja(Ninja fromForm)
        {
            // ViewBag.NinjaName = name;
            // ViewBag.Dojo_Location = dojo_location;
            // ViewBag.Favorite_Language = favorite_language;
            // ViewBag.Comment = comment;
            //Ninja ninjaToDisplay = new Ninja(name, dojo_location, favorite_language, comment);

            if(ModelState.IsValid)
            {
                return View(fromForm);
            }
            else
            {
                return View("Index");
            }
        }


        [HttpGet("return_home")]
        public RedirectToActionResult ReturnHome()
        {
            return RedirectToAction("Index");
        }

    }
}