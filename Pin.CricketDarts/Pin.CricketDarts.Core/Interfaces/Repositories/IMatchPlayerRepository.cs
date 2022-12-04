using Pin.CricketDarts.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Core.Interfaces.Repositories
{
    public interface IMatchPlayerRepository:IBaseRepository<MatchPlayer>
    {
        Task<MatchPlayer> GetByMatchAndPlayerId(Guid matchId, Guid playerId);
    }
}
