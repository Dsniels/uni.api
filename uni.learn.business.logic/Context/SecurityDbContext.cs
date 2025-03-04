using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using uni.learn.core.Entities;

namespace uni.learn.business.logic.Context;

public class SecurityDbContext : IdentityDbContext<User>
{
    public SecurityDbContext(DbContextOptions<SecurityDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<User>().HasIndex(u => new { u.Email, u.Matricula }).IsUnique();
    }
}
