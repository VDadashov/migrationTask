using Microsoft.AspNetCore.Mvc;
using Task1.DataAccessLayer;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Markas.ToList());
        }
    }
}
