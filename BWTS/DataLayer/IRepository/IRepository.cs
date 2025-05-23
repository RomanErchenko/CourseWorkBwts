﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IRepository<T> :IDisposable where T : class
    {
        IEnumerable<T> GetAllAsync();
        Task<T>? GetByIdAsync(Guid id);
        Task<bool> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> SaveChangesAsync();
        Task<bool> GetInfo(string p);


    }
}
