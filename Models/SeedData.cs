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
                Console.WriteLine("we hit line 23");
                // Look for any businesses.
                if (context.Business.Any())
                
                {
                    Console.WriteLine("we are returning");
                    return;   // DB has been seeded
                }

                var coffeeShopType = new BusinessType();
                coffeeShopType.Name = "Coffee Shop";
                
                var creativeServicesType = new BusinessType();
                creativeServicesType.Name = "Creative Services";

                var healthFitnessType = new BusinessType();
                healthFitnessType.Name = "Health & Fitness";

                var personalCareType = new BusinessType();
                personalCareType.Name = "Personal Care";

                var restaurantType = new BusinessType();
                restaurantType.Name = "Restaurant";

                var retailType = new BusinessType();
                retailType.Name = "Retail";

                var otherType = new BusinessType();
                otherType.Name = "Other";

                context.BusinessType.AddRange(
                    
                    coffeeShopType,
                    creativeServicesType,
                    healthFitnessType,
                    personalCareType,
                    restaurantType,
                    retailType,
                    otherType
                    
                );

                context.Business.AddRange(
                    new Business
                    {
                        Name = "Koffie",
                        Type = coffeeShopType,
                        Website = "www.thekoffie.co",
                        Contact = "IG: @thekoffie.co"
                    },

                    new Business
                    {
                        Name = "Crow Salon",
                        Type = personalCareType,
                        Website = "www.crowsalon.com",
                        Contact = "crowsalon@gmail.com"
                    },

                    new Business
                    {
                        Name = "Alce 101",
                        Type = restaurantType,
                        Website = "www.alce101.com",
                        Contact = "IG: @alce101"
                    },

                    new Business
                    {
                        Name = "Sunless Revolution",
                        Type = personalCareType,
                        Website = "www.sunless-revolution.com",
                        Contact = "appointments@sunless-revolution.com"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}