using Microsoft.AspNetCore.Mvc;
using MVCMiniProjects.Models;
using System.Diagnostics;
using MVCMiniProjects.Services;

namespace MVCMiniProjects.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }



        [HttpGet]
        public IActionResult Palindrome()
        {
            Palindrome palindrome = new();
            return View(palindrome);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Palindrome([Bind("UserInput")] Palindrome palindrome)
        {
            if (string.IsNullOrEmpty(palindrome.UserInput)) return View(palindrome);

            palindrome = PalindromeService.Reverse(palindrome.UserInput);
            return View(palindrome);
        }


        [HttpGet]
        public IActionResult FizzBuzz()
        {
            FizzBuzz fizzBuzz = new();
            return View(fizzBuzz);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FizzBuzz([Bind("StartValue", "EndValue")] FizzBuzz fizzBuzz)
        {
            if (fizzBuzz.StartValue < 1 || fizzBuzz.EndValue < 1) return View(fizzBuzz);
            if(fizzBuzz.StartValue > fizzBuzz.EndValue) return View(fizzBuzz);

            fizzBuzz = FizzBuzzService.Calculate(fizzBuzz);
            return View(fizzBuzz);
        }

        



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
