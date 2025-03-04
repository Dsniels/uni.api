using System;
using Microsoft.EntityFrameworkCore;
using uni.learn.business.logic.Context;
using uni.learn.core.Entities;
using uni.learn.core.Interfaces;

namespace uni.learn.business.logic.Repositories;

public class CursoRepository : ICursoRepository
{
    private readonly MainDbContext _context;
    public CursoRepository(MainDbContext context)
    {
        _context = context;
    }
    public async Task<IReadOnlyCollection<Curso>> GetApprovedCursosAsync()
    {
        return await _context.Curso.Where(c => c.Aprobado).Include(c => c.Categorias).ToListAsync();
    }

    public async Task<Curso> GetByIDAsync(int id)
    {
        return await _context.Curso.Include(c => c.Categorias).FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<IReadOnlyCollection<Curso>> GetUnApprovedCursosAsync()
    {
        return await _context.Curso.Where(c => c.Aprobado).Include(c => c.Categorias).ToListAsync();
    }
}
