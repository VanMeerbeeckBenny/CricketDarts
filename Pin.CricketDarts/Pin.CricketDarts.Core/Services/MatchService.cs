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
                PlayerOneScore = 0,
                PlayerTwoScore = 0,
                TimeStamp = DateTime.Now,
                Players = new List<Player> { playerOne, playerTwo }
            };

            if (!await _matchRepository.CreateAsync(newMatch))
                return new ItemResultModel<Match> { ErrorMessage = "Something went wrong, please try again later!" };

            return new ItemResultModel<Match> { IsSucces = true, Items = new List<Match> { newMatch } };
        }
    }
}
