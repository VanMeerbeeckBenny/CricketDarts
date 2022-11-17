namespace Pin.CricketDarts.Core.Entities
{
    public class Throw : BaseEntitie
    {
        public string Name { get; set; }

        public List<PlayerThrow> PlayerThrows { get; set; }
    }
}