using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Core.Entities
{
    public class MatchPlayer : BaseEntitie
    {
        public Guid MatchId { get; set; }
        public Match Match { get; set; }
        public Guid PlayerId { get; set; }
        public Player Player { get; set; }
        public int Score { get; set; }
    }
}
