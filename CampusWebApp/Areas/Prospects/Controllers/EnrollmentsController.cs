using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CampusWebApp.Areas.Prospects.Models;
using CampusWebApp.Models;

namespace CampusWebApp.Areas.Prospects.Controllers
{
    [Area("Prospects")]
    public class EnrollmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EnrollmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Prospects/Enrollments
        public async Task<IActionResult> Index()
        {


            return View(await _context.Prospects.ToListAsync());
        }

        // GET: Prospects/Enrollments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prospect = await _context.Prospects
                .FirstOrDefaultAsync(m => m.ProspectId == id);
            if (prospect == null)
            {
                return NotFound();
            }

            return View(prospect);
        }

        // GET: Prospects/Enrollments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prospects/Enrollments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProspectId,Name")] Prospect prospect)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prospect);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), "Home");
            }
            return View(prospect);
        }

        // GET: Prospects/Enrollments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prospect = await _context.Prospects.FindAsync(id);
            if (prospect == null)
            {
                return NotFound();
            }
            return View(prospect);
        }

        // POST: Prospects/Enrollments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProspectId,Name")] Prospect prospect)
        {
            if (id != prospect.ProspectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prospect);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProspectExists(prospect.ProspectId))
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
            return View(prospect);
        }

        // GET: Prospects/Enrollments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prospect = await _context.Prospects
                .FirstOrDefaultAsync(m => m.ProspectId == id);
            if (prospect == null)
            {
                return NotFound();
            }

            return View(prospect);
        }

        // POST: Prospects/Enrollments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prospect = await _context.Prospects.FindAsync(id);
            _context.Prospects.Remove(prospect);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProspectExists(int id)
        {
            return _context.Prospects.Any(e => e.ProspectId == id);
        }
    }
}
