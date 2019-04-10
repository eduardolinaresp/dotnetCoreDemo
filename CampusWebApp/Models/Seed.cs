using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusWebApp.Models
{
    public class Seed
    {

        public  static async Task Initialize (  ApplicationDbContext context,
                                                UserManager<ApplicationUser> UserManager,
                                                RoleManager<ApplicationRole> roleManager  )
        {

            context.Database.EnsureCreated();

            string AdminRole = "Admin";
            string DescAdminRole = "This Role it's for Administration";

            string MemberRole = "Member";
            string DescMemberRole = "This Role it's for Guest";

            string password = "P@ssword";

            if (await roleManager.FindByNameAsync(AdminRole) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(AdminRole, DescAdminRole,DateTime.Now));
            }

            if (await roleManager.FindByNameAsync(MemberRole) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(MemberRole, DescMemberRole, DateTime.Now));
            }

            if (await roleManager.FindByNameAsync("admin@mail.net") == null)
            {

                var user = new ApplicationUser
                {
                    UserName = "admin",
                    Email = "admin@mail.net",
                    FirstName = "admin",
                    LastName = "admin"


                };

                var rersult = await UserManager.CreateAsync(user);

                if (rersult.Succeeded)
                {
                    await UserManager.AddPasswordAsync(user, password);
                    await UserManager.AddToRoleAsync(user, AdminRole);
                }

            }



        }
    }
}
