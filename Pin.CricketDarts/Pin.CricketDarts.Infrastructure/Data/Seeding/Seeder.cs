using Microsoft.EntityFrameworkCore;
using Pin.CricketDarts.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Infrastructure.Data.Seeding
{
    public static class Seeder
    {
        public static void Seed(ModelBuilder builder)
        {
            var players = new Player[]
            {
                new Player{ Id = Guid.NewGuid(),Name="Benny" },
                new Player{ Id = Guid.NewGuid(),Name="Yoran" },
            };

            var throws = new Throw[]
            {
                new Throw {Id = Guid.NewGuid(),Seventeen=3,Twenty=2},
                new Throw {Id = Guid.NewGuid(), Fifteen=2,Twenty=3},
                new Throw {Id = Guid.NewGuid(),Sixteen=3,Twenty=2},
                new Throw {Id = Guid.NewGuid(),Eighteen=1,Nineteen=2},
                new Throw {Id = Guid.NewGuid(),Bull=2,Twenty=2},
                new Throw {Id = Guid.NewGuid(), Fifteen=3,Twenty=2},
                new Throw {Id = Guid.NewGuid(),Fifteen=3,Eighteen=2},
                new Throw {Id = Guid.NewGuid(),Eighteen=1,Nineteen=2},
            };

            var matches = new Match[]
            {
                new Match{ Id = Guid.NewGuid(),TimeStamp = DateTime.Now},
                new Match{ Id = Guid.NewGuid(),TimeStamp = DateTime.Now.AddHours(2)},
            };

            var playerThrows = new PlayerThrow[]
            {
                new PlayerThrow{Id = Guid.NewGuid(),PlayerId = players[0].Id,MatchId = matches[1].Id,ThrowId = throws[0].Id},
                new PlayerThrow{Id = Guid.NewGuid(),PlayerId = players[0].Id,MatchId = matches[0].Id,ThrowId = throws[1].Id},
                new PlayerThrow{Id = Guid.NewGuid(),PlayerId = players[0].Id,MatchId = matches[0].Id,ThrowId = throws[2].Id},
                new PlayerThrow{Id = Guid.NewGuid(),PlayerId = players[0].Id,MatchId = matches[0].Id,ThrowId = throws[3].Id},
                new PlayerThrow{Id = Guid.NewGuid(),PlayerId = players[1].Id,MatchId = matches[1].Id,ThrowId = throws[4].Id},
                new PlayerThrow{Id = Guid.NewGuid(),PlayerId = players[1].Id,MatchId = matches[0].Id,ThrowId = throws[5].Id},
                new PlayerThrow{Id = Guid.NewGuid(),PlayerId = players[1].Id,MatchId = matches[0].Id,ThrowId = throws[6].Id},
                new PlayerThrow{Id = Guid.NewGuid(),PlayerId = players[1].Id,MatchId = matches[0].Id,ThrowId = throws[7].Id},
            };


            var matchPlayer = new[]
            {
                new {MatchesId = matches[0].Id,PlayersId = players[0].Id},
                new {MatchesId = matches[1].Id,PlayersId = players[0].Id},
                new {MatchesId = matches[0].Id,PlayersId = players[1].Id},
                new {MatchesId = matches[1].Id,PlayersId = players[1].Id},
            };


            builder.Entity<Player>()
                .HasMany(p => p.Matches)
                .WithMany(m => m.Players)
                .UsingEntity(x => x.HasData(matchPlayer));

            builder.Entity<Player>().HasData(players);
            builder.Entity<Throw>().HasData(throws);
            builder.Entity<Match>().HasData(matches);
            builder.Entity<PlayerThrow>().HasData(playerThrows);
        }
    }
}
