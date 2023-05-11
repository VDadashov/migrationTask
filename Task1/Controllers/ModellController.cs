using Microsoft.AspNetCore.Mvc;
using Task1.DataAccessLayer;

namespace Task1.Controllers
{
    public class ModellController : Controller
    {
        private readonly AppDbContext _context;

        public ModellController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            if (id == null) return BadRequest();

            if (!_context.Models.Any(x => x.MarkaId == id)) return NotFound();

            return View(_context.Models.Where(s=>s.MarkaId == id).ToList());
        }
    }
}
