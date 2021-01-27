/*< !--Preston Loveland
     Assignment 1 IS 414
    Group 11 Section 1-->*/
using FirstASPNETWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPNETWebApp.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            //throw new IndexOutOfRangeException();

            return View();
        }
        //if Get execute this method
        [HttpGet("GradeCalculator")]
        public IActionResult GradeCalculator()
        {
            return View();
        }

        //if Post execute this method bc of tagHelper
        [HttpPost("GradeCalculator")]
        public IActionResult GradeCalculator(GradeCalculatorModel model)
        {
            return View();
        }
    }
}
