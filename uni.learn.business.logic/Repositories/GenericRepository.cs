using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using uni.learn.business.logic.Context;
using uni.learn.core.Entities;
using uni.learn.core.Interfaces;

namespace uni.learn.business.logic.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : Base
{
    private readonly MainDbContext _context;
    public GenericRepository (MainDbContext context){
        _context=context;   
    }

    public async Task<int> AddAsync(T entity)
    {
        _context.Set<T>().Add(entity);
        return await _context.SaveChangesAsync();
    }

    public async Task<int> DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        return await _context.SaveChangesAsync();
    }

    public async Task<IReadOnlyCollection<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<int> UpdateAsync(T entity)
    {
        _context.Set<T>().Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
        return await _context.SaveChangesAsync();
    }
}
