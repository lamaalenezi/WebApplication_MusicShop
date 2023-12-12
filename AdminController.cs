using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication_MusicShop.Models;

namespace WebApplication_MusicShop
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var viewModel = new AdminViewModel
            {
                Songs = await _context.Songs.Include(s => s.Genre).Include(s => s.Performer).ToListAsync(),
                Genres = await _context.Genres.ToListAsync(),
                Performers = await _context.Performers.ToListAsync()
            };
            return View(viewModel);
        }
    }
}
