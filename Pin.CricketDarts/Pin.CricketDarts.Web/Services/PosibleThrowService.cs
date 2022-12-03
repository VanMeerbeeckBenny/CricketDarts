using Pin.CricketDarts.Core.Entities;
using Pin.CricketDarts.Core.Interfaces.Services;
using Pin.CricketDarts.Web.Interfaces;
using Pin.CricketDarts.Web.Models;
using System;

namespace Pin.CricketDarts.Web.Services
{
    public class PosibleThrowService : IPosibleThrowService
    {
        private readonly IThrowService _throwService;

        public PosibleThrowService(IThrowService throwService)
        {
            _throwService = throwService;          
        }

        
        public async Task<List<ScoresPerNumberModel>> CreateAllThrows()
        {

            var result = await _throwService.GetAll();
            if (result.IsSucces)
            {
                var groupedPoints = result.Items.GroupBy(p => p.OriginalScore)
                            .Select(group => group.ToList())
                            .ToList();          
          

                groupedPoints.RemoveAt(groupedPoints.Count - 1);// remove bull as it is drawn difrent
                var allPosibleThrow = CreateScorePerNumberModels(groupedPoints);
                return allPosibleThrow;

            }else return null;
        }

        public async Task<List<ScoreModel>> CreateAllBullThrows()
        {

            var result = await _throwService.GetAll();
            if (result.IsSucces)
            {
                var groupedPoints = result.Items.GroupBy(p => p.OriginalScore)
                            .Select(group => group.ToList())
                            .ToList();

                var bull = groupedPoints[groupedPoints.Count - 1];
                return bull.Select(p => new ScoreModel
                {
                    Id = p.Id,
                    Score = (int)p.Score,
                    BaseScore = (int)p.OriginalScore,
                    Name = p.Score.ToString()
                }).ToList();
            }
            else return null;
        }


        private static List<ScoresPerNumberModel> CreateScorePerNumberModels(List<List<Point>> groupedPoints)
        {
            List<ScoresPerNumberModel> allPosibleThrow = new();

            foreach (var group in groupedPoints)
            {
                var scorePerNumber = new ScoresPerNumberModel
                {
                    Name = group.FirstOrDefault().OriginalScore.ToString()
                };
                scorePerNumber.Single = new ScoreModel
                {
                    Id = group[0].Id,
                    Score = (int)group[0].Score,
                    BaseScore = (int)group[0].OriginalScore,
                    Name = group[0].OriginalScore.ToString()
                };
                scorePerNumber.Double = new ScoreModel
                {
                    Id = group[1].Id,
                    Score = (int)group[1].Score,
                    BaseScore = (int)group[1].OriginalScore,
                    Name = group[1].OriginalScore.ToString()
                };
                scorePerNumber.Triple = new ScoreModel
                {
                    Id = group[2].Id,
                    Score = (int)group[2].Score,
                    BaseScore = (int)group[2].OriginalScore,
                    Name = group[2].OriginalScore.ToString()
                };
                allPosibleThrow.Add(scorePerNumber);

            };

            return allPosibleThrow;
        }
    }
}
