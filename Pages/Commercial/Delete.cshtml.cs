using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GsbApp.Data;
using GsbApp.Models;

namespace GsbApp.Pages.Commercial
{
    public class DeleteModel : PageModel
    {
        private readonly GsbApp.Data.GsbContext _context;

        public DeleteModel(GsbApp.Data.GsbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Commercial = await _context.Commercials.FindAsync(id);

            if (Commercial != null)
            {
                _context.Commercials.Remove(Commercial);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
