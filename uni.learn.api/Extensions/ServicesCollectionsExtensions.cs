using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using uni.learn.business.logic.Context;
using uni.learn.core.Entities;

namespace uni.learn.api.Extensions;

public static class ServicesCollectionsExtensions 
{

    public static void AddInfraestructure(this IServiceCollection services, IConfiguration configuration){
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<MainDbContext>(opts => {
            opts.UseSqlServer(connectionString);
        });
        services.AddDbContext<SecurityDbContext>(opts => {
            opts.UseSqlServer(connectionString);
        });
    }

    public static void AddIdentityUser(this IServiceCollection services){
        var builder = services.AddIdentityCore<User>();
        builder = new  IdentityBuilder(builder.UserType, builder.Services);
        builder.AddRoles<IdentityRole>();
        builder.AddEntityFrameworkStores<SecurityDbContext>();
        builder.AddSignInManager<SignInManager<User>>();
    }

    public static void AddSecurity(this IServiceCollection services){
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opts=>{
            opts.UseSecurityTokenValidators = true;
            opts.TokenValidationParameters = new TokenValidationParameters{
                ValidateIssuerSigningKey = true,
                ValidateIssuer = true,
                ValidateAudience = false
            };
        });
        services.AddAuthorization();
    }

   public static void AddRepositories(this IServiceCollection services){
    }

    public static void AddServices(this IServiceCollection services){
    }

}
