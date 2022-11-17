using Microsoft.EntityFrameworkCore;
using Pin.CricketDarts.Core.Entities;
using Pin.CricketDarts.Core.Enums;
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
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.Fifteen},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.DoubleFifteen },
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.TripleFifteen},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.Sixteen},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.DoubleSixteen},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.TripleSixteen},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.Seventeen},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.DoubleSeventeen},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.TripleSeventeen},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.Eighteen},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.DoubleEighteen},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.TripleEigteen},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.NineTeen},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.DoubleNineTeen},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.TripleNineTeen},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.Twenty},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.DoubleTwenty},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.TripleTwenty},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.BullOuter},
                new Throw {Id = Guid.NewGuid(),Score = DartsScoreEnum.BullInner},
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
                new PlayerThrow{Id = Guid.NewGuid(),PlayerId = players[0].Id,MatchId = matches[0].Id,ThrowId = throws[4].Id},
                new PlayerThrow{Id = Guid.NewGuid(),PlayerId = players[0].Id,MatchId = matches[0].Id,ThrowId = throws[6].Id},
                new PlayerThrow{Id = Guid.NewGuid(),PlayerId = players[1].Id,MatchId = matches[1].Id,ThrowId = throws[4].Id},
                new PlayerThrow{Id = Guid.NewGuid(),PlayerId = players[1].Id,MatchId = matches[0].Id,ThrowId = throws[8].Id},
                new PlayerThrow{Id = Guid.NewGuid(),PlayerId = players[1].Id,MatchId = matches[0].Id,ThrowId = throws[16].Id},
                new PlayerThrow{Id = Guid.NewGuid(),PlayerId = players[1].Id,MatchId = matches[0].Id,ThrowId = throws[19].Id},
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

            builder.Entity<Throw>()
                .HasIndex(t => t.Score)
                .IsUnique();

            builder.Entity<Player>().HasData(players);
            builder.Entity<Throw>().HasData(throws);
            builder.Entity<Match>().HasData(matches);
            builder.Entity<PlayerThrow>().HasData(playerThrows);
        }
    }
}
