﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CatalogOnline.Data;
using CatalogOnline.Models;

namespace CatalogOnline.Pages.Profesori
{
    public class DeleteModel : PageModel
    {
        private readonly CatalogOnline.Data.CatalogOnlineContext _context;

        public DeleteModel(CatalogOnline.Data.CatalogOnlineContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Profesor Profesor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Profesor == null)
            {
                return NotFound();
            }

            var profesor = await _context.Profesor.FirstOrDefaultAsync(m => m.ID == id);

            if (profesor == null)
            {
                return NotFound();
            }
            else 
            {
                Profesor = profesor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Profesor == null)
            {
                return NotFound();
            }
            var profesor = await _context.Profesor.FindAsync(id);

            if (profesor != null)
            {
                Profesor = profesor;
                _context.Profesor.Remove(Profesor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
