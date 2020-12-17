using Microsoft.EntityFrameworkCore;

namespace RazorPagesBusiness.Data
{
    public class BusinessContext : DbContext
    {
        public BusinessContext (
            DbContextOptions<BusinessContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesBusiness.Models.Business> Business { get; set; }
    }
}