using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors.Classes.Interfaces
{
    public interface IGame
    {
        Betting GameBet { get; set; }
        Movement Move { get; set; }
        Result GameResult { get;}
    }
}
