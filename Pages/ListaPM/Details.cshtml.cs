using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CatalogOnline.Data;
using CatalogOnline.Models;

namespace CatalogOnline.Pages.ListaPM
{
    public class DetailsModel : PageModel
    {
        private readonly CatalogOnline.Data.CatalogOnlineContext _context;

        public DetailsModel(CatalogOnline.Data.CatalogOnlineContext context)
        {
            _context = context;
        }

      public ListaProfesoriMaterie ListaProfesoriMaterie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ListaProfesoriMaterie == null)
            {
                return NotFound();
            }

            var listaprofesorimaterie = await _context.ListaProfesoriMaterie.FirstOrDefaultAsync(m => m.ID == id);
            if (listaprofesorimaterie == null)
            {
                return NotFound();
            }
            else 
            {
                ListaProfesoriMaterie = listaprofesorimaterie;
            }
            return Page();
        }
    }
}
