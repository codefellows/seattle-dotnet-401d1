using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Class26Demo.Models;

namespace Class26Demo.Controllers
{
    public class CMSController : Controller
    {
        private readonly Class26DemoContext _context;

        public CMSController(Class26DemoContext context)
        {
            _context = context;
        }

        // GET: CMS
        public async Task<IActionResult> Index()
        {
            return View(await _context.CMS.ToListAsync());
        }

        // GET: CMS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cMS = await _context.CMS
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cMS == null)
            {
                return NotFound();
            }

            return View(cMS);
        }

        // GET: CMS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CMS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Content,IsPublished")] CMS cMS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cMS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cMS);
        }

        // GET: CMS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cMS = await _context.CMS.SingleOrDefaultAsync(m => m.ID == id);
            if (cMS == null)
            {
                return NotFound();
            }
            return View(cMS);
        }

        // POST: CMS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Content,IsPublished")] CMS cMS)
        {
            if (id != cMS.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cMS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CMSExists(cMS.ID))
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
            return View(cMS);
        }

        // GET: CMS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cMS = await _context.CMS
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cMS == null)
            {
                return NotFound();
            }

            return View(cMS);
        }

        // POST: CMS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cMS = await _context.CMS.SingleOrDefaultAsync(m => m.ID == id);
            _context.CMS.Remove(cMS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CMSExists(int id)
        {
            return _context.CMS.Any(e => e.ID == id);
        }
    }
}
