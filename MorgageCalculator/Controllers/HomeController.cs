using Microsoft.AspNetCore.Mvc;
using MorgageCalculator.Models;
using System.Diagnostics;
using MorgageCalculator.Methods;
namespace MorgageCalculator.Controllers
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

        public IActionResult App()

          
        {

            Loan loan = new();
            loan.payment = 0.0m;
            loan.totalinteres = 0.0m;
            loan.totalinteres = 0.0m;
            loan.rate = 0;
            loan.amount = 0m;
            loan.term = 0;
           


            return View(loan);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult App(Loan loan)
        {

            var method = new Loanmethods();


            Loan newloan = method.GetPayments(loan);





            return View(loan);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });



        }
    }
}