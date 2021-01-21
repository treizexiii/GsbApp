using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GsbApp.Data;
using GsbApp.Models;

namespace GsbApp.Pages.ExpenseReports
{
    public class DeleteModel : PageModel
    {
        private readonly GsbApp.Data.GsbContext _context;

        public DeleteModel(GsbApp.Data.GsbContext context)
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

            ExpenceReport = await _context.ExpenceReport.FirstOrDefaultAsync(m => m.IdExpenceReport == id);

            if (ExpenceReport == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ExpenceReport = await _context.ExpenceReport.FindAsync(id);

            if (ExpenceReport != null)
            {
                _context.ExpenceReport.Remove(ExpenceReport);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
