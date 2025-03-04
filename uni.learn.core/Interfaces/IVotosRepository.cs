using System;
using uni.learn.core.Entities;

namespace uni.learn.core.Interfaces;

public interface IVotosRepository
{
        Task<bool> AddOrUpdateVotoAsync(int cursoId, string userId, bool Like);
        Task<bool> RemoveVotoAsync(int cursoId, string userId);
        Task<int> GetLikesCountAsync(int cursoId);
        Task<int> GetDislikesCountAsync(int cursoId);
        Task<IEnumerable<Votos>> GetUserVotosAsync(string userId);
        Task<bool> UserVotedCursoAsync(int cursoId, string userId);
}
