using System;
using Microsoft.EntityFrameworkCore;
using uni.learn.business.logic.Context;
using uni.learn.core.Entities;
using uni.learn.core.Interfaces;

namespace uni.learn.business.logic.Repositories;

public class VotosRepository : IVotosRepository
{
    private readonly MainDbContext _context;
    public VotosRepository(MainDbContext context)
    {
        _context = context;
    }

    public Task<int> GetDislikesCountAsync(int cursoId)
    {
        return _context.Votos.Where(x => !x.Like).CountAsync();
    }

    public Task<int> GetLikesCountAsync(int cursoId)
    {
        return _context.Votos.Where(x => x.Like).CountAsync();
    }

     public Task<bool> UserVotedCursoAsync(int cursoId, string userId)
    {
        return _context.Votos.AnyAsync(c => c.CursoId == cursoId && c.UserId == userId);
    }
}
