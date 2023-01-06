using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Pin.CricketDarts.Core.Entities;
using Pin.CricketDarts.Web.Models;

namespace Pin.CricketDarts.Web.Interfaces
{
    public interface ISignalRService
    {
        Task SendNewThrow(DartsMatchModel currentMatch, ScoreModel score, DartsPlayerModel player, bool gameIsDone = false);
        Task SendNewMatch(DartsMatchModel match);
        Task SendNewWinner(DartsPlayerWinModel player);
        Task SendRemoveThrow(ThrowModel playerThrow, DartsPlayerModel player);
        Task SendRemoveStat(ThrowModel throwModel, DartsPlayerModel player);
        Task SendNewPlayer(Player player);
    }
}
