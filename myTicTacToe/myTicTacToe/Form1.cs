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

        public void checkWinner()
        {
            for(int i=0; i<8; i++)
            {
                String combination = "";

                switch (i)
                {
                    case 0:
                        combination = boardGame[2] + boardGame[5] + boardGame[8];
                        break;
                    case 1:
                        combination = boardGame[0] + boardGame[4] + boardGame[8];
                        break;
                    case 2:
                        combination = boardGame[2] + boardGame[4] + boardGame[6];
                        break;
                    case 3:
                        combination = boardGame[0] + boardGame[1] + boardGame[2];
                        break;
                    case 4:
                        combination = boardGame[3] + boardGame[4] + boardGame[5];
                        break;
                    case 5:
                        combination = boardGame[6] + boardGame[7] + boardGame[8];
                        break;
                    case 6:
                        combination = boardGame[0] + boardGame[3] + boardGame[6];
                        break;
                    case 7:
                        combination = boardGame[1] + boardGame[4] + boardGame[7];
                        break;

                }

                if(combination.Equals("OOO"))
                {
                    reset();
                    MessageBox.Show("O has Won the Game!", "We have a Winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(combination.Equals("XXX"))
                {
                    reset();
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
            boardGame = new string[9];
            currentTurn = 0;
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
            button1.Text = boardGame[0];
            checkWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[1] = returnSymbol(currentTurn);
            button2.Text = boardGame[1];
            checkWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[2] = returnSymbol(currentTurn);
            button3.Text = boardGame[2];
            checkWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[3] = returnSymbol(currentTurn);
            button4.Text = boardGame[3];
            checkWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[4] = returnSymbol(currentTurn);
            button5.Text = boardGame[4];
            checkWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[5] = returnSymbol(currentTurn);
            button6.Text = boardGame[5];
            checkWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[6] = returnSymbol(currentTurn);
            button7.Text = boardGame[6];
            checkWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[7] = returnSymbol(currentTurn);
            button8.Text = boardGame[7];
            checkWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            boardGame[8] = returnSymbol(currentTurn);
            button9.Text = boardGame[8];
            checkWinner();
        }
    }
}
