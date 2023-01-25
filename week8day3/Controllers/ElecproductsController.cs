using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using week8day3.Models;

namespace week8day3.Controllers
{
    public class ElecproductsController : Controller
    {
        private readonly DbfirstContext _context;

        public ElecproductsController(DbfirstContext context)
        {
            _context = context;
        }

        // GET: Elecproducts
        public async Task<IActionResult> Index()
        {
              return _context.Elecproducts != null ? 
                          View(await _context.Elecproducts.ToListAsync()) :
                          Problem("Entity set 'DbfirstContext.Elecproducts'  is null.");
        }

        // GET: Elecproducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Elecproducts == null)
            {
                return NotFound();
            }

            var elecproduct = await _context.Elecproducts
                .FirstOrDefaultAsync(m => m.Pid == id);
            if (elecproduct == null)
            {
                return NotFound();
            }

            return View(elecproduct);
        }

        // GET: Elecproducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Elecproducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Pid,Pname,Brand")] Elecproduct elecproduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(elecproduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(elecproduct);
        }

        // GET: Elecproducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Elecproducts == null)
            {
                return NotFound();
            }

            var elecproduct = await _context.Elecproducts.FindAsync(id);
            if (elecproduct == null)
            {
                return NotFound();
            }
            return View(elecproduct);
        }

        // POST: Elecproducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Pid,Pname,Brand")] Elecproduct elecproduct)
        {
            if (id != elecproduct.Pid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(elecproduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ElecproductExists(elecproduct.Pid))
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
            return View(elecproduct);
        }

        // GET: Elecproducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Elecproducts == null)
            {
                return NotFound();
            }

            var elecproduct = await _context.Elecproducts
                .FirstOrDefaultAsync(m => m.Pid == id);
            if (elecproduct == null)
            {
                return NotFound();
            }

            return View(elecproduct);
        }

        // POST: Elecproducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Elecproducts == null)
            {
                return Problem("Entity set 'DbfirstContext.Elecproducts'  is null.");
            }
            var elecproduct = await _context.Elecproducts.FindAsync(id);
            if (elecproduct != null)
            {
                _context.Elecproducts.Remove(elecproduct);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ElecproductExists(int id)
        {
          return (_context.Elecproducts?.Any(e => e.Pid == id)).GetValueOrDefault();
        }
    }
}
