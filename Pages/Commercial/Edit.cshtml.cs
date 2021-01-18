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

namespace GsbApp.Pages.Commercial
{
    public class EditModel : PageModel
    {
        private readonly GsbApp.Data.GsbContext _context;

        public EditModel(GsbApp.Data.GsbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GsbApp.Models.Commercial Commercial { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Commercial = await _context.Commercials.FirstOrDefaultAsync(m => m.ID == id);

            if (Commercial == null)
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

            _context.Attach(Commercial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommercialExists(Commercial.ID))
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

        private bool CommercialExists(int id)
        {
            return _context.Commercials.Any(e => e.ID == id);
        }
    }
}
