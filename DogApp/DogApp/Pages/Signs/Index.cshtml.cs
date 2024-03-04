using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DogApp.Data;
using DogApp.ModelLayer.Model;

namespace DogApp.Pages.Signs
{
    public class IndexModel : PageModel
    {
        private readonly DogApp.Data.DogAppContext _context;

        public IndexModel(DogApp.Data.DogAppContext context)
        {
            _context = context;
        }

        public IList<Sign> Sign { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Sign = await _context.Signs.ToListAsync();
        }
    }
}
