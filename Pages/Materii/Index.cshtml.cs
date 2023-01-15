using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CatalogOnline.Data;
using CatalogOnline.Models;

namespace CatalogOnline.Pages.Materii
{
    public class IndexModel : PageModel
    {
        private readonly CatalogOnline.Data.CatalogOnlineContext _context;

        public IndexModel(CatalogOnline.Data.CatalogOnlineContext context)
        {
            _context = context;
        }

        public IList<Materie> Materie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Materie != null)
            {
                Materie = await _context.Materie.ToListAsync();
            }
        }
    }
}
