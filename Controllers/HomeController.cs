using System.Diagnostics;

using FinanceTrackerApp.Models;

using Microsoft.AspNetCore.Mvc;

namespace FinanceTrackerApp.Controllers

{

    public class HomeController : Controller

    {

        private readonly ILogger<HomeController> _logger;

        private readonly IConfiguration _configuration;

        public HomeController(

            ILogger<HomeController> logger,

            IConfiguration configuration)

        {

            _logger = logger;

            _configuration = configuration;

        }

        public IActionResult Index()

        {

            var dashboard = new FinanceDashboard

            {

                TotalBalance = 12450,

                MonthlyIncome = 4800,

                MonthlyExpenses = 2950,

                MonthlySavings = 1850,

                EnvironmentName =

                    _configuration["FinanceSettings:EnvironmentName"]

                    ?? "Local Development",

                Transactions = new List<Transaction>

                {

                    new Transaction

                    {

                        Description = "Salary",

                        Amount = 2400,

                        Type = "Income"

                    },

                    new Transaction

                    {

                        Description = "Groceries",

                        Amount = 85,

                        Type = "Expense"

                    },

                    new Transaction

                    {

                        Description = "Fuel",

                        Amount = 72,

                        Type = "Expense"

                    },

                    new Transaction

                    {

                        Description = "Internet",

                        Amount = 65,

                        Type = "Expense"

                    }

                }

            };

            return View(dashboard);

        }

        public IActionResult Privacy()

        {

            return View();

        }

        [ResponseCache(

            Duration = 0,

            Location = ResponseCacheLocation.None,

            NoStore = true)]

        public IActionResult Error()

        {

            return View(new ErrorViewModel

            {

                RequestId = Activity.Current?.Id

                    ?? HttpContext.TraceIdentifier

            });

        }

    }

}
