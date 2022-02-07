using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public string cros = "X";
        public string zero = "0";
        public int moveOfCroses = 0;
        public int moveOfZeros = 0;
        public int countOfCroses = 0;
        public int countOfZeros = 0;
        public Button[] buttonArray = new Button[9];

        public void Clicks(object sender, string xOrO)
        {
            for (int i = 0; i < buttonArray.Length; i++)
            {
                if(sender == buttonArray[i])
                {
                    buttonArray[i].Text = xOrO;
                    buttonArray[i].Enabled = false;
                    break;
                }
            }
        }

        public void PlayerMove(object sender)
        {
            string move = "";
            int counter = 2;
            if(moveOfCroses >= moveOfZeros)
            {
                move = cros;
                moveOfCroses++;
                moveOfZeros += counter;
                countOfCroses++;
            }
            else
            {
                move = zero;
                moveOfZeros++;
                moveOfCroses += counter;
                countOfZeros++;
            }
            Clicks(sender, move);

        }

        public void Restart()
        {
            moveOfCroses = 0;
            moveOfZeros = 0;
            countOfCroses = 0;
            countOfZeros = 0;
            for (int i = 0; i < buttonArray.Length; i++)
            {
                    buttonArray[i].Text = "";
                    buttonArray[i].Enabled = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
            buttonArray[0] = buttonField1;
            buttonArray[1] = buttonField2;
            buttonArray[2] = buttonField3;
            buttonArray[3] = buttonField4;
            buttonArray[4] = buttonField5;
            buttonArray[5] = buttonField6;
            buttonArray[6] = buttonField7;
            buttonArray[7] = buttonField8;
            buttonArray[8] = buttonField9;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            PlayerMove(sender);
            if ((buttonArray[0].Text == cros && buttonArray[1].Text == cros && buttonArray[2].Text == cros)
                || (buttonArray[3].Text == cros && buttonArray[4].Text == cros && buttonArray[5].Text == cros)
                || (buttonArray[6].Text == cros && buttonArray[7].Text == cros && buttonArray[8].Text == cros)
                || (buttonArray[0].Text == cros && buttonArray[4].Text == cros && buttonArray[8].Text == cros)
                || (buttonArray[2].Text == cros && buttonArray[4].Text == cros && buttonArray[6].Text == cros))
            {
                MessageBox.Show("Player X Wins!!!");
                Restart();
            }
            else if ((buttonArray[0].Text == zero && buttonArray[1].Text == zero && buttonArray[2].Text == zero)
                || (buttonArray[3].Text == zero && buttonArray[4].Text == zero && buttonArray[5].Text == zero)
                || (buttonArray[6].Text == zero && buttonArray[7].Text == zero && buttonArray[8].Text == zero)
                || (buttonArray[0].Text == zero && buttonArray[4].Text == zero && buttonArray[8].Text == zero)
                || (buttonArray[2].Text == zero && buttonArray[4].Text == zero && buttonArray[6].Text == zero))
            {
                MessageBox.Show("Player 0 Wins!!!");
                Restart();
            }
            else if(buttonArray[0].Text != "" && buttonArray[1].Text != "" && buttonArray[2].Text != ""
                && buttonArray[3].Text != "" && buttonArray[4].Text != "" && buttonArray[5].Text != ""
                && buttonArray[6].Text != "" && buttonArray[7].Text != "" && buttonArray[8].Text != "")
            {
                MessageBox.Show("Draw!!!");
                Restart();
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you really don't know how to play this?");
        }
    }
}
