﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly GsbApp.Data.GsbContext _context;

        public DetailsModel(GsbApp.Data.GsbContext context)
        {
            _context = context;
        }

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
    }
}