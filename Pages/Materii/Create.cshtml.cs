using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CatalogOnline.Data;
using CatalogOnline.Models;

namespace CatalogOnline.Pages.Materii
{
    public class CreateModel : PageModel
    {
        private readonly CatalogOnline.Data.CatalogOnlineContext _context;

        public CreateModel(CatalogOnline.Data.CatalogOnlineContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Materie Materie { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Materie.Add(Materie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
