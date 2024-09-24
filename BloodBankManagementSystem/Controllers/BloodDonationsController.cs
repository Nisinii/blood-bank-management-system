using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BloodBankManagementSystem.Controllers
{
    public class BloodDonationsController : Controller
    {
        private readonly BloodBankContext _context;

        public BloodDonationsController(BloodBankContext context)
        {
            _context = context;
        }

        // GET: BloodDonations
        public async Task<IActionResult> Index()
        {
            return View(await _context.BloodDonations.ToListAsync());
        }

        // GET: BloodDonations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloodDonation = await _context.BloodDonations
                .FirstOrDefaultAsync(m => m.DonationId == id);
            if (bloodDonation == null)
            {
                return NotFound();
            }

            return View(bloodDonation);
        }

        // GET: BloodDonations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BloodDonations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DonationId,BloodGroup,DateOfDonation,StorageLocation")] BloodDonation bloodDonation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bloodDonation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bloodDonation);
        }

        // GET: BloodDonations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloodDonation = await _context.BloodDonations.FindAsync(id);
            if (bloodDonation == null)
            {
                return NotFound();
            }
            return View(bloodDonation);
        }

        // POST: BloodDonations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DonationId,BloodGroup,DateOfDonation,StorageLocation")] BloodDonation bloodDonation)
        {
            if (id != bloodDonation.DonationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bloodDonation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BloodDonationExists(bloodDonation.DonationId))
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
            return View(bloodDonation);
        }

        // GET: BloodDonations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloodDonation = await _context.BloodDonations
                .FirstOrDefaultAsync(m => m.DonationId == id);
            if (bloodDonation == null)
            {
                return NotFound();
            }

            return View(bloodDonation);
        }

        // POST: BloodDonations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bloodDonation = await _context.BloodDonations.FindAsync(id);
            if (bloodDonation != null)
            {
                _context.BloodDonations.Remove(bloodDonation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BloodDonationExists(int id)
        {
            return _context.BloodDonations.Any(e => e.DonationId == id);
        }
    }
}
