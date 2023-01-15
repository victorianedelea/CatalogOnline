﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly CatalogOnline.Data.CatalogOnlineContext _context;

        public DeleteModel(CatalogOnline.Data.CatalogOnlineContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.ListaProfesoriMaterie == null)
            {
                return NotFound();
            }
            var listaprofesorimaterie = await _context.ListaProfesoriMaterie.FindAsync(id);

            if (listaprofesorimaterie != null)
            {
                ListaProfesoriMaterie = listaprofesorimaterie;
                _context.ListaProfesoriMaterie.Remove(ListaProfesoriMaterie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
