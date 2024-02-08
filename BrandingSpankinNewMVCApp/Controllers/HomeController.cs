using BrandingSpankinNewMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BrandingSpankinNewMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //action result for the home page
        public IActionResult Index()
        {
            return View(new HomeControllerModel());
        }

        //action result for the Calculator page
        public IActionResult Calculator()
        {
            //make a model and set hourly charge equal to 120
            var model = new HomeControllerModel
            {
                HourlyCharge = 20
            };
            return View(model);
        }
        //action result for calculating the total charge
        public IActionResult CalculateTotal (HomeControllerModel model)
        {
            // if statement for seeing if the statement is valid and calculate total from the model. 
            if (ModelState.IsValid)
            {
                model.Total = model.Hours * model.HourlyCharge;
                return View("Calculator", model);
            }

            return View("Calculator", model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
