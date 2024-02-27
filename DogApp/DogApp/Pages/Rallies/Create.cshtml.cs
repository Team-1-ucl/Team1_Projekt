using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DogApp.Data;
using DogApp.ModelLayer.Model;

namespace DogApp.Pages.Rallies
{
    public class CreateModel : PageModel
    {
        private readonly DogApp.Data.DogAppContext _context;

        public CreateModel(DogApp.Data.DogAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Rally Rally { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rallies.Add(Rally);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
