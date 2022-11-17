using Pin.CricketDarts.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Core.Interfaces.Repositories
{
    public interface IPlayerRepository:IBaseRepository<Player>
    {

        Task<IEnumerable<Player>> GetByMatchId(Guid matchId);
        Task<Player> GetByIdWithAllThrowsAsync(Guid id);


    }
}
