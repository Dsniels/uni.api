using System;
using uni.learn.core.Entities;

namespace uni.learn.core.Interfaces;

public interface ICursoRepository
{
    Task<Curso> GetByIDAsync(int id);
    Task<IReadOnlyCollection<Curso>> GetApprovedCursosAsync();
    Task<IReadOnlyCollection<Curso>> GetUnApprovedCursosAsync();
}
