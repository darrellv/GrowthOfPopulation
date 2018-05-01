using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrowthOfPopulation.Models;
using Microsoft.AspNetCore.Mvc;

namespace GrowthOfPopulation.Controllers
{
    public class SumTwoLowestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SumTwoLowest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumTwoLowest(SumOfLowest sol)
        {
            ViewBag.Lowest = sol.strLowest;
            ViewBag.Result = sol.SumTwoSmallestNumbers(sol.TwoLowest);

            return View();
        }


    }
}