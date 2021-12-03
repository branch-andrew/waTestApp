using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using waTestApp.Data;
using waTestApp.Models;

namespace waTestApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly waTestApp.Data.waTestAppContext _context;

        public IndexModel(waTestApp.Data.waTestAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
