using Microsoft.EntityFrameworkCore;
using Pin.CricketDarts.Core.Entities;
using Pin.CricketDarts.Core.Enums;
using Pin.CricketDarts.Core.Interfaces.Repositories;
using Pin.CricketDarts.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Infrastructure.Repositories
{
    public class ThrowRepository : GenericBaseRepository<Point>, IThrowRepository
    {
        public ThrowRepository(DbDartsContext context):base(context)
        {

        }

        public async Task<Point>GetThrowByValue(int value)
        {
            return await _table
                .FirstOrDefaultAsync(t => (int)t.Score == value);
        }

        public async Task<IEnumerable<Point>> GetAll()
        {
            return await _table
                .OrderBy(p => p.OriginalScore)
                .ThenBy(p => p.Score).ToListAsync();
        }

    }
}
