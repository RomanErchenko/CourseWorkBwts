using DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IOperationalLog:IRepository<OperationLog>
    {
        Task<OperationLog> GetById(Guid id);
        Task<bool> CreateNewAlarm(OperationLog entity);
        IEnumerable<OperationLog> GetAllAlarms();
        Task<bool> UpdateAlarm(OperationLog entity);
        Task<bool> DeleteAlarm(Guid id);
        new Task<bool> SaveChangesAsync();
    }
}
