using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutocompleteTextboxusingJquery.Models;

namespace AutocompleteTextboxusingJquery.Controllers
{
    public class HomeController : Controller
    {
        //Displays Index View
        public ActionResult Index()
        {
            return View();
        }
        //returns the json data to the View for Autocomplete textbox.

        public JsonResult GetStudents(string term)
        {

            Xoriant121Entities db = new Xoriant121Entities();
            List<string> students = db.Students.Where(s => s.Name.StartsWith(term))
                .Select(x => x.Name).ToList();
            return Json(students, JsonRequestBehavior.AllowGet);

        }


    }



}
