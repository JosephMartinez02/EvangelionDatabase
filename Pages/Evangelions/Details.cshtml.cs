using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EvangelionDatabase.Models;

namespace EvangelionDatabase.Pages.Evangelions
{
    public class DetailsModel : PageModel
    {
        private readonly EvangelionDatabase.Models.EVAContext _context;

        public DetailsModel(EvangelionDatabase.Models.EVAContext context)
        {
            _context = context;
        }

      public Evangelion Evangelion { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Evangelion == null)
            {
                return NotFound();
            }

            var evangelion = await _context.Evangelion.FirstOrDefaultAsync(m => m.EvangelionID == id);
            if (evangelion == null)
            {
                return NotFound();
            }
            else 
            {
                Evangelion = evangelion;
            }
            return Page();
        }
    }
}
