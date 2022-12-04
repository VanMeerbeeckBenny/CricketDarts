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
    public class MatchPlayerRepository:GenericBaseRepository<MatchPlayer>,IMatchPlayerRepository
    {
        public MatchPlayerRepository(DbDartsContext dbContext):base(dbContext)
        {
                
        }

        public async Task<MatchPlayer> GetByMatchAndPlayerId(Guid matchId,Guid playerId)
        {
            return await _table
                .Include(mp => mp.Player)
                .Include(mp => mp.Match)
                .FirstOrDefaultAsync(mp => mp.PlayerId == playerId && mp.MatchId == matchId);
                               
        }
    }
}
