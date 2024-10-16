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

                var roles = new[] { "Librarian", "Student" }; 

                foreach (var role in roles)
                {
                    if (!await roleManager.RoleExistsAsync(role))
                    {
                        await roleManager.CreateAsync(new IdentityRole(role));
                    }
                }
            }
        }
    }

}