using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GsbApp.Data;
using GsbApp.Models;

namespace GsbApp.Pages.Commercials
{
    public class IndexModel : PageModel
    {
        private readonly GsbApp.Data.GsbContext _context;

        public IndexModel(GsbApp.Data.GsbContext context)
        {
            _context = context;
        }

        public IList<Commercial> Commercial { get;set; }

        public async Task OnGetAsync()
        {
            Commercial = await _context.Commercials.ToListAsync();
        }
    }
}
