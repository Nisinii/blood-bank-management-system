using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BloodBankManagementSystem.Controllers
{
    public class BloodRequirementsController : Controller
    {
        private readonly BloodBankContext _context;

        public BloodRequirementsController(BloodBankContext context)
        {
            _context = context;
        }

        // GET: BloodRequirements
        public async Task<IActionResult> Index()
        {
            return View(await _context.BloodRequirements.ToListAsync());
        }

        // GET: BloodRequirements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloodRequirement = await _context.BloodRequirements
                .FirstOrDefaultAsync(m => m.RequirementId == id);
            if (bloodRequirement == null)
            {
                return NotFound();
            }

            return View(bloodRequirement);
        }

        // GET: BloodRequirements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BloodRequirements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequirementId,RequiredBloodGroup,PatientName,Contact,RequiredDate")] BloodRequirement bloodRequirement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bloodRequirement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bloodRequirement);
        }

        // GET: BloodRequirements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloodRequirement = await _context.BloodRequirements.FindAsync(id);
            if (bloodRequirement == null)
            {
                return NotFound();
            }
            return View(bloodRequirement);
        }

        // POST: BloodRequirements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RequirementId,RequiredBloodGroup,PatientName,Contact,RequiredDate")] BloodRequirement bloodRequirement)
        {
            if (id != bloodRequirement.RequirementId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bloodRequirement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BloodRequirementExists(bloodRequirement.RequirementId))
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
            return View(bloodRequirement);
        }

        // GET: BloodRequirements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloodRequirement = await _context.BloodRequirements
                .FirstOrDefaultAsync(m => m.RequirementId == id);
            if (bloodRequirement == null)
            {
                return NotFound();
            }

            return View(bloodRequirement);
        }

        // POST: BloodRequirements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bloodRequirement = await _context.BloodRequirements.FindAsync(id);
            if (bloodRequirement != null)
            {
                _context.BloodRequirements.Remove(bloodRequirement);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BloodRequirementExists(int id)
        {
            return _context.BloodRequirements.Any(e => e.RequirementId == id);
        }
    }
}
