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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Flags
        int _1Rock, _1Paper, _1Scissors = 0;
        int _2Rock, _2Paper, _2Scissors = 0;
        int _3Rock, _3Paper, _3Scissors = 0;
        int _4Rock, _4Paper, _4Scissors = 0;
        int _5Rock, _5Paper, _5Scissors = 0;
        int _6Rock, _6Paper, _6Scissors = 0;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1) { _1Rock = 1; }
            if (comboBox1.SelectedIndex == 2) { _1Paper = 1; }
            if (comboBox1.SelectedIndex == 3) { _1Scissors = 1; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1) { _2Rock = 1; }
            if (comboBox2.SelectedIndex == 2) { _2Paper = 1; }
            if (comboBox2.SelectedIndex == 3) { _2Scissors = 1; }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 1) { _3Rock = 1; }
            if (comboBox3.SelectedIndex == 2) { _3Paper = 1; }
            if (comboBox3.SelectedIndex == 3) { _3Scissors = 1; }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 1) { _4Rock = 1; }
            if (comboBox4.SelectedIndex == 2) { _4Paper = 1; }
            if (comboBox4.SelectedIndex == 3) { _4Scissors = 1; }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 1) { _5Rock = 1; }
            if (comboBox5.SelectedIndex == 2) { _5Paper = 1; }
            if (comboBox5.SelectedIndex == 3) { _5Scissors = 1; }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == 1) { _6Rock = 1; }
            if (comboBox6.SelectedIndex == 2) { _6Paper = 1; }
            if (comboBox6.SelectedIndex == 3) { _6Scissors = 1; }
        }
    }
}
//comboBox1.SelectedIndex++;//selects next item.
//comboBox1.SelectedIndex(0);//rock 1 paper 2 scissors.