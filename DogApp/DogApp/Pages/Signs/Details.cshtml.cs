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
    public class DetailsModel : PageModel
    {
        private readonly DogApp.Data.DogAppContext _context;

        public DetailsModel(DogApp.Data.DogAppContext context)
        {
            _context = context;
        }

        public Sign Sign { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sign = await _context.Signs.FirstOrDefaultAsync(m => m.Id == id);
            if (sign == null)
            {
                return NotFound();
            }
            else
            {
                Sign = sign;
            }
            return Page();
        }
    }
}
