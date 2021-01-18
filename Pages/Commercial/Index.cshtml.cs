using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GsbApp.Pages.Commercial
{
    public class IndexModel : PageModel
    {
        private readonly GsbApp.Data.GsbContext _context;

        public IndexModel(GsbApp.Data.GsbContext context)
        {
            _context = context;
        }

        public IList<GsbApp.Models.Commercial> Commercial { get;set; }

        public async Task OnGetAsync()
        {
            Commercial = await _context.Commercials.ToListAsync();
        }
    }
}
