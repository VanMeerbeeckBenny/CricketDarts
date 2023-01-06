using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Pin.CricketDarts.Web.Models;
using Microsoft.AspNetCore.Components;
using Pin.CricketDarts.Web.Interfaces;
using static System.Formats.Asn1.AsnWriter;
using Pin.CricketDarts.Core.Entities;

namespace Pin.CricketDarts.Web.Services
{
    public class SignalRService : ISignalRService
    {
        private NavigationManager Navigation;
        public SignalRService(NavigationManager navigation)
        {
            Navigation = navigation;
        }

        public async Task SendNewThrow(DartsMatchModel currentMatch,ScoreModel score, DartsPlayerModel player, bool gameIsDone = false)
        {
            var signalrThrowModel = new SignalRThrowModel
            {
                Throw = new ThrowModel
                {
                    Id = player.Throws.OrderByDescending(t => t.TimeStamp).FirstOrDefault().Id,
                    BaseNumber = score.BaseScore,
                    Throw = score.Score,
                    TimeStamp = DateTime.Now,
                    MatchId = currentMatch.Id
                },
                CurrentScore = player.Score,
                MatchId = currentMatch.Id,
                PlayerId = player.Id,
                IsDone = gameIsDone
            };

            HubConnection hubConnection = new HubConnectionBuilder()
                .WithUrl(Navigation.ToAbsoluteUri("/Cricket-darts"))
                .Build();

            await hubConnection.StartAsync();
            await hubConnection.SendAsync("SendThrow", signalrThrowModel);
        }
        
        public async Task SendNewPlayer(Player player)
        {
            var dartsPlayerModel = new DartsPlayerModel
            {
                Id = player.Id,
                FirstName = player.Firstname,
                LastName = player.Lastname,
                Throws = new List<ThrowModel>(),
                FinischedNumbers = new FinischedNumbersModel(),                
            };

            HubConnection hubConnection = new HubConnectionBuilder()
                .WithUrl(Navigation.ToAbsoluteUri("/Cricket-darts"))
                .Build();

            await hubConnection.StartAsync();
            await hubConnection.SendAsync("SendNewPlayer", dartsPlayerModel);
        }

        public async Task SendRemoveThrow(ThrowModel playerThrow, DartsPlayerModel player)
        {
            var signalrThrowModel = new SignalRThrowModel
            {
                Throw = new ThrowModel
                {
                    Id = playerThrow.Id,
                    BaseNumber = playerThrow.BaseNumber,
                    Throw = playerThrow.Throw,
                    TimeStamp = DateTime.Now,
                    MatchId = playerThrow.MatchId
                },
                PlayerId = player.Id,
                MatchId = playerThrow.MatchId,
                CurrentScore = player.Score
                
            };

            HubConnection hubConnection = new HubConnectionBuilder()
                .WithUrl(Navigation.ToAbsoluteUri("/Cricket-darts"))
                .Build();

            await hubConnection.StartAsync();
            await hubConnection.SendAsync("SendRemoveThrow", signalrThrowModel);
        }

        public async Task SendNewMatch(DartsMatchModel match)
        {

            HubConnection hubConnection = new HubConnectionBuilder()
                .WithUrl(Navigation.ToAbsoluteUri("/Cricket-darts"))
                .Build();

            await hubConnection.StartAsync();
            await hubConnection.SendAsync("SendMatch", match);
        }

        public async Task SendRemoveStat(ThrowModel throwModel, DartsPlayerModel player)
        {
            var signalrThrowModel = new SignalRThrowModel
            {
                Throw = new ThrowModel
                {
                    Id = throwModel.Id,
                    BaseNumber = throwModel.BaseNumber,
                    Throw = throwModel.Throw,
                    TimeStamp = DateTime.Now,
                    MatchId = throwModel.MatchId
                },
                CurrentScore = player.Score,
                MatchId = throwModel.MatchId,
                PlayerId = player.Id,                
            };
            HubConnection hubConnection = new HubConnectionBuilder()
                .WithUrl(Navigation.ToAbsoluteUri("/Cricket-darts"))
                .Build();

            await hubConnection.StartAsync();
            await hubConnection.SendAsync("SendRemoveStat", signalrThrowModel);
        }

        public async Task SendNewWinner(DartsPlayerWinModel player)
        {

            HubConnection hubConnection = new HubConnectionBuilder()
                .WithUrl(Navigation.ToAbsoluteUri("/Cricket-darts"))
                .Build();

            await hubConnection.StartAsync();
            await hubConnection.SendAsync("SendWinner", player);
        }
    }
}
