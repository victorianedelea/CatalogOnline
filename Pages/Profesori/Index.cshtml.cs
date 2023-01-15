using System;
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
    public class IndexModel : PageModel
    {
        private readonly CatalogOnline.Data.CatalogOnlineContext _context;

        public IndexModel(CatalogOnline.Data.CatalogOnlineContext context)
        {
            _context = context;
        }

        public IList<Profesor> Profesor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Profesor != null)
            {
                Profesor = await _context.Profesor.ToListAsync();
            }
        }
    }
}
