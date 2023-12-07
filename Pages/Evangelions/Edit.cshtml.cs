using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EvangelionDatabase.Models;

namespace EvangelionDatabase.Pages.Evangelions
{
    public class EditModel : PageModel
    {
        private readonly EvangelionDatabase.Models.EVAContext _context;

        public EditModel(EvangelionDatabase.Models.EVAContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Evangelion Evangelion { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Evangelion == null)
            {
                return NotFound();
            }

            var evangelion =  await _context.Evangelion.FirstOrDefaultAsync(m => m.EvangelionID == id);
            if (evangelion == null)
            {
                return NotFound();
            }
            Evangelion = evangelion;
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

            _context.Attach(Evangelion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EvangelionExists(Evangelion.EvangelionID))
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

        private bool EvangelionExists(int id)
        {
          return (_context.Evangelion?.Any(e => e.EvangelionID == id)).GetValueOrDefault();
        }
    }
}
