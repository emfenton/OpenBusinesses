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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesBusiness.Data.BusinessContext _context;

        public IndexModel(RazorPagesBusiness.Data.BusinessContext context)
        {
            _context = context;
        }

        public IList<Business> Business { get;set; }

        public async Task OnGetAsync()
        {
            Business = await _context.Business.ToListAsync();
        }
    }
}
