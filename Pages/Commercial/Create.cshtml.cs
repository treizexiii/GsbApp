using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GsbApp.Models;

namespace GsbApp.Pages.Commercial
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
        public GsbApp.Models.Commercial Commercial { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Commercials.Add(Commercial);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
