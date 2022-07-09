using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors.Classes.Interfaces
{
    public interface IBetting
    {
        Bet BetCase { get; set; }
        int BetValue { get; set; }
        bool IsBetSuccess { get; set; }
    }
}
