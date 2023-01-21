﻿namespace HotelListingApi.RepositoryContracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<bool> Exists(int id);
    }
}