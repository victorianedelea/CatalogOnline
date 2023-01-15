﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CatalogOnline.Data;
using CatalogOnline.Models;

namespace CatalogOnline.Pages.Note
{
    public class DeleteModel : PageModel
    {
        private readonly CatalogOnline.Data.CatalogOnlineContext _context;

        public DeleteModel(CatalogOnline.Data.CatalogOnlineContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Nota Nota { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Nota == null)
            {
                return NotFound();
            }

            var nota = await _context.Nota.FirstOrDefaultAsync(m => m.ID == id);

            if (nota == null)
            {
                return NotFound();
            }
            else 
            {
                Nota = nota;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Nota == null)
            {
                return NotFound();
            }
            var nota = await _context.Nota.FindAsync(id);

            if (nota != null)
            {
                Nota = nota;
                _context.Nota.Remove(Nota);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
