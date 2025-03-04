using System;
using uni.learn.core.Entities;
using uni.learn.core.Interfaces;

namespace uni.learn.business.logic.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : Base
{
    public Task<int> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
