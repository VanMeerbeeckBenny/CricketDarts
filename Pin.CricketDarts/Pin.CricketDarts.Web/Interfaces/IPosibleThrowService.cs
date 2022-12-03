using Pin.CricketDarts.Web.Models;

namespace Pin.CricketDarts.Web.Interfaces
{
    public interface IPosibleThrowService
    {
        Task<List<ScoresPerNumberModel>> CreateAllThrows();

        Task<List<ScoreModel>> CreateAllBullThrows();
    }
}
