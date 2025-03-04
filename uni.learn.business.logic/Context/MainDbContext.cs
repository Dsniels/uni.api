using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using uni.learn.core.Entities;

namespace uni.learn.business.logic.Context;

public class MainDbContext : DbContext
{
    public MainDbContext(DbContextOptions<MainDbContext> options): base(options){}

    public DbSet<Curso> Curso{get; set;}
    public DbSet<Categoria> Categorias {get; set;}
    public DbSet<Votos> Votos {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Categoria>().HasIndex(c=> new{c.Nombre}).IsUnique();
    }

}
