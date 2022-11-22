namespace Pin.CricketDarts.Web.Models
{
    public class ScoresPerNumberModel
    {
        public string Name { get; set; }    
        public ScoreModel Single { get; set; }     
        public ScoreModel Double { get; set; }
        public ScoreModel Triple { get; set; }
    }
}
