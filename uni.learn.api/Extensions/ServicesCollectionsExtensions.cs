using System;

namespace uni.learn.api.Extensions;

public static class ServicesCollectionsExtensions 
{

    public static void AddInfraestructure(this IServiceCollection services, IConfiguration configuration){
        var connectionString = configuration.GetConnectionString("DefaultConnection");
    }


   public static void AddRepositories(this IServiceCollection services){
    }

    public static void AddServices(this IServiceCollection services){
    }

}
