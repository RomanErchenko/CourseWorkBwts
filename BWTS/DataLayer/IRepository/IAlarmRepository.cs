using DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace DataLayer.IRepository
{
    public interface IAlarmRepository:IRepository<Alarm>
    {
        Task<Alarm> GetById(Guid id);
        Task<bool> CreateNewAlarm(Alarm entity);
        IEnumerable<Alarm> GetAllAlarms();
        Task<bool> UpdateAlarm(Alarm entity);
        Task<bool> DeleteAlarm(Guid id);
        new Task<bool> SaveChangesAsync();
    }
}
