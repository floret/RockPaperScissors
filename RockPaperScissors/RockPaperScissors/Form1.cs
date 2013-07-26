using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class frmRPS : Form
    {
        public frmRPS()
        {
            InitializeComponent();
        }

        private void frmRPS_Load(object sender, EventArgs e)
        {

        }
        string P1Selection = "";
        private void cmbPlayerOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlayerOne.SelectedIndex == 0) { P1Selection = "Rock"; }
            else if (cmbPlayerOne.SelectedIndex == 1) { P1Selection = "Paper"; }
            else if (cmbPlayerOne.SelectedIndex == 2) { P1Selection = "Scissors"; }
        }
        string P2Selection = "";
        private void cmbPlayerTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlayerTwo.SelectedIndex == 0) { P2Selection = "Rock"; }
            else if (cmbPlayerTwo.SelectedIndex == 1) { P2Selection = "Paper"; }
            else if (cmbPlayerTwo.SelectedIndex == 2) { P2Selection = "Scissors"; }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (P1Selection == P2Selection) { lvwDisplay.Items.Add("Its a draw!"); }
            //P1 Wins
            if (P1Selection == "Rock" && P2Selection == "Scissors") { lvwDisplay.Items.Add("Player 1 Wins!"); }
            else if (P1Selection == "Paper" && P2Selection == "Rock") { lvwDisplay.Items.Add("Player 1 Wins!"); }
            else if (P1Selection == "Scissors" && P2Selection == "Paper") { lvwDisplay.Items.Add("Player 1 Wins!"); }
            //P2 Wins
            if (P2Selection == "Rock" && P1Selection == "Scissors") { lvwDisplay.Items.Add("Player 2 Wins!"); }
            else if (P2Selection == "Paper" && P1Selection == "Rock") { lvwDisplay.Items.Add("Player 2 Wins!"); }
            else if (P2Selection == "Scissors" && P1Selection == "Paper") { lvwDisplay.Items.Add("Player 2 Wins!"); }
            //
        }

    }
}