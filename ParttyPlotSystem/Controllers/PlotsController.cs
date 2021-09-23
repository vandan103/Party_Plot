using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ParttyPlotSystem.Data;
using ParttyPlotSystem.Models;

namespace ParttyPlotSystem.Controllers
{
    public class PlotsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlotsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Plots
        public async Task<IActionResult> Index()
        {
            return View(await _context.Plots.ToListAsync());
        }
        public async Task<IActionResult> Userview()
        {
            return View(await _context.Plots.ToListAsync());
        }

        // GET: Plots/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plot = await _context.Plots
                .FirstOrDefaultAsync(m => m.PId == id);
            if (plot == null)
            {
                return NotFound();
            }

            return View(plot);
        }

        // GET: Plots/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Plots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PId,Name,Address,Status,PaymentPrice,Image")] Plot plot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plot);
        }

        // GET: Plots/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plot = await _context.Plots.FindAsync(id);
            if (plot == null)
            {
                return NotFound();
            }
            return View(plot);
        }

        // POST: Plots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PId,Name,Address,Status,PaymentPrice,Image")] Plot plot)
        {
            if (id != plot.PId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlotExists(plot.PId))
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
            return View(plot);
        }

        // GET: Plots/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plot = await _context.Plots
                .FirstOrDefaultAsync(m => m.PId == id);
            if (plot == null)
            {
                return NotFound();
            }

            return View(plot);
        }

        // POST: Plots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plot = await _context.Plots.FindAsync(id);
            _context.Plots.Remove(plot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlotExists(int id)
        {
            return _context.Plots.Any(e => e.PId == id);
        }
    }
}
