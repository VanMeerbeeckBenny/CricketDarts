using Pin.CricketDarts.Core.Enums;

namespace Pin.CricketDarts.Core.Entities
{
    public class Throw : BaseEntitie
    {
        public DartsScoreEnum Score { get; set; }

        public List<PlayerThrow> PlayerThrows { get; set; }
    }
}