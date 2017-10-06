using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlaylistSolution.Models;

namespace PlaylistSolution.Controllers
{
    public class PlaylistsSongsController : Controller
    {
        private readonly PlaylistSolutionContext _context;

        public PlaylistsSongsController(PlaylistSolutionContext context)
        {
            _context = context;
        }

        // GET: PlaylistsSongs
        public async Task<IActionResult> Index()
        {
            var playlistSolutionContext = _context.PlaylistSongs.Include(p => p.Playlist).Include(p => p.Song);
            return View(await playlistSolutionContext.ToListAsync());
        }

        // GET: PlaylistsSongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playlistsSongs = await _context.PlaylistSongs
                .Include(p => p.Playlist)
                .Include(p => p.Song)
                .SingleOrDefaultAsync(m => m.playlistID == id);
            if (playlistsSongs == null)
            {
                return NotFound();
            }

            return View(playlistsSongs);
        }

        // GET: PlaylistsSongs/Create
        public IActionResult Create()
        {
            ViewData["playlistID"] = new SelectList(_context.Playlist, "ID", "Name");
            ViewData["songID"] = new SelectList(_context.Song, "ID", "Name");
            return View();
        }

        // POST: PlaylistsSongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("playlistID,songID")] PlaylistsSongs playlistsSongs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(playlistsSongs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["playlistID"] = new SelectList(_context.Playlist, "ID", "ID", playlistsSongs.playlistID);
            ViewData["songID"] = new SelectList(_context.Song, "ID", "ID", playlistsSongs.songID);
            return View(playlistsSongs);
        }

        // GET: PlaylistsSongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playlistsSongs = await _context.PlaylistSongs.SingleOrDefaultAsync(m => m.playlistID == id);
            if (playlistsSongs == null)
            {
                return NotFound();
            }
            ViewData["playlistID"] = new SelectList(_context.Playlist, "ID", "ID", playlistsSongs.playlistID);
            ViewData["songID"] = new SelectList(_context.Song, "ID", "ID", playlistsSongs.songID);
            return View(playlistsSongs);
        }

        // POST: PlaylistsSongs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("playlistID,songID")] PlaylistsSongs playlistsSongs)
        {
            if (id != playlistsSongs.playlistID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(playlistsSongs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlaylistsSongsExists(playlistsSongs.playlistID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["playlistID"] = new SelectList(_context.Playlist, "ID", "ID", playlistsSongs.playlistID);
            ViewData["songID"] = new SelectList(_context.Song, "ID", "ID", playlistsSongs.songID);
            return View(playlistsSongs);
        }

        // GET: PlaylistsSongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playlistsSongs = await _context.PlaylistSongs
                .Include(p => p.Playlist)
                .Include(p => p.Song)
                .SingleOrDefaultAsync(m => m.playlistID == id);
            if (playlistsSongs == null)
            {
                return NotFound();
            }

            return View(playlistsSongs);
        }

        // POST: PlaylistsSongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var playlistsSongs = await _context.PlaylistSongs.SingleOrDefaultAsync(m => m.playlistID == id);
            _context.PlaylistSongs.Remove(playlistsSongs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlaylistsSongsExists(int id)
        {
            return _context.PlaylistSongs.Any(e => e.playlistID == id);
        }
    }
}
