using Microsoft.EntityFrameworkCore;
using Pin.CricketDarts.Core.Entities;
using Pin.CricketDarts.Core.Interfaces.Repositories;
using Pin.CricketDarts.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Infrastructure.Repositories
{
    public abstract class GenericBaseRepository<T>:IBaseRepository<T> where T : BaseEntitie
    {
        protected readonly DbDartsContext _cricketDartsDB;
        protected readonly DbSet<T> _table;

        public GenericBaseRepository(DbDartsContext dbDarts)
        {
            _cricketDartsDB = dbDarts;
            _table= dbDarts.Set<T>();
        }

        public async Task<bool> CreateAsync(T toAdd)
        {
            await _table.AddAsync(toAdd);
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(T toDelete)
        {
            _table.Remove(toDelete);
            return await SaveAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public async virtual Task<T> GetByIdAsync(Guid id)
        {
            return await _table.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<bool> UpdateAsync(T toUpdate)
        {
            _table.Update(toUpdate);
            return await SaveAsync();
        }

        private async Task<bool> SaveAsync()
        {
            try
            {
                await _cricketDartsDB.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
