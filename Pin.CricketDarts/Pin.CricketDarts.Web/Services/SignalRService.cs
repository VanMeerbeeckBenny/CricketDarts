using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Pin.CricketDarts.Web.Models;
using Microsoft.AspNetCore.Components;
using Pin.CricketDarts.Web.Interfaces;

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
                    BaseNumber = score.BaseScore,
                    Throw = score.Score,
                    TimeStamp = DateTime.Now
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

        public async Task SendNewMatch(DartsMatchModel match)
        {

            HubConnection hubConnection = new HubConnectionBuilder()
                .WithUrl(Navigation.ToAbsoluteUri("/Cricket-darts"))
                .Build();

            await hubConnection.StartAsync();
            await hubConnection.SendAsync("SendMatch", match);
        }

        public async Task SendNewWinner(DartsPlayerModel player)
        {

            HubConnection hubConnection = new HubConnectionBuilder()
                .WithUrl(Navigation.ToAbsoluteUri("/Cricket-darts"))
                .Build();

            await hubConnection.StartAsync();
            await hubConnection.SendAsync("SendWinner", player);
        }
    }
}
