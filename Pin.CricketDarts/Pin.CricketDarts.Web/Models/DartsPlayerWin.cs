namespace Pin.CricketDarts.Web.Models
{
    public class DartsPlayerWin : BaseModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int WonMatches { get; set; }
    }
}
