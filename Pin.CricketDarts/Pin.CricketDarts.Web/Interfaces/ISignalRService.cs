﻿using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Pin.CricketDarts.Web.Models;

namespace Pin.CricketDarts.Web.Interfaces
{
    public interface ISignalRService
    {
        Task SendNewThrow(DartsMatchModel currentMatch, ScoreModel score, DartsPlayerModel player, bool gameIsDone = false);
        Task SendNewMatch(DartsMatchModel match);
        Task SendNewWinner(DartsPlayerModel player);
    }
}
