using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CatalogOnline.Data;
using CatalogOnline.Models;

namespace CatalogOnline.Pages.ListaPM
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
        ViewData["MaterieID"] = new SelectList(_context.Set<Materie>(), "ID", "ID");
        ViewData["ProfesorID"] = new SelectList(_context.Set<Profesor>(), "ID", "ID");
            return Page();
        }

        [BindProperty]
        public ListaProfesoriMaterie ListaProfesoriMaterie { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ListaProfesoriMaterie.Add(ListaProfesoriMaterie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
