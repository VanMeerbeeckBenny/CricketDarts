using Pin.CricketDarts.Core.Enums;

namespace Pin.CricketDarts.Core.Entities
{
    public class Point : BaseEntitie
    {
        public DartsScoreEnum OriginalScore { get; set; }
        public DartsScoreEnum Score { get; set; }
        public List<PlayerThrow> PlayerThrows { get; set; }
    }
}