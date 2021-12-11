using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesForm.Models;

namespace FCAform.Pages.Forms
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesFormContext _context;

        public DetailsModel(RazorPagesFormContext context)
        {
            _context = context;
        }

        public Form Form { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Form = await _context.Form.FirstOrDefaultAsync(m => m.ID == id);

            if (Form == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
