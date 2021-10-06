using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenTamThanh080.Models;

namespace NguyenTamThanh080.Controllers
{
    public class PersonNTT080Controller : Controller
    {
        private readonly ApplicationContext _context;

        public PersonNTT080Controller(ApplicationContext context)
        {
            _context = context;
        }

        // GET: PersonNTT080
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonNTT080.ToListAsync());
        }

        // GET: PersonNTT080/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTT080 = await _context.PersonNTT080
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNTT080 == null)
            {
                return NotFound();
            }

            return View(personNTT080);
        }

        // GET: PersonNTT080/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonNTT080/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonNTT080 personNTT080)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personNTT080);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personNTT080);
        }

        // GET: PersonNTT080/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTT080 = await _context.PersonNTT080.FindAsync(id);
            if (personNTT080 == null)
            {
                return NotFound();
            }
            return View(personNTT080);
        }

        // POST: PersonNTT080/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,PersonName")] PersonNTT080 personNTT080)
        {
            if (id != personNTT080.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personNTT080);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonNTT080Exists(personNTT080.PersonId))
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
            return View(personNTT080);
        }

        // GET: PersonNTT080/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTT080 = await _context.PersonNTT080
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNTT080 == null)
            {
                return NotFound();
            }

            return View(personNTT080);
        }

        // POST: PersonNTT080/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personNTT080 = await _context.PersonNTT080.FindAsync(id);
            _context.PersonNTT080.Remove(personNTT080);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonNTT080Exists(string id)
        {
            return _context.PersonNTT080.Any(e => e.PersonId == id);
        }
    }
}
