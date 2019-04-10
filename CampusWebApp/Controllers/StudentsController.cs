using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CampusWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using CampusWebApp.Repository.Interfaces;

namespace CampusWebApp.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        // private readonly IRepository<Student> _context;

        protected IRepository<Student> _context { get; set; }

        public StudentsController(IRepository<Student> context)
        {
            _context = context;
        }

         
         // GET: Students
        public async Task<IActionResult> Index()
        {
         
            return View(await _context.GetAllAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Student = await _context.GetByIdAsync(1);
               
            if (Student == null)
            {
                return NotFound();
            }

            return View(Student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,Name,Email,Password,Type")] Student Student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Student);
                await _context.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Student = await _context.GetByIdAsync(1);
            if (Student == null)
            {
                return NotFound();
            }
            return View(Student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,Name,Email,Password,Type")] Student Student)
        {
            if (id != Student.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Student);
                    await _context.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if ( ! await StudentExists(Student.StudentId))
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
            return View(Student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Student = await _context.GetByIdAsync(1);
               
            if (Student == null)
            {
                return NotFound();
            }

            return View(Student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Student = await _context.GetByIdAsync(id);
                     _context.Remove(Student.StudentId);
            await _context.SaveAsync();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> StudentExists(int id)
        {
            return await _context.GetByIdAsync(id) == null ? false : true;
        }
    }
}
