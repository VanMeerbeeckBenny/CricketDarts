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
    public class MatchService : IMatchService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMatchRepository _matchRepository;

        public MatchService(IPlayerRepository playerRepository,IMatchRepository matchRepository)
        {
            _playerRepository = playerRepository;
            _matchRepository = matchRepository;
        }
        public async Task<ItemResultModel<Match>> CreateAsync(Guid playeroneId,Guid playerTwoId)
        {
            var playerOne = await _playerRepository.GetByIdAsync(playeroneId);
            var playerTwo = await _playerRepository.GetByIdAsync(playerTwoId);

            if (playerOne == null || playerTwo == null) return new ItemResultModel<Match>
            {
                ErrorMessage = "One or more player do not exists!"
            };

            Match newMatch = new Match
            {                
                IsActiveGame = true,              
                TimeStamp = DateTime.Now,             
            };

            if (!await _matchRepository.CreateAsync(newMatch))
                return new ItemResultModel<Match> { ErrorMessage = "Something went wrong, please try again later!" };

            return new ItemResultModel<Match> { IsSucces = true, Items = new List<Match> { newMatch } };
        }

        public async Task<ItemResultModel<Match>> UpdateAsync(Guid id, bool isActive, int playerOneScore, int PlayerTwoScore)
        {
            Match foundMatch = await _matchRepository.GetByIdAsync(id);
            if (foundMatch == null) return new ItemResultModel<Match> { ErrorMessage = "No sutch match!" };

            foundMatch.IsActiveGame = isActive;     
            
            bool isSucces = await _matchRepository.UpdateAsync(foundMatch);
            if (!isSucces) return new ItemResultModel<Match> { ErrorMessage = "Something went wrong, please try again later!" };
            return new ItemResultModel<Match> { IsSucces = true };
        }

        public async Task<ItemResultModel<Match>> GetActiveMatches()
        {
            var result =await _matchRepository.GetActiveMatches();
            if (result == null) return new ItemResultModel<Match> { ErrorMessage = "No active match!" };

            return new ItemResultModel<Match> { IsSucces = true, Items = result  };
        }
    }
}
