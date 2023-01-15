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
    public class IndexModel : PageModel
    {
        private readonly CatalogOnline.Data.CatalogOnlineContext _context;

        public IndexModel(CatalogOnline.Data.CatalogOnlineContext context)
        {
            _context = context;
        }

        public IList<ListaProfesoriMaterie> ListaProfesoriMaterie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ListaProfesoriMaterie != null)
            {
                ListaProfesoriMaterie = await _context.ListaProfesoriMaterie
                .Include(l => l.Materie)
                .Include(l => l.Profesor).ToListAsync();
            }
        }
    }
}
