using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Core.Entities
{
    public class Match : BaseEntitie
    {    
        public int PlayerOneScore { get; set; }
        public int PlayerTwoScore { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsActiveGame { get; set; }
        public List<Player> Players { get; set; }
    }
}
