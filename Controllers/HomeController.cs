using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("users")]
        public IActionResult Users()
        {
            Individual personOne = new Individual()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };
            Individual personTwo = new Individual()
            {
                FirstName = "Sarah",
                LastName = ""
            };
            Individual personThree = new Individual()
            {
                FirstName = "Jerry",
                LastName = ""
            };
            Individual personFour = new Individual()
            {
                FirstName = "Renee",
                LastName = "Ricky"
            };
            Individual personFive = new Individual()
            {
                FirstName = "Barbarah",
                LastName = " "
            };

            List<Individual> viewModel = new List<Individual>()
            {
                personOne, personTwo, personThree, personFour, personFive
            };

            return View(viewModel);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] ListONums = new int[] {1, 2, 3, 10, 43, 5};
            Number numberOne = new Number()
            {
                NumberList = ListONums
            };
            return View(numberOne);
        }

        [HttpGet("user")]

        public IActionResult User()
        {
            Person onePerson = new Person()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };

            ViewBag.User = onePerson;

            return View(onePerson);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
