using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Pin.CricketDarts.Core.Interfaces.Repositories;
using Pin.CricketDarts.Core.Interfaces.Services;
using Pin.CricketDarts.Core.Services;
using Pin.CricketDarts.Infrastructure.Data;
using Pin.CricketDarts.Infrastructure.Repositories;
using Pin.CricketDarts.Web.Hubs;
using Pin.CricketDarts.Web.Interfaces;
using Pin.CricketDarts.Web.Models;
using Pin.CricketDarts.Web.Services;

namespace Pin.CricketDarts.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<DbDartsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DartsDb")));

            builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
            builder.Services.AddScoped<IPlayerService, PlayerService>();
            builder.Services.AddScoped<IThrowService, ThrowService>();
            builder.Services.AddScoped<IPointRepository, PointRepository>();
            builder.Services.AddScoped<IPlayerThrowRepository, PlayerThrowRepository>();
            builder.Services.AddScoped<IPlayerThrowService, PlayerThrowService>();
            builder.Services.AddScoped<IMatchRepository, MatchRepository>();
            builder.Services.AddScoped<IMatchService, MatchService>();
            builder.Services.AddScoped<IPosibleThrowService, PosibleThrowService>();
            builder.Services.AddScoped<IMatchPlayerRepository, MatchPlayerRepository>();
            builder.Services.AddScoped<IMatchPlayerService, MatchPlayerService>();
            builder.Services.AddScoped<ISignalRService, SignalRService>();
            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSignalR();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapHub<CricketDartsHub>("/Cricket-darts");
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}