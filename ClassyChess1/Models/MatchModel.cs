using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassyChess1.Models
{
    public class MatchModel
    {
        public int MatchID { get; set; }
        public int Player1ID { get; set; }
        public int Player2ID { get; set; }
        public int WinnerID { get; set; } = -1;
    }
}