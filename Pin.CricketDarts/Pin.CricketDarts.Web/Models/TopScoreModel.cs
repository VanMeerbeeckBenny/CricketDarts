namespace Pin.CricketDarts.Web.Models
{
    public class TopScoreModel
    {
        public Guid PlayerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int CountOfThrows { get; set; }
    }
}
