using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication_MusicShop.Models;

namespace WebApplication_MusicShop
{
    public class SongsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SongsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Songs
        public async Task<IActionResult> Index()
        {
            //var applicationDbContext = _context.Songs.Include(s => s.Genre).Include(s => s.Performer);
            //return View(await applicationDbContext.ToListAsync());

            var genres = _context.Genres.ToList(); // Assuming _context is your DbContext
            ViewBag.Genres = genres;

            var songs = _context.Songs.Include(s => s.Genre).Include(s => s.Performer).ToList();


            return View(songs);

        }

        public IActionResult FilterSongs(int? performerId,int? genreId)
        {
            // Filter songs by performerId otherwise return all songs
            
            var songs = _context.Songs.Include(s => s.Genre).Include(s => s.Performer).ToList();
            if (performerId != null && performerId != 0)
            {
                songs = songs.Where(s => s.PerformerId == performerId).ToList();
            }
            // filter songs by genreId otherwise return all songs
            if (genreId != null && genreId != 0)
            {
                songs = songs.Where(s => s.GenreId == genreId).ToList();
            }

            return PartialView("_SongsList", songs.ToList());
        }

        // implement filterByGenre to get performs and bind to dropdown list
        [HttpGet]
        public IActionResult GetPerformersByGenre(int genreId)
        {
            // return all songs if genreId is null
            var performers = _context.Performers.ToList();
            
            // Select performers by genreId in songs. 
            if (genreId != 0)
            {
                performers = _context.Songs.Where(s => s.GenreId == genreId).Select(s => s.Performer).Distinct().ToList();
            }

            return Json(new SelectList(performers, "PerformerId", "Name"));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSongs()
        {
            var songs = await _context.Songs.Include(s => s.Genre).Include(s => s.Performer).ToListAsync();
            return PartialView("_SongsList", songs);
        }


        // GET: Songs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Songs
                .Include(s => s.Genre)
                .Include(s => s.Performer)
                .FirstOrDefaultAsync(m => m.SongId == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }

        // GET: Songs/Create
        public IActionResult Create()
        {
            ViewData["GenreId"] = new SelectList(_context.Genres, "GenreId", "Name");
            ViewData["PerformerId"] = new SelectList(_context.Performers, "PerformerId", "Name");
            return View();
        }

        // POST: Songs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SongId,Title,Price,GenreId,PerformerId")] Song song)
        {
            if (ModelState.IsValid)
            {
                _context.Add(song);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), "Admin");
            }
            ViewData["GenreId"] = new SelectList(_context.Genres, "GenreId", "GenreId", song.GenreId);
            ViewData["PerformerId"] = new SelectList(_context.Performers, "PerformerId", "PerformerId", song.PerformerId);
            return View(song);
        }

        // GET: Songs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Songs.FindAsync(id);
            if (song == null)
            {
                return NotFound();
            }
            ViewData["GenreId"] = new SelectList(_context.Genres, "GenreId", "Name", song.GenreId);
            ViewData["PerformerId"] = new SelectList(_context.Performers, "PerformerId", "Name", song.PerformerId);
            return View(song);
        }

        // POST: Songs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SongId,Title,Price,GenreId,PerformerId")] Song song)
        {
            if (id != song.SongId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(song);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SongExists(song.SongId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), "Admin");
            }
            ViewData["GenreId"] = new SelectList(_context.Genres, "GenreId", "Name", song.GenreId);
            ViewData["PerformerId"] = new SelectList(_context.Performers, "PerformerId", "Name", song.PerformerId);
            return View(song);
        }

        // GET: Songs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Songs
                .Include(s => s.Genre)
                .Include(s => s.Performer)
                .FirstOrDefaultAsync(m => m.SongId == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }

        // POST: Songs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var song = await _context.Songs.FindAsync(id);
            if (song != null)
            {
                _context.Songs.Remove(song);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), "Admin");
        }

        private bool SongExists(int id)
        {
            return _context.Songs.Any(e => e.SongId == id);
        }
    }
}
