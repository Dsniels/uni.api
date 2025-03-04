using System;
using uni.learn.core.Entities;
using uni.learn.core.Interfaces;

namespace uni.learn.business.logic.Repositories;

public class CursoRepository : ICursoRepository
{
    public Task<IReadOnlyCollection<Curso>> GetApprovedCursosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Curso> GetByIDAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<Curso>> GetUnApprovedCursosAsync()
    {
        throw new NotImplementedException();
    }
}
