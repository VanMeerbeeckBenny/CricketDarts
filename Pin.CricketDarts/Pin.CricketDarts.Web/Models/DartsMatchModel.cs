namespace Pin.CricketDarts.Web.Models
{
    public class DartsMatchModel
    {
        public Guid Id { get; set; }
        public DartsPlayerModel PlayerOne { get; set; }
        public DartsPlayerModel PlayerTwo { get; set; }
        public bool IsActiveMatch { get; set; }
    }
}
