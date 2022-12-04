using Pin.CricketDarts.Core.Entities;
using Pin.CricketDarts.Core.Interfaces.Repositories;
using Pin.CricketDarts.Core.Interfaces.Services;
using Pin.CricketDarts.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Core.Services
{
    public class MatchPlayerService : IMatchPlayerService
    {
        private readonly IMatchPlayerRepository _matchPlayerRepository;

        public MatchPlayerService(IMatchPlayerRepository matchPlayerRepository )
        {
            _matchPlayerRepository = matchPlayerRepository;
        }
        public async Task<ItemResultModel<MatchPlayer>> CreateAsync(Guid matchId,Guid playerId)
        {
            MatchPlayer toCreate = new MatchPlayer { MatchId = matchId, PlayerId = playerId };            
            if(await _matchPlayerRepository.CreateAsync(toCreate))
                return new ItemResultModel<MatchPlayer> { IsSucces = true };
            return new ItemResultModel<MatchPlayer> { ErrorMessage = "Something went wrong, please try again later!" };

        }

        public async Task<ItemResultModel<MatchPlayer>> UpdateAsync(Guid id,Guid matchId, Guid playerId,int score)
        {
            var foundMatchPlayer = await _matchPlayerRepository.GetByIdAsync(id);

            if (foundMatchPlayer == null) return new ItemResultModel<MatchPlayer> { ErrorMessage = "Not found!" };
            if (await _matchPlayerRepository.UpdateAsync(foundMatchPlayer))
                return new ItemResultModel<MatchPlayer> { IsSucces = true };
            return new ItemResultModel<MatchPlayer> { ErrorMessage = "Something went wrong, please try again later!" };
        }

        public async Task<ItemResultModel<MatchPlayer>>GetByMatchAndPlayerId(Guid matchId,Guid playerId)
        {
            var foundMatchPlayer = await _matchPlayerRepository.GetByMatchAndPlayerId(matchId, playerId);

            if (foundMatchPlayer == null) return new ItemResultModel<MatchPlayer> { ErrorMessage = "Not found!" };            
            return new ItemResultModel<MatchPlayer> { IsSucces = true , Items = new List<MatchPlayer>{ foundMatchPlayer} };
         
        }
    }
}
