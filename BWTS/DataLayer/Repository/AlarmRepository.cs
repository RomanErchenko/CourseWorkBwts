using DataLayer.IRepository;
using DataStorage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace DataLayer.Repository
{
    public class AlarmRepository:BaseRepository<Alarm>, IAlarmRepository
    {
        ModelContext Context;
        public AlarmRepository(ModelContext context) : base(context)
        {
            Context = context;

        }
        public async Task<bool> DeleteAlarm(Guid id)
        {

            var p = await Context.Alarms.Where(p => p.Id == id).ExecuteDeleteAsync();

            return true;
        }

        public IEnumerable<Alarm> GetAllAlarms()
        {
            return Context.Alarms.ToList();

        }

        public IEnumerable<Alarm> GetAll()
        {
            return Context.Alarms.ToList();

        }

       

        public async Task<Alarm> GetById(Guid id)
        {
            return await Context.Alarms.Where(p => p.Id == id).FirstAsync();
        }

        new public async Task<bool> SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateAlarm(Alarm entity)
        {
            if (entity == null)
            {
                return false;
            }
            else
            {
                //Context.Attach(entity);
                Context.Entry(entity).State = EntityState.Modified;
                await SaveChangesAsync();
                return true;
            }
        }

        public async Task<bool> CreateNewAlarm(Alarm entity)
        {
            if (entity == null)
            {
                return false;
            }
            else
            {

                await Context.Alarms.AddAsync(entity);
                await SaveChangesAsync();
                return true;
            }
        }

    }
}
