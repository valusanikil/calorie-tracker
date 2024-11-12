using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Calorie.Data;
using Calorie.Models;
using System.Linq;

namespace Calorie.Controllers
{
    public class CalorieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalorieController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Calorie/CalorieTracker
        public async Task<IActionResult> CalorieTracker()
        {
            return View(await _context.CalorieEntries.ToListAsync());
        }

        // GET: Calorie/Chart
        public async Task<IActionResult> Chart()
        {
            return View(await _context.CalorieEntries.ToListAsync());
        }

        public async Task<IActionResult> Recipe()
        {
            return View(await _context.CalorieEntries.ToListAsync());
        }

        // POST: Calorie/Create
        [HttpPost]
        public async Task<IActionResult> Create(CalorieEntry entry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(entry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(CalorieTracker));
            }
            return View("CalorieTracker", await _context.CalorieEntries.ToListAsync());
        }

        // GET: Calorie/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var entry = await _context.CalorieEntries.FindAsync(id);
            if (entry == null) return NotFound();

            return View(entry);
        }

        // POST: Calorie/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(int id, CalorieEntry entry)
        {
            if (id != entry.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(entry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(CalorieTracker));
            }
            return View(entry);
        }

        // GET: Calorie/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entry = await _context.CalorieEntries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entry == null)
            {
                return NotFound();
            }

            return View(entry);
        }

        // POST: Calorie/DeleteConfirmed/5
        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entry = await _context.CalorieEntries.FindAsync(id);
            _context.CalorieEntries.Remove(entry);
            await _context.SaveChangesAsync();
            return RedirectToAction("CalorieTracker");
        }
    }
}
