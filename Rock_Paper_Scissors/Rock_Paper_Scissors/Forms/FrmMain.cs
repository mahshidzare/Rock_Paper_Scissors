using Rock_Paper_Scissors.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Rock_Paper_Scissors.Forms
{
    public partial class FrmMain : Form
    {
        #region props
            private Game game;
            private List<Logger> logger;
            private int _logCounter;
        #endregion
        #region consts
            public FrmMain()
            {
                InitializeComponent();
            }
        #endregion
        #region methods
            private void resetHand()
            {
                game = new Game();
                picPaper.Visible = picRock.Visible = picScissor.Visible = false;
            }
            private void resetGame()
            {
                logger = new List<Logger>();
                txtBet.Text = "0";
                _logCounter = 0;
                lblLostBet.Text = "0";
                lblSumBet.Text = "0";
                lblWinBet.Text = "0";
                lstHistory.Items.Clear();
                resetHand();
                lblSumBet.BackColor = System.Drawing.Color.Gainsboro;

            }
            private void logMove(Game _game)
            {
                _logCounter++;
                logger.Add(new Logger { Id = _logCounter, Movement = _game.Move, GameResult = _game.GameResult, BetValue = _game.GameBet.BetValue, IsBetSuccess = _game.GameBet.IsBetSuccess });
                ListViewItem newItem = new ListViewItem(new string[] { _logCounter.ToString(), _game.Move.ToString(), _game.GameResult.ToString(), _game.GameBet.BetValue.ToString(), _game.GameBet.IsBetSuccess ? "Yes" : "No" }, -1);

                if (_game.GameResult == Result.win)
                    newItem.ForeColor = System.Drawing.Color.Green;
                else if (_game.GameResult == Result.lost)
                    newItem.ForeColor = System.Drawing.Color.Red;
                else if (_game.GameResult == Result.draw)
                    newItem.ForeColor = System.Drawing.Color.DarkSlateGray;

                lstHistory.Items.Add(newItem);
                lstHistory.Items[lstHistory.Items.Count - 1].EnsureVisible();

            }
            private void calculateBets()
            {
                var wins = logger.Where(l => l.IsBetSuccess).Sum(s => s.BetValue);
                var losts = logger.Where(l => !l.IsBetSuccess).Sum(s => s.BetValue);
                lblLostBet.Text = losts.ToString();
                lblWinBet.Text = wins.ToString();
                lblSumBet.Text = (wins - losts).ToString();
                lblSumBet.BackColor = wins - losts < 0 ? System.Drawing.Color.Red :
                    wins - losts > 0 ? System.Drawing.Color.Green : System.Drawing.Color.Gainsboro;
            }
        #endregion
        #region events
            private void Form1_Load(object sender, EventArgs e)
            {
                resetGame();
            }
            private void btnPlay_Click(object sender, EventArgs e)
            {
                if (!string.IsNullOrWhiteSpace(txtBet.Text) && (Convert.ToInt32(txtBet.Text.Trim()) < 0 || Convert.ToInt32(txtBet.Text.Trim()) > 100))
                {
                    MessageBox.Show("Enter a valid number between 0-100 !");
                    return;
                }
                resetHand();
                int betValue = string.IsNullOrWhiteSpace(txtBet.Text) ? 0 : Convert.ToInt32(txtBet.Text.Trim());
                Bet selectedBet = Bet.draw;
                if (rdoBetA.Checked) selectedBet = Bet.A;
                else if (rdoBetB.Checked) selectedBet = Bet.B;
                game.GameBet.BetValue = betValue;
                game.GameBet.BetCase = selectedBet;
                if (game.Move == Movement.Paper) picPaper.Visible = true;
                else if (game.Move == Movement.Scissors) picScissor.Visible = true;
                else if (game.Move == Movement.Rock) picRock.Visible = true;
                logMove(game);
                calculateBets();
            }
            private void btnFinish_Click(object sender, EventArgs e)
            {
                var playerWin = logger.Where(l => l.GameResult == Result.win).Count();
                var playerlost = logger.Where(l => l.GameResult == Result.lost).Count();
                var playerDraw = logger.Where(l => l.GameResult == Result.draw).Count();
                var winBet = logger.Where(l => l.IsBetSuccess).Sum(s => s.BetValue);
                var lostBet = logger.Where(l => !l.IsBetSuccess).Sum(s => s.BetValue);
                var totalBet = winBet - lostBet;
                MessageBox.Show($"summary:\n" +
                    $"player Won:{playerWin} times" +
                    $" / player lost: {playerlost} times" +
                    $" / draw: {playerDraw} times" +
                    $" / win Bet : {winBet} " +
                    $" / lost Bet : {lostBet} " +
                    $" / total Bet : {totalBet}");
                resetGame();
            }
            private void txtBet_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        #endregion
    }
}
