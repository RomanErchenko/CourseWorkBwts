using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ISiemensRepository
{
    public interface ISiemensRepository<T> : IDisposable where T : class
    {

        IEnumerable<T> GetAllAsync();
        Task<T>? GetByIdAsync(Guid id);
        Task<bool> PostAsync(T entity);
    }
}
