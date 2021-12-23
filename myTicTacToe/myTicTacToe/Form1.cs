using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myTicTacToe
{
    public partial class Form1 : Form
    {
        String[] boardGame = new string[9];
        int currentTurn = 0;

        public String returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        public System.Drawing.Color determineColor(String symbol)
        {
            if (symbol.Equals("O"))
            {
                return System.Drawing.Color.Pink;
            }
            else if (symbol.Equals("X"))
            {
                return System.Drawing.Color.HotPink;
            }
            return System.Drawing.Color.White;
        }

        public void checkWinner()
        {
            for(int i=0; i<8; i++)
            {
                String combination = "";
                int one = 0, two = 0, three = 0;

                switch (i)
                {
                    case 0:
                        combination = boardGame[2] + boardGame[5] + boardGame[8];
                        one = 2;
                        two = 5;
                        three = 8;
                        break;
                    case 1:
                        combination = boardGame[0] + boardGame[4] + boardGame[8];
                        one = 0;
                        two = 4;
                        three = 8;
                        break;
                    case 2:
                        combination = boardGame[2] + boardGame[4] + boardGame[6];
                        one = 2;
                        two = 4;
                        three = 6;
                        break;
                    case 3:
                        combination = boardGame[0] + boardGame[1] + boardGame[2];
                        one = 0;
                        two = 1;
                        three = 2;
                        break;
                    case 4:
                        combination = boardGame[3] + boardGame[4] + boardGame[5];
                        one = 3;
                        two = 4;
                        three = 5;
                        break;
                    case 5:
                        combination = boardGame[6] + boardGame[7] + boardGame[8];
                        one = 6;
                        two = 7;
                        three = 8;
                        break;
                    case 6:
                        combination = boardGame[0] + boardGame[3] + boardGame[6];
                        one = 0;
                        two = 3;
                        three = 6;
                        break;
                    case 7:
                        combination = boardGame[1] + boardGame[4] + boardGame[7];
                        one = 1;
                        two = 4;
                        three = 7;
                        break;

                }

                if(combination.Equals("OOO"))
                {
                    changeColor(one);
                    changeColor(two);
                    changeColor(three);

                    MessageBox.Show("O has Won the Game!", "We have a Winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(combination.Equals("XXX"))
                {
                    changeColor(one);
                    changeColor(two);
                    changeColor(three);

                    MessageBox.Show("X has Won the Game!", "We have a Winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                checkDraw();

            }
        }


        public void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor = System.Drawing.Color.Transparent;
            button2.BackColor = System.Drawing.Color.Transparent;
            button3.BackColor = System.Drawing.Color.Transparent;
            button4.BackColor = System.Drawing.Color.Transparent;
            button5.BackColor = System.Drawing.Color.Transparent;
            button6.BackColor = System.Drawing.Color.Transparent;
            button7.BackColor = System.Drawing.Color.Transparent;
            button8.BackColor = System.Drawing.Color.Transparent;
            button9.BackColor = System.Drawing.Color.Transparent;
            boardGame = new string[9];
            currentTurn = 0;
        }

        public void changeColor(int number)
        {
            switch (number)
            {
                case 0:
                    button1.BackColor = System.Drawing.Color.Red;
                    break;
                case 1:
                    button2.BackColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    button3.BackColor = System.Drawing.Color.Red;
                    break;
                case 3:
                    button4.BackColor = System.Drawing.Color.Red;
                    break;
                case 4:
                    button5.BackColor = System.Drawing.Color.Red;
                    break;
                case 5:
                    button6.BackColor = System.Drawing.Color.Red;
                    break;
                case 6:
                    button7.BackColor = System.Drawing.Color.Red;
                    break;
                case 7:
                    button8.BackColor = System.Drawing.Color.Red;
                    break;
                case 8:
                    button9.BackColor = System.Drawing.Color.Red;
                    break;
            }
        }

        public void checkDraw()
        {
            int counter = 0;
            for(int i=0; i<boardGame.Length; i++)
            {
                if(boardGame[i] != null) { counter++; }

                if (counter == 9)
                {
                    reset();
                    MessageBox.Show("Draw!", "No Winner!:(", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[0] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(boardGame[0]);
            button1.BackColor = buttonColor;
            button1.Text = boardGame[0];
            checkWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[1] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(boardGame[1]);
            button2.BackColor = buttonColor;
            button2.Text = boardGame[1];
            checkWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[2] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(boardGame[2]);
            button3.BackColor = buttonColor;
            button3.Text = boardGame[2];
            checkWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[3] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(boardGame[3]);
            button4.BackColor = buttonColor;
            button4.Text = boardGame[3];
            checkWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[4] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(boardGame[4]);
            button5.BackColor = buttonColor;
            button5.Text = boardGame[4];
            checkWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[5] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(boardGame[5]);
            button6.BackColor = buttonColor;
            button6.Text = boardGame[5];
            checkWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[6] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(boardGame[6]);
            button7.BackColor = buttonColor;
            button7.Text = boardGame[6];
            checkWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[7] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(boardGame[7]);
            button8.BackColor = buttonColor;
            button8.Text = boardGame[7];
            checkWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[8] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(boardGame[8]);
            button9.BackColor = buttonColor;
            button9.Text = boardGame[8];
            checkWinner();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
