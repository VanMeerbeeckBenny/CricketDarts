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
            return await _table.Include(m => m.PlayerMatch)
                         .OrderByDescending(m => m.TimeStamp)
                         .ToListAsync();
        }

        public async override Task<Match> GetByIdAsync(Guid id)
        {
            return await _table.Include(m => m.PlayerMatch)
                         .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Match>>GetByUserIdAsync(Guid userId)
        {
            return await _table.Include(m => m.PlayerMatch)
                               .Where(m => m.PlayerMatch.Select(p => p.PlayerId).Contains(userId))
                               .ToListAsync();
        }

        public async Task<List<Match>> GetActiveMatches()
        {
            return await _table.Include(m => m.PlayerMatch)
                         .ThenInclude(p => p.Player)
                         .ThenInclude(p => p.AllThrows)
                         .OrderByDescending(m => m.TimeStamp)
                         .Where(m => m.IsActiveGame == true)
                         .ToListAsync();
        }
    }
}
