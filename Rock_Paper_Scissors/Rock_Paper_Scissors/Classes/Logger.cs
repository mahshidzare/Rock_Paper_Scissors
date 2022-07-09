using Rock_Paper_Scissors.Classes.Interfaces;

namespace Rock_Paper_Scissors.Classes
{
    public class Logger:ILogger
    {
        public int Id { get; set; }
        public Movement Movement { get; set; }
        public Result GameResult { get; set; }
        public int BetValue { get; set; }
        public bool IsBetSuccess { get; set; }

    }
}
