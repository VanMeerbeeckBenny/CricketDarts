using Pin.CricketDarts.Core.Entities;
using Pin.CricketDarts.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Core.Interfaces.Services
{
    public interface IThrowService
    {
        Task <ItemResultModel<Point>> GetThrowByValue(int value);
        Task<ItemResultModel<Point>> GetAll();
    }
}
