using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GsbApp.Data;
using GsbApp.Models;

namespace GsbApp.Pages.ExpenceReports
{
    public class EditModel : PageModel
    {
        private readonly GsbApp.Data.GsbContext _context;

        public EditModel(GsbApp.Data.GsbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ExpenceReport ExpenceReport { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ExpenceReport = await _context.ExpenceReport.FirstOrDefaultAsync(m => m.ID == id);

            if (ExpenceReport == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ExpenceReport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenceReportExists(ExpenceReport.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ExpenceReportExists(int id)
        {
            return _context.ExpenceReport.Any(e => e.ID == id);
        }
    }
}
