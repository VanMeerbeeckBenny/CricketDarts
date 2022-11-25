using Pin.CricketDarts.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Core.Interfaces.Repositories
{
    public interface IPlayerThrowRepository : IBaseRepository<PlayerThrow>
    {
        Task<IEnumerable<PlayerThrow>> GetByUserAndMatchIdAsync(Guid matchId, Guid userId);
    }
}
