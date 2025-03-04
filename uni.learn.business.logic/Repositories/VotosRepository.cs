using System;
using uni.learn.core.Entities;
using uni.learn.core.Interfaces;

namespace uni.learn.business.logic.Repositories;

public class VotosRepository : IVotosRepository
{
    public Task<bool> AddOrUpdateVotoAsync(int cursoId, string userId, bool Like)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetDislikesCountAsync(int cursoId)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetLikesCountAsync(int cursoId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Votos>> GetUserVotosAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveVotoAsync(int cursoId, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UserVotedCursoAsync(int cursoId, string userId)
    {
        throw new NotImplementedException();
    }
}
