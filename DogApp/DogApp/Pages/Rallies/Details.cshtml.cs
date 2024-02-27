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
    public class DetailsModel : PageModel
    {
        private readonly DogApp.Data.DogAppContext _context;

        public DetailsModel(DogApp.Data.DogAppContext context)
        {
            _context = context;
        }

        public Rally Rally { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rally = await _context.Rallies.FirstOrDefaultAsync(m => m.Id == id);
            if (rally == null)
            {
                return NotFound();
            }
            else
            {
                Rally = rally;
            }
            return Page();
        }
    }
}
