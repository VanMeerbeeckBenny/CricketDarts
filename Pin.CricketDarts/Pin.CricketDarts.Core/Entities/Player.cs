﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Core.Entities
{
    public class Player : BaseEntitie
    {
        public string Name { get; set; }        
        public List<PlayerThrow> AllThrows { get; set; }
        public List<Match> Matches { get; set; }
    }
}