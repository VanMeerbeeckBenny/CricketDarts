using Pin.CricketDarts.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.CricketDarts.Core.Services.Models
{
    public class ItemResultModel<T> where T : BaseEntitie
    {
        public bool IsSucces { get; set; }
        public string ErrorMessage { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}
