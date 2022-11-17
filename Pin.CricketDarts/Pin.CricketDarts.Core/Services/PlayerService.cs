﻿using Pin.CricketDarts.Core.Entities;
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
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository; 
        }

        public async Task<ItemResultModel<Player>> CreateAsync(Player playerToAdd)
        {
            if (playerToAdd == null)
                return new ItemResultModel<Player> { ErrorMessage = "Please provide a valid player!" };

            if (await _playerRepository.CreateAsync(playerToAdd))
                return new ItemResultModel<Player> { IsSucces = true };

            return new ItemResultModel<Player> { ErrorMessage = "Something went wrong, please try again later" }; ;
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
    }
}
