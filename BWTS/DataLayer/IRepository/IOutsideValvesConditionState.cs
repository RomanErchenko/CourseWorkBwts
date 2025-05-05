using DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IRepository
{
    public interface IOutsideValvesConditionState:IRepository<OutsideValvesConditionState>
    {
        Task<OutsideValvesConditionState> GetById(Guid id);
        Task<bool> CreateNewOutsideValve(OutsideValvesConditionState entity);
        IEnumerable<OutsideValvesConditionState> GetAllOutsideValves();
        Task<bool> UpdateOutsideValves(OutsideValvesConditionState entity);
        Task<bool> DeleteOutsideValves(Guid id);
        new Task<bool> SaveChangesAsync();
    }
}
