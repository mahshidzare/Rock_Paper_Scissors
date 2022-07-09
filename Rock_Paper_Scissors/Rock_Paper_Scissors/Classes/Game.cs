using Rock_Paper_Scissors.Classes;
using Rock_Paper_Scissors.Classes.Interfaces;
using System;
namespace Rock_Paper_Scissors.Classes
{
    public class Game : IGame
    {
        public Betting GameBet { get; set; }
        public Movement Move { get; set; }
        public Result GameResult { get => GetGameResult(); }
        public Game()
        {
            Move = RandomMove();
            GameBet = new Betting();
        }
        private Movement RandomMove()
        {
            Random random = new Random();
            int nextMove = random.Next(0, 3);

            switch (nextMove)
            {
                case 0:
                    return Movement.Rock;
                case 1:
                    return Movement.Paper;
                default:
                    return Movement.Scissors;
            }
        }
        private Result GetGameResult()
        {
            // A => Rock
            switch (Move) //B
            {
                case Movement.Paper:
                    GameBet.IsBetSuccess = GameBet.BetCase==Bet.B;
                    return Result.win;
                case Movement.Scissors:
                    GameBet.IsBetSuccess = GameBet.BetCase == Bet.A;
                    return Result.lost;
                default:
                    GameBet.IsBetSuccess = GameBet.BetCase == Bet.draw;
                    return Result.draw;
            }
        }
    }
}