using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesForm.Models;

namespace FCAform.Pages.Forms
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesFormContext _context;

        public CreateModel(RazorPagesFormContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Form Form { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Form.Add(Form);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
