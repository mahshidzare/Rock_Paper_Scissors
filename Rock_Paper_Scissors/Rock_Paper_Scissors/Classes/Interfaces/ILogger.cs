using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors.Classes.Interfaces
{
    public interface ILogger
    {
        int Id { get; set; }
        Movement Movement { get; set; }
        Result GameResult { get; set; }
        int BetValue { get; set; }
        bool IsBetSuccess { get; set; }

    }
}
