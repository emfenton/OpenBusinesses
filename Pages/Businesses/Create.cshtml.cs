using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesBusiness.Data;
using RazorPagesBusiness.Models;

namespace RazorPagesBusiness.Pages.Businesses
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesBusiness.Data.BusinessContext _context;

        public CreateModel(RazorPagesBusiness.Data.BusinessContext context)
        {
            _context = context;
        }
        public IList<BusinessType> BusinessType { get;set; }
        public async Task OnGetAsync()
        {
            BusinessType =  await _context.BusinessType
            .ToListAsync();
            
        }

        [BindProperty]
        public UserBusinessInput UserBusinessInput { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            BusinessType =  await _context.BusinessType
            .ToListAsync();

            if (!ModelState.IsValid)
            {
                return Page();
            }
            var business = new Business
            {
                Name = UserBusinessInput.Name,
                Type = BusinessType.,
                Website = UserBusinessInput.Website,
                Contact = UserBusinessInput.Contact
            };
            // _context.Business.Add(Business);
            // await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
