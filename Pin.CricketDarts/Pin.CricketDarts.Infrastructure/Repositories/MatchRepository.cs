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
    public class MatchRepository : GenericBaseRepository<Match>,IMatchRepository
    {
        public MatchRepository(DbDartsContext context):base(context)
        {

        }

        public async override Task<IEnumerable<Match>> GetAllAsync()
        {
            return await _table.Include(m => m.Players)
                         .OrderByDescending(m => m.TimeStamp)
                         .ToListAsync();
        }

        public async override Task<Match> GetByIdAsync(Guid id)
        {
            return await _table.Include(m => m.Players)
                         .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Match>>GetByUserIdAsync(Guid userId)
        {
            return await _table.Include(m => m.Players)
                               .Where(m => m.Players.Select(p => p.Id).Contains(userId))
                               .ToListAsync();
        }

        public async Task<List<Match>> GetActiveMatches()
        {
            return await _table.Include(m => m.Players)
                         .ThenInclude(p => p.AllThrows)
                         .OrderByDescending(m => m.TimeStamp)
                         .Where(m => m.IsActiveGame == true)
                         .ToListAsync();
        }
    }
}
