using Pin.CricketDarts.Core.Entities;
using Pin.CricketDarts.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Core.Interfaces.Services
{
    public interface IPlayerService
    {
        Task<ItemResultModel<Player>>GetPlayerByIdAsync(Guid id);
        Task<ItemResultModel<Player>> GetPlayerWithAllThrowsByIdAsync(Guid id);
        Task<ItemResultModel<Player>> CreateAsync(Player playerToAdd);

    }
}
