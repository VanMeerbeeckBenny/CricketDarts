namespace Pin.CricketDarts.Web.Models
{
    public class DartsMatchModel
    {
        public DartsPlayerModel PlayerOne { get; set; }
        public DartsPlayerModel PlayerTwo { get; set; }
        public bool IsActiveMatch { get; set; }
    }
}
