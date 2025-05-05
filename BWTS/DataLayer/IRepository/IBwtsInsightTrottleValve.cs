using DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IBwtsInsightTrottleValve:IRepository<BwtsInsightTrottleValve>
    {
        Task<BwtsInsightTrottleValve> GetById(Guid id);
        Task<bool> CreateNewValveTrottle(BwtsInsightTrottleValve entity);
        IEnumerable<BwtsInsightTrottleValve> GetAllValvesTrottle();
        Task<bool> UpdateValvesTrottle(BwtsInsightTrottleValve entity);
        Task<bool> DeleteValvesTrottle(Guid id);
        new Task<bool> SaveChangesAsync();

    }
}
