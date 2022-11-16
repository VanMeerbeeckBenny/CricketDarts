namespace Pin.CricketDarts.Core.Entities
{
    public class PlayerThrow:BaseEntitie
    {
        public Guid MatchId { get; set; }
        public Match Match { get; set; }
        public Guid PlayerId { get; set; }
        public Player Player { get; set; }
        public Guid ThrowId { get; set; }
        public Throw Throws { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}