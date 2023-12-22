using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        String crosses = "";
        Random rnm= new Random();
        int[] array = new int[9];
        Button[] btn= new Button[9];
        public Form1()
        {
            InitializeComponent();
            if(rnm.Next(1,10)<=5)
            {
                crosses = "Крестики";
                label1.Text = "Ходит Игрок за X";
            }
            else
            {
                crosses = "Нолики";
                label1.Text = "Ходит Игрок за O";
            }
            btn[0] = button1;
            btn[1] = button2;
            btn[2] = button3;
            btn[3] = button4;
            btn[4] = button5;
            btn[5] = button6;
            btn[6] = button7;
            btn[7] = button8;
            btn[8] = button9;
        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < btn.Length; index++)
            {
                array[index] = 0;
                btn[index].Text = "";
                 if(rnm.Next(1,10)<=5)
                {
                    crosses = "Крестики";
                    label1.Text = "Ходит Игрок за X";
                }
                else
                {
                    crosses = "Нолики";
                    label1.Text = "Ходит Игрок за O";
                }
                btn[index].Enabled = true;
                btn[index].BackColor = System.Drawing.Color.White;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( crosses == "Крестики")
            {
                for(int index=0;index<btn.Length; index++)
                {
                    if (sender == btn[index])
                    {
                        btn[index].Text = "X";
                        label1.Text = "Ходит Игрок за O";
                        crosses = "Нолики";
                        btn[index].Enabled = false;
                        array[index] = 1;
                        break;
                    }
                }
            }
            else // для ноликов
            {
                for (int index = 0; index < btn.Length; index++)
                {
                    if (sender == btn[index])
                    {
                        btn[index].Text = "O";
                        label1.Text = "Ходит Игрок за X";
                        crosses = "Крестики";
                        btn[index].Enabled = false;
                        array[index] = 2;
                        break;
                    }
                }
            }



         if (array[0]==1 && array[1] == 1 && array[2] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[1].BackColor = System.Drawing.Color.Green;
                btn[2].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за Х";
            }
         else if (array[3] == 1 && array[4] == 1 && array[5] == 1)
            {
                btn[3].BackColor = System.Drawing.Color.Green;
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за Х";
            }
         else if (array[6] == 1 && array[7] == 1 && array[8] == 1)
            {
                btn[6].BackColor = System.Drawing.Color.Green;
                btn[7].BackColor = System.Drawing.Color.Green;
                btn[8].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за Х";
            }
         else if (array[0] == 1 && array[4] == 1 && array[8] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[8].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за Х";
            }
         else if (array[2] == 1 && array[4] == 1 && array[6] == 1)
            {
                btn[2].BackColor = System.Drawing.Color.Green;
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за Х";
            }
         else if (array[0] == 1 && array[3] == 1 && array[6] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[3].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за Х";
            }
         else if (array[1] == 1 && array[4] == 1 && array[7] == 1)
            {
                btn[1].BackColor = System.Drawing.Color.Green;
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[7].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за Х";
            }
         else if (array[2] == 1 && array[5] == 1 && array[8] == 1)
            {
                btn[2].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[8].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за Х";
            }

            //Для ноликов



            if (array[0] == 2 && array[1] == 2 && array[2] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[1].BackColor = System.Drawing.Color.Green;
                btn[2].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за О";
            }
            else if (array[3] == 2 && array[4] == 2 && array[5] == 2)
            {
                btn[3].BackColor = System.Drawing.Color.Green;
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за О";
            }
            else if (array[6] == 2 && array[7] == 2 && array[8] == 2)
            {
                btn[6].BackColor = System.Drawing.Color.Green;
                btn[7].BackColor = System.Drawing.Color.Green;
                btn[8].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за О";
            }
            else if (array[0] == 2 && array[4] == 2 && array[8] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[8].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за О";
            }
            else if (array[2] == 2 && array[4] == 2 && array[6] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Green;
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за О";
            }
            else if (array[0] == 2 && array[3] == 2 && array[6] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[3].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за О";
            }
            else if (array[1] == 2 && array[4] == 2 && array[7] == 2)
            {
                btn[1].BackColor = System.Drawing.Color.Green;
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[7].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за О";
            }
            else if (array[2] == 2 && array[5] == 2 && array[8] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[8].BackColor = System.Drawing.Color.Green;
                for (int index = 0; index < btn.Length; index++)
                {
                    btn[index].Enabled = false;
                }
                btnNewGame.Enabled = true;
                label1.Text = "Выйграл игрок за О";
            }
        }
    
    }
}
