using Microsoft.EntityFrameworkCore;
using Pin.CricketDarts.Core.Entities;
using Pin.CricketDarts.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Infrastructure.Repositories
{
    public  class PlayerThrowRepository : GenericBaseRepository<PlayerThrow>
    {

        public PlayerThrowRepository(DbDartsContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Throw>> GetByUserAndMatchIdAsync(Guid matchId, Guid userId)
        {
            List<Throw> throws = new List<Throw>();
            var playerThrows = await _table.Where(pt => pt.PlayerId == userId &&
                                                        pt.MatchId == matchId)
                                                     .OrderByDescending(pt => pt.TimeStamp)
                                                     .ToListAsync();           

            return throws;
        }
    }
}
