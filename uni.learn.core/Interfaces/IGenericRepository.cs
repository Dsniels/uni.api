using System;
using uni.learn.core.Entities;

namespace uni.learn.core.Interfaces;

public interface IGenericRepository<T> where T : Base
{
    Task<IReadOnlyCollection<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<int> AddAsync(T entity);
    Task<int> UpdateAsync(T entity);
    Task<int> DeleteAsync(T entity);
}
