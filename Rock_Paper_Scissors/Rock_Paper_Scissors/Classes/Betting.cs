using Rock_Paper_Scissors.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors.Classes
{
    public class Betting:IBetting
    {
        public Bet BetCase { get; set; }
        public int BetValue { get; set; }
        public bool IsBetSuccess { get; set; }
    }
}
