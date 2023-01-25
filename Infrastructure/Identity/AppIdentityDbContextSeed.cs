using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Brandon",
                    Email = "brandon@test.com",
                    UserName = "brandon@test.com",
                    Address = new Address
                    {
                        FirstName = "Brandon",
                        LastName = "Avellanet",
                        Street = "1 Street",
                        Town = "Heywood",
                        PostCode = "OL10"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}