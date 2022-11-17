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
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.Fifteen.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.DoubleFifteen.ToString() },
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.TripleFifteen.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.Sixteen.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.DoubleSixteen.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.TripleSixteen.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.Seventeen.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.DoubleSeventeen.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.TripleSeventeen.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.Eighteen.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.DoubleEighteen.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.TripleEigteen.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.NineTeen.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.DoubleNineTeen.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.TripleNineTeen.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.Twenty.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.DoubleTwenty.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.TripleTwenty.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.BullOuter.ToString()},
                new Throw {Id = Guid.NewGuid(),Name = DartsScoreEnum.BullInner.ToString()},
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
                .HasIndex(t => t.Name)
                .IsUnique();

            builder.Entity<Player>().HasData(players);
            builder.Entity<Throw>().HasData(throws);
            builder.Entity<Match>().HasData(matches);
            builder.Entity<PlayerThrow>().HasData(playerThrows);
        }
    }
}
