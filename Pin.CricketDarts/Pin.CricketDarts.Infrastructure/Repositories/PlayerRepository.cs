using Microsoft.EntityFrameworkCore;
using Pin.CricketDarts.Core.Entities;
using Pin.CricketDarts.Core.Interfaces.Repositories;
using Pin.CricketDarts.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Infrastructure.Repositories
{
    public class PlayerRepository : GenericBaseRepository<Player>,IPlayerRepository
    {
        public PlayerRepository(DbDartsContext context):base(context)
        {

        }
        public async override Task<Player> GetByIdAsync(Guid id)
        {
            return await _table
                        .Include(p => p.Matches)
                        .ThenInclude(p => p.Match)
                        .Include(p => p.AllThrows)
                        .ThenInclude(at => at.Score)
                        .FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<Player> GetByIdWithAllThrowsAsync(Guid id)
        {
            return await _table
                        .Include(p => p.Matches)
                        .ThenInclude(p => p.Match)
                        .Include(p => p.AllThrows)
                        .ThenInclude(at => at.Score)
                        .FirstOrDefaultAsync(p => p.Id == id);
        }
        public override async Task<IEnumerable<Player>> GetAllAsync()
        {
            return await _table
                        .Include(p => p.Matches)
                        .ThenInclude(p => p.Match)
                        .Include(p => p.AllThrows)  
                        .ThenInclude(at => at.Score)
                        .ToListAsync();
        }

        public async Task<IEnumerable<Player>> GetByMatchId(Guid matchId)
        {
            return  await _table
                        .Include(p => p.Matches)
                        .ThenInclude(p => p.Match)
                        .Where(p => p.Matches.Select(m => m.Id).Contains(matchId))                               
                        .ToListAsync();                       
                              
        }
    }
}
