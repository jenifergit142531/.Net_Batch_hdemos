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
    public class ProductPricingsController : Controller
    {
        private readonly DbfirstContext _context;

        public ProductPricingsController(DbfirstContext context)
        {
            _context = context;
        }

        // GET: ProductPricings
        public async Task<IActionResult> Index()
        {
            var dbfirstContext = _context.ProductPricings.Include(p => p.PidNavigation);
            return View(await dbfirstContext.ToListAsync());
        }

        // GET: ProductPricings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProductPricings == null)
            {
                return NotFound();
            }

            var productPricing = await _context.ProductPricings
                .Include(p => p.PidNavigation)
                .FirstOrDefaultAsync(m => m.Billingno == id);
            if (productPricing == null)
            {
                return NotFound();
            }

            return View(productPricing);
        }

        // GET: ProductPricings/Create
        public IActionResult Create()
        {
            ViewData["Pid"] = new SelectList(_context.Elecproducts, "Pid", "Pid");
            return View();
        }

        // POST: ProductPricings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Billingno,Pname,Price,Quantity,Pid")] ProductPricing productPricing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productPricing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Pid"] = new SelectList(_context.Elecproducts, "Pid", "Pid", productPricing.Pid);
            return View(productPricing);
        }

        // GET: ProductPricings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProductPricings == null)
            {
                return NotFound();
            }

            var productPricing = await _context.ProductPricings.FindAsync(id);
            if (productPricing == null)
            {
                return NotFound();
            }
            ViewData["Pid"] = new SelectList(_context.Elecproducts, "Pid", "Pid", productPricing.Pid);
            return View(productPricing);
        }

        // POST: ProductPricings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Billingno,Pname,Price,Quantity,Pid")] ProductPricing productPricing)
        {
            if (id != productPricing.Billingno)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productPricing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductPricingExists(productPricing.Billingno))
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
            ViewData["Pid"] = new SelectList(_context.Elecproducts, "Pid", "Pid", productPricing.Pid);
            return View(productPricing);
        }

        // GET: ProductPricings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProductPricings == null)
            {
                return NotFound();
            }

            var productPricing = await _context.ProductPricings
                .Include(p => p.PidNavigation)
                .FirstOrDefaultAsync(m => m.Billingno == id);
            if (productPricing == null)
            {
                return NotFound();
            }

            return View(productPricing);
        }

        // POST: ProductPricings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProductPricings == null)
            {
                return Problem("Entity set 'DbfirstContext.ProductPricings'  is null.");
            }
            var productPricing = await _context.ProductPricings.FindAsync(id);
            if (productPricing != null)
            {
                _context.ProductPricings.Remove(productPricing);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductPricingExists(int id)
        {
          return (_context.ProductPricings?.Any(e => e.Billingno == id)).GetValueOrDefault();
        }
    }
}
