using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GrowthOfPopulation.Models;

namespace GrowthOfPopulation.Controllers
{
    public class KataController : Controller
    {
        public IActionResult WhichAreIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WhichAreIn(WhichAreIn which)
        {
            string[] result = which.inArray();

            ViewBag.Result = string.Join(",", result);

            return View();
        }
    }
}