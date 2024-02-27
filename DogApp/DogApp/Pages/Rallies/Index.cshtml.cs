using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DogApp.Data;
using DogApp.ModelLayer.Model;

namespace DogApp.Pages.Rallies
{
    public class IndexModel : PageModel
    {
        private readonly DogAppContext _context;

        public IndexModel(DogAppContext context)
        {
            _context = context;
        }

        public IList<Rally> Rally { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Rally = await _context.Rallies.ToListAsync();
        }
    }
}
