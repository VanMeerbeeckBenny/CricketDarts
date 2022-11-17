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
    public class ThrowRepository : GenericBaseRepository<Throw>
    {
        public ThrowRepository(DbDartsContext context):base(context)
        {

        }

        public async Task<Throw>GetThrowsById(Guid id)
        {            
            Throw score =await _table.FirstOrDefaultAsync(t => t.Id == id);           

            return score;
        }
    }
}
