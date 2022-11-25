using Pin.CricketDarts.Core.Entities;
using Pin.CricketDarts.Core.Interfaces.Repositories;
using Pin.CricketDarts.Core.Interfaces.Services;
using Pin.CricketDarts.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Core.Services
{
    public class ThrowService:IThrowService
    {
        private readonly IPointRepository _throwRepository;

        public ThrowService(IPointRepository throwRepository)
        {
            _throwRepository = throwRepository;
        }

        public async Task<ItemResultModel<Point>> GetThrowByValue(int value)
        {
            var throwByValue = await _throwRepository.GetThrowByValue(value);

            if (throwByValue == null) return new ItemResultModel<Point>
            {
                ErrorMessage = "An error hase accures, please try again later!"
            };

            return new ItemResultModel<Point>
            {
                Items =  new List<Point> { throwByValue },
                IsSucces = true
            };
        }

        public async Task<ItemResultModel<Point>> GetAll()
        {
            var allScores = await _throwRepository.GetAll();

            if (allScores == null || !allScores.Any()) return new ItemResultModel<Point>
            {
                ErrorMessage = "An error hase accures, please try again later!"
            };

            return new ItemResultModel<Point>
            {
                Items = allScores ,
                IsSucces = true
            };
        }
    }
}
