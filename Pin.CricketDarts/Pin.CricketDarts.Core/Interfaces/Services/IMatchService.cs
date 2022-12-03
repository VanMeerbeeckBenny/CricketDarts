using Pin.CricketDarts.Core.Entities;
using Pin.CricketDarts.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Core.Interfaces.Services
{
    public interface IMatchService
    {
        Task<ItemResultModel<Match>>CreateAsync(Guid playeroneId, Guid playerTwoId);
        Task<ItemResultModel<Match>> UpdateAsync(Guid id,bool isActive,int playerOneScore,int PlayerTwoScore);

    }
}
