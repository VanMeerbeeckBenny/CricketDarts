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
    public class PlayerThrowService:IPlayerThrowService
    {
        private readonly IPlayerThrowRepository _playerThrowRepository;

        public PlayerThrowService(IPlayerThrowRepository playerThrowRepository)
        {
            _playerThrowRepository = playerThrowRepository;
        }      

        public async Task<ItemResultModel<PlayerThrow>>CreateAsync(Guid matchId,Guid playerId,Guid throwId)
        {
            var playerThrow = new PlayerThrow
            {
                Id = Guid.NewGuid(),
                PlayerId = playerId,
                MatchId = matchId,
                ScoreId = throwId,
                TimeStamp = DateTime.Now,
            };

            if (!await _playerThrowRepository.CreateAsync(playerThrow))
                return new ItemResultModel<PlayerThrow> { ErrorMessage = "Something went wrong, please try again later!" };

            return new ItemResultModel<PlayerThrow> { IsSucces = true };
        }

        public async Task<ItemResultModel<PlayerThrow>> GetByUserAndMatchIdAsync(Guid matchId, Guid playerId)
        {           
            var playerThrows = await _playerThrowRepository.GetByUserAndMatchIdAsync(matchId, playerId);
            if(playerThrows == null || !playerThrows.Any())            
                return new ItemResultModel<PlayerThrow> { ErrorMessage = "Nothing to show!" };

            return new ItemResultModel<PlayerThrow> { IsSucces = true,Items = playerThrows };
        }

        public async Task<ItemResultModel<PlayerThrow>> DeleteAsync(Guid id)
        {
            var foundThrow = await _playerThrowRepository.GetByIdAsync(id);

            if (foundThrow == null)
                return new ItemResultModel<PlayerThrow> { ErrorMessage = "Nothing to show!" };

            bool isSucces = await _playerThrowRepository.DeleteAsync(foundThrow);
            return new ItemResultModel<PlayerThrow> { IsSucces = isSucces };
        }

    }
}
