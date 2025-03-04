using System;
using Microsoft.AspNetCore.Identity;
using uni.learn.core.Entities;

namespace uni.learn.business.logic.Context.DataSeed;

public class SecurityDbContextData
{
       public static async Task SeedUserAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
    {
        if (!roleManager.Roles.Any())
        {
            var role = new IdentityRole
            {
                Name = "ADMIN"
            };

            var roleAlumno = new IdentityRole
            {
                Name = "ALUMNO"
            };
            await roleManager.CreateAsync(role);
            await roleManager.CreateAsync(roleAlumno);

        }

        
        if (!userManager.Users.Any())
        {
            var usuario = new User
            {
                Nombre = "Admin",
                Apellido = "Sistema",
                UserName = "admin@unilearn.com",
                Email = "admin@unilearn.com",
                EmailConfirmed = true,
                PhoneNumber = "1234567890",
                Matricula = 22222,
                Admin = true
            };

            var resultado = await userManager.CreateAsync(usuario, "Admin123*");

            if (resultado.Succeeded)
            {
                await userManager.AddToRoleAsync(usuario, "ADMIN");
            }
        }



    }

}
