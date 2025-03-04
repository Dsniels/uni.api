using System;
using Microsoft.EntityFrameworkCore;
using uni.learn.core.Entities;

namespace uni.learn.business.logic.Context.DataSeed;

public class MainDbContextData
{
    public static async Task seedDataAsync(MainDbContext context){
         if (!await context.Categorias.AnyAsync())
        {
            var categorias = new List<Categoria>
            {
                new Categoria { Nombre = "Ingeniería"},
                new Categoria { Nombre = "Ciencias", },
                new Categoria { Nombre = "Matemáticas"},
                new Categoria { Nombre = "Programación"},
                new Categoria { Nombre = "Sistemas"},
                new Categoria { Nombre = "Base de Datos"},
                new Categoria { Nombre = "Inteligencia Artificial"},
                new Categoria { Nombre = "Administración"},
                new Categoria { Nombre = "Idiomas"},
                new Categoria { Nombre = "Humanidades"}
            };
            
            await context.Categorias.AddRangeAsync(categorias);
            await context.SaveChangesAsync();
        }
    }
}
