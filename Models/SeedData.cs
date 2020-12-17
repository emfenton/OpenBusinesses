using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesBusiness.Data;
using System;
using System.Linq;

namespace RazorPagesBusiness.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BusinessContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BusinessContext>>()))
            {
                // Look for any businesses.
                if (context.Business.Any())
                {
                    return;   // DB has been seeded
                }

                context.Business.AddRange(
                    new Business
                    {
                        Name = "Koffie",
                        Type = "Coffee shop",
                        Website = "www.thekoffie.co"
                    },

                    new Business
                    {
                        Name = "Crow Salon",
                        Type = "Hair salon",
                        Website = "www.crowsalon.com"
                    },

                    new Business
                    {
                        Name = "Alce 101",
                        Type = "Restaurant",
                        Website = "www.alce101.com"
                    },

                    new Business
                    {
                        Name = "Sunless Revolution",
                        Type = "Tanning salon",
                        Website = "www.sunless-revolution.com"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}