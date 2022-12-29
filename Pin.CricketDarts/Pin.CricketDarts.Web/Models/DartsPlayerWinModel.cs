namespace Pin.CricketDarts.Web.Models
{
    public class DartsPlayerWinModel : BaseModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int WonMatches { get; set; }
        public int AverageScore { get; set; }
    }
}

