using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesBusiness.Data;
using RazorPagesBusiness.Models;

namespace RazorPagesBusiness.Pages.Businesses
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesBusiness.Data.BusinessContext _context;

        public DetailsModel(RazorPagesBusiness.Data.BusinessContext context)
        {
            _context = context;
        }

        public Business Business { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Business = await _context.Business.FirstOrDefaultAsync(m => m.ID == id);

            if (Business == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
