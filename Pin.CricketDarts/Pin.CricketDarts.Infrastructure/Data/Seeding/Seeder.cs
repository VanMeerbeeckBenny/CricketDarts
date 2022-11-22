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
                new Player{ Id = Guid.NewGuid(),Firstname="Benny",Lastname="Van Meerbeeck" },
                new Player{ Id = Guid.NewGuid(),Firstname="Arlette",Lastname="Verheugen" },
            };

            var throws = new Point[]
            {
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.Fifteen, OriginalScore=DartsScoreEnum.Fifteen},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.DoubleFifteen, OriginalScore=DartsScoreEnum.Fifteen },
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.TripleFifteen, OriginalScore=DartsScoreEnum.Fifteen},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.Sixteen, OriginalScore = DartsScoreEnum.Sixteen},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.DoubleSixteen, OriginalScore = DartsScoreEnum.Sixteen},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.TripleSixteen, OriginalScore = DartsScoreEnum.Sixteen},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.Seventeen, OriginalScore = DartsScoreEnum.Seventeen},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.DoubleSeventeen, OriginalScore = DartsScoreEnum.Seventeen},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.TripleSeventeen, OriginalScore = DartsScoreEnum.Seventeen},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.Eighteen, OriginalScore = DartsScoreEnum.Eighteen},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.DoubleEighteen, OriginalScore = DartsScoreEnum.Eighteen},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.TripleEigteen, OriginalScore = DartsScoreEnum.Eighteen},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.NineTeen, OriginalScore = DartsScoreEnum.NineTeen},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.DoubleNineTeen, OriginalScore = DartsScoreEnum.NineTeen},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.TripleNineTeen, OriginalScore = DartsScoreEnum.NineTeen},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.Twenty, OriginalScore = DartsScoreEnum.Twenty},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.DoubleTwenty, OriginalScore = DartsScoreEnum.Twenty},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.TripleTwenty, OriginalScore = DartsScoreEnum.Twenty},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.BullOuter,OriginalScore = DartsScoreEnum.BullOuter},
                new Point {Id = Guid.NewGuid(),Score = DartsScoreEnum.BullInner,OriginalScore = DartsScoreEnum.BullOuter},
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

            builder.Entity<Point>()
                .HasIndex(t => t.Score)
                .IsUnique();

            builder.Entity<Player>().HasData(players);
            builder.Entity<Point>().HasData(throws);
            builder.Entity<Match>().HasData(matches);
            builder.Entity<PlayerThrow>().HasData(playerThrows);
        }
    }
}
