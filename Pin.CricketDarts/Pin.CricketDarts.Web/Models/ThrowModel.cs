using Pin.CricketDarts.Core.Enums;

namespace Pin.CricketDarts.Web.Models
{
    public class ThrowModel : BaseModel
    {       
        public int BaseNumber { get; set; }
        public int Throw { get; set; }
        public DateTime TimeStamp { get; set; }
        public Guid MatchId { get; set; }
    }
}
