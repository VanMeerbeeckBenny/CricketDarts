using Pin.CricketDarts.Core.Entities;
using Pin.CricketDarts.Core.Interfaces.Repositories;
using Pin.CricketDarts.Core.Interfaces.Services;
using Pin.CricketDarts.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Core.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository; 
        }

        public async Task<ItemResultModel<Player>> CreateAsync(string firstname,string lastname)
        {

            Player playerToAdd = new Player
            {                
                Firstname = firstname,
                Lastname = lastname
            };

            if (playerToAdd == null)
                return new ItemResultModel<Player> { ErrorMessage = "Please provide a valid player!" };

            var players = await _playerRepository.GetAllAsync();
            var foundPlayer = players.SingleOrDefault(p => p.Firstname.ToLower() == playerToAdd.Firstname.ToLower() &&
                               p.Lastname.ToLower() == playerToAdd.Lastname.ToLower());

            if (foundPlayer != null) return new ItemResultModel<Player>
            {
                ErrorMessage = $"{playerToAdd.Lastname} {playerToAdd.Firstname} alreddy exists!"
            };

            if (await _playerRepository.CreateAsync(playerToAdd))
                return new ItemResultModel<Player> { IsSucces = true };

            return new ItemResultModel<Player> { ErrorMessage = "Something went wrong, please try again later" }; ;
        }

        public async Task<ItemResultModel<Player>> GetAllPlayersAsync()
        {
            var players = await _playerRepository.GetAllAsync();

            if (players == null || !players.Any())
                return new ItemResultModel<Player> { ErrorMessage = "Player not found" };

            else
            {
                return new ItemResultModel<Player>
                {
                    Items = players ,
                    IsSucces = true
                };
            }
        }

        public async Task<ItemResultModel<Player>> GetPlayerByIdAsync(Guid id)
        {
            var player = await _playerRepository.GetByIdAsync(id);

            if (player == null) 
                return new ItemResultModel<Player> { ErrorMessage = "Player not found" };
           
            return new ItemResultModel<Player>
            {
                Items = new List<Player> { player },
                IsSucces = true
            };
            
        }

        public async Task<ItemResultModel<Player>> GetPlayerWithAllThrowsByIdAsync(Guid id)
        {
            var player = await _playerRepository.GetByIdWithAllThrowsAsync(id);

            if (player == null)
                return new ItemResultModel<Player> { ErrorMessage = "Player not found" };

            else
            {
                return new ItemResultModel<Player>
                {
                    Items = new List<Player> { player },
                    IsSucces = true
                };
            }
        }  
        
        public async Task<ItemResultModel<Player>> GetApponentByPlayerId(Guid id)
        {
            var allPlayer = await _playerRepository.GetAllAsync();
            var valibleCandidated = allPlayer.ToList();
            var currentPlayer =await _playerRepository.GetByIdAsync(id);
            valibleCandidated.Remove(currentPlayer);//player can not play agains him self
            if (currentPlayer == null) return new ItemResultModel<Player> { ErrorMessage = "Player not found!" };

            foreach (Guid matchId in currentPlayer.Matches.Select(m => m.MatchId))
            {
                foreach (var player in allPlayer)
                {
                    if (player.Matches.Select(m => m.MatchId).Contains(matchId))
                    {
                        var foundPlayer = valibleCandidated.FirstOrDefault(v => v.Id == player.Id);
                        valibleCandidated.Remove(foundPlayer);
                    }
                }
            }
            
            valibleCandidated = valibleCandidated.Where(p => !p.Matches.Select(m => m.Match.IsActiveGame).Any()).ToList();//check for any active games
            if (!valibleCandidated.Any()) return new ItemResultModel<Player> { ErrorMessage = "No Posible apponent found!" };
            return new ItemResultModel<Player> { IsSucces = true,Items = valibleCandidated };
        }


    }
}
