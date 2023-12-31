﻿using Microsoft.EntityFrameworkCore;
using Pin.CricketDarts.Core.Entities;
using Pin.CricketDarts.Infrastructure.Data.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Infrastructure.Data
{
    public class DbDartsContext :DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<PlayerThrow> PlayerThrow { get; set; }
        public DbSet<MatchPlayer> MatchPlayer { get; set; }
        public DbSet<Point> Throws { get; set; }

        public DbDartsContext(DbContextOptions<DbDartsContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PlayerThrow>()
                .HasOne(pt => pt.Player)
                .WithMany(p => p.AllThrows)
                .HasForeignKey(p => p.PlayerId);

            modelBuilder.Entity<PlayerThrow>()
             .HasOne(pt => pt.Score)
             .WithMany(p => p.PlayerThrows)
             .HasForeignKey(p => p.ScoreId);

            modelBuilder.Entity<MatchPlayer>()
               .HasOne(pt => pt.Player)
               .WithMany(p => p.Matches)
               .HasForeignKey(p => p.PlayerId);

            modelBuilder.Entity<MatchPlayer>()
             .HasOne(pt => pt.Match)
             .WithMany(p => p.PlayerMatch)
             .HasForeignKey(p => p.MatchId);

            Seeder.Seed(modelBuilder);
        }
    }
}
