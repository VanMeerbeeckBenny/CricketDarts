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

   
            builder.Entity<Point>()
                .HasIndex(t => t.Score)
                .IsUnique();

            builder.Entity<Player>().HasData(players);
            builder.Entity<Point>().HasData(throws);
        
        }
    }
}
