using DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IBwtsInsideOperatingValves:IRepository<BwtsInsideOperatingValves>
    {
        Task<BwtsInsideOperatingValves> GetById(Guid id);
        Task<bool> CreateNewValve(BwtsInsightTrottleValve entity);
        IEnumerable<BwtsInsightTrottleValve> GetAllValves();
        Task<bool> UpdateValves(BwtsInsightTrottleValve entity);
        Task<bool> DeleteValves(Guid id);
        new Task<bool> SaveChangesAsync();
    }
}
