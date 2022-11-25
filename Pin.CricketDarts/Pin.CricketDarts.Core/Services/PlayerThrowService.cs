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
                ThrowId = throwId,
                TimeStamp = DateTime.Now,
            };

            if (!await _playerThrowRepository.CreateAsync(playerThrow))
                return new ItemResultModel<PlayerThrow> { ErrorMessage = "Something went wrong, please try again later!" };

            return new ItemResultModel<PlayerThrow> { IsSucces = true };
        }
    }
}