using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GsbApp.Data;
using GsbApp.Models;

namespace GsbApp.Pages.ExpenseReports
{
    public class CreateModel : PageModel
    {
        private readonly GsbApp.Data.GsbContext _context;

        public CreateModel(GsbApp.Data.GsbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ExpenceReport ExpenceReport { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ExpenceReport.Add(ExpenceReport);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
