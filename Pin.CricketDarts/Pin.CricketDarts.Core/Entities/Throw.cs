namespace Pin.CricketDarts.Core.Entities
{
    public class Throw : BaseEntitie
    {        
        public byte Fifteen { get; set; }
        public byte Sixteen { get; set; }
        public byte Seventeen { get; set; }
        public byte Eighteen { get; set; }
        public byte Nineteen { get; set; }
        public byte Twenty { get; set; }
        public byte Bull { get; set; }

        public List<PlayerThrow> PlayerThrows { get; set; }
    }
}