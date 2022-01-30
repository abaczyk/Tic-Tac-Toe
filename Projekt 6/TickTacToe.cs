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
            whosTurnLabel.Hide();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            gamePanel.Show();
            goToMenuButton.Show();
            hideEndLabelAndButton();
            whosTurnLabel.Show();
            whosTurnLabel.Text = "Kolej gracza: Gracz 1";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goToMenuButton_Click(object sender, EventArgs e)
        {
            gamePanel.Hide();
            goToMenuButton.Hide();
            whosTurnLabel.Hide();
            resetGame();
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (whosTurn) //kolej gracza 1
            {
                clickedButton.Text = "X";
                whosTurnLabel.Text = "Kolej gracza: Gracz 1";
            }
            else //kolej gracza 2
            {
                clickedButton.Text = "O";
                whosTurnLabel.Text = "Kolej gracza: Gracz 2";
            }
            turn_Count++;
            whosTurn = !whosTurn;
            clickedButton.Enabled = false;

            if (turn_Count == MAX_TURN_COUNT)
            {
                tieLabel.Show();
                playAgainButton.Show();
            }
            else if (checkForWinner())
            {
                winnerLabel.Show();
                playAgainButton.Show(); 
                disableButtons();
                if (whosTurn)//gracz 1
                    winnerLabel.Text = "Gracz 1 wygrywa!";
                else //gracz 2
                    winnerLabel.Text = "Gracz 2 wygrywa!";
            }
        }

        public void hideEndLabelAndButton()
        {
            tieLabel.Hide();
            winnerLabel.Hide();
            playAgainButton.Hide();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            resetGame();
            hideEndLabelAndButton();
            whosTurnLabel.Text = "Kolej gracza: Gracz 1";
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

        public void disableButtons()
        {
            A1Button.Enabled = false;
            A2Button.Enabled = false;
            A3Button.Enabled = false;
            B1Button.Enabled = false;
            B2Button.Enabled = false;
            B3Button.Enabled = false;
            C1Button.Enabled = false;
            C2Button.Enabled = false;
            C3Button.Enabled = false;
        }

        public bool checkForWinner()
        {
                if ((A1Button.Text == A2Button.Text && A2Button.Text == A3Button.Text && !A1Button.Enabled) ||
                    (B1Button.Text == B2Button.Text && B2Button.Text == B3Button.Text && !B1Button.Enabled) ||
                    (C1Button.Text == C2Button.Text && C2Button.Text == C3Button.Text && !C1Button.Enabled) ||
                    (A1Button.Text == B1Button.Text && B1Button.Text == C1Button.Text && !A1Button.Enabled) ||
                    (A2Button.Text == B2Button.Text && B2Button.Text == C2Button.Text && !A2Button.Enabled) ||
                    (A3Button.Text == B3Button.Text && B3Button.Text == C3Button.Text && !A3Button.Enabled) ||
                    (A1Button.Text == B2Button.Text && B2Button.Text == C3Button.Text && !A1Button.Enabled)||
                    (C1Button.Text == B2Button.Text && B2Button.Text == A3Button.Text && !C1Button.Enabled))
                    return true;
                else
                    return false;

        }
    }
}
