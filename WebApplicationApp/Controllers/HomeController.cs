using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplicationApp.Models;

namespace WebApplicationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly SpendSmartDbContext _context;

        public HomeController(ILogger<HomeController> logger, SpendSmartDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Expenses()
        {
            List<Expense> allExpenses = _context.Expenses.ToList();
            var totalExpenses = allExpenses.Sum(x => x.Value);
            ViewBag.Expenses = totalExpenses;
            return View(allExpenses);
        }

        

        public IActionResult CreateEditExpense(int? id)
        {
            if (id != null)
            {
                var expenseFound = _context.Expenses.SingleOrDefault(x => x.Id == id);
                return View(expenseFound);

            }
            return View();
        }

        public IActionResult DeleteExpense(int id)
        {
            var expenseFound = _context.Expenses.SingleOrDefault(x => x.Id == id);
            _context.Expenses.Remove(expenseFound);
            _context.SaveChanges();
            return RedirectToAction("Expenses");
        }

        public IActionResult receivedFormData(Expense formData)
        {
            if(formData.Id == 0)
            {
                // Create
                _context.Expenses.Add(formData);
            } else
            {
                // Edit
                _context.Expenses.Update(formData);
            }
            _context.SaveChanges();


            return RedirectToAction("Expenses");
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
