using Microsoft.AspNetCore.Mvc;
using Task1.DataAccessLayer;
using Task1.Models;

namespace Task1.Controllers
{
    public class CarController : Controller
    {
        private readonly AppDbContext _context;

        public CarController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            if (id == null) return BadRequest();

            if (!_context.Cars.Any(c => c.ModellId == id)) return NotFound();

            return View(_context.Cars.Where(c=>c.ModellId == id).ToList());
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return BadRequest();

            Car car = _context.Cars.FirstOrDefault(c => c.Id == id);

            if (car == null) return NotFound();

            return View(car);
        }
    }
}
