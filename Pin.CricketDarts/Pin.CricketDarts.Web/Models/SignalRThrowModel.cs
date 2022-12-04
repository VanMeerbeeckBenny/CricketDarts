namespace Pin.CricketDarts.Web.Models
{
    public class SignalRThrowModel
    {
        public ThrowModel Throw { get; set; }
        public Guid MatchId { get; set; }
        public Guid PlayerId { get; set; }
        public int CurrentScore { get; set; }
        public bool IsDone { get; set; }       
    }
}
