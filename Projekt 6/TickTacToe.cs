using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_6
{
    public partial class TickTacToe : Form
    {
        public TickTacToe()
        {
            InitializeComponent();
            gamePanel.Hide();
            goToMenuButton.Hide();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            gamePanel.Show();
            goToMenuButton.Show();
            hideTie();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goToMenuButton_Click(object sender, EventArgs e)
        {
            gamePanel.Hide();
            goToMenuButton.Hide();
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if(whosTurn) //kolej gracza 1
            {
                clickedButton.Text = "X";
            }
            else //kolej gracza 2
            {
                clickedButton.Text = "O";
            }
            turn_Count++;
            whosTurn = !whosTurn;
            clickedButton.Enabled = false;

           if(turn_Count == MAX_TURN_COUNT)
            {
                tieLabel.Show();
                playAgainButton.Show();
            }
        }

        public void hideTie()
        {
            tieLabel.Hide();
            playAgainButton.Hide();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            resetGame();
            hideTie();
        }

        public void resetGame()
        {
            turn_Count = 0;
            whosTurn = false;
            clearButtons();
        }

        public void clearButtons()
        {
            A1Button.Text = String.Empty;
            A2Button.Text = String.Empty;
            A3Button.Text = String.Empty;
            B1Button.Text = String.Empty;
            B2Button.Text = String.Empty;
            B3Button.Text = String.Empty;
            C1Button.Text = String.Empty;
            C2Button.Text = String.Empty;
            C3Button.Text = String.Empty;
            A1Button.Enabled = true;
            A2Button.Enabled = true;
            A3Button.Enabled = true;
            B1Button.Enabled = true;
            B2Button.Enabled = true;
            B3Button.Enabled = true;
            C1Button.Enabled = true;
            C2Button.Enabled = true;
            C3Button.Enabled = true;
        }
    }
}
