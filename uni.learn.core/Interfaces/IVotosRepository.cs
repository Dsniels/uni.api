using System;
using uni.learn.core.Entities;

namespace uni.learn.core.Interfaces;

public interface IVotosRepository
{
        Task<int> GetLikesCountAsync(int cursoId);
        Task<int> GetDislikesCountAsync(int cursoId);
        Task<bool> UserVotedCursoAsync(int cursoId, string userId);
}
