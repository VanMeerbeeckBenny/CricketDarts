using Microsoft.AspNetCore.SignalR;
using Pin.CricketDarts.Web.Models;

namespace Pin.CricketDarts.Web.Hubs
{
    public class CricketDartsHub : Hub
    {
        public async Task SendThrow(SignalRThrowModel model)
        {
            await Clients.Others.SendAsync("SendThrow", model);
        }

        public async Task SendMatch(DartsMatchModel match)
        {
            await Clients.Others.SendAsync("SendMatch", match);
        }

        public async Task SendWinner(DartsPlayerWinModel player)
        {
            await Clients.Others.SendAsync("SendWinner", player);
        }

        public async Task SendRemoveThrow(SignalRThrowModel playerThrow)
        {
            await Clients.Others.SendAsync("SendRemoveThrow", playerThrow);
        }

        public async Task SendRemoveStat(SignalRThrowModel playerThrow)
        {
            await Clients.Others.SendAsync("SendRemoveStat", playerThrow);
        }
    }
}
