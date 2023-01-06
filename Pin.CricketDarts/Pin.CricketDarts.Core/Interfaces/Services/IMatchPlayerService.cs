using Pin.CricketDarts.Core.Entities;
using Pin.CricketDarts.Core.Interfaces.Repositories;
using Pin.CricketDarts.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Core.Interfaces.Services
{
    public interface IMatchPlayerService
    {
        Task<ItemResultModel<MatchPlayer>> CreateAsync(Guid matchId, Guid playerId);
        Task<ItemResultModel<MatchPlayer>> UpdateAsync(Guid matchId, Guid playerId, int score);      
    }
}
