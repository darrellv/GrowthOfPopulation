using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrowthOfPopulation.Models;
using Microsoft.AspNetCore.Mvc;

namespace GrowthOfPopulation.Controllers
{
    public class DuplicatesInStringController : Controller
    {
        public IActionResult DuplicatesInString()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DuplicatesInString(Duplicates dup)
        {
            ViewBag.DuplicateCount = dup.GetDuplicateCount(dup.InputString);

            return View();
        }
    }
}