using LibraryApp.Models;
using Microsoft.AspNetCore.Identity;

namespace LibraryApp.API.Extensions
{
    public static class IdentityRoleSeeder
    {
        public static async Task SeedRoles(this IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                string[] roleNames = { "Student", "Librarian" };

                foreach (var roleName in roleNames)
                {
                    if (!await roleManager.RoleExistsAsync(roleName))
                    {
                        await roleManager.CreateAsync(new IdentityRole(roleName));
                    }
                }
            }
        }
    }
}
