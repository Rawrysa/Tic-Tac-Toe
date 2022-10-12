using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private static int count = 0;
        private static string player1 = "X";
        private static string player2 = "O";
        private string thisplayer;

        public Form1()
        {
            InitializeComponent();
            Text = "Tic Tac Toe";
        }

        private string CurrentPlayer()
        {
            if (count % 2 == 0)
            {
                count++;
                label1.Text = "Second Players Turn";
                thisplayer = player1;
                return player1;
            } 
            else
            {
                count++;
                label1.Text = "First Players Turn";
                thisplayer = player2;
                return player2;
            }
        } 

        private void CheckWinner()
        {
            if (txtBox1.Text == thisplayer && txtBox5.Text == thisplayer && txtBox9.Text == thisplayer)
            {
                MessageBox.Show("You're the Winner");
            }
            if(txtBox3.Text == thisplayer && txtBox5.Text == thisplayer && txtBox7.Text == thisplayer)
            {
                MessageBox.Show("You're the Winner");
            }
            if (txtBox1.Text == thisplayer && txtBox2.Text == thisplayer && txtBox3.Text == thisplayer)
            {
                MessageBox.Show("You're the Winner");
            }
            if (txtBox4.Text == thisplayer && txtBox5.Text == thisplayer && txtBox6.Text == thisplayer)
            {
                MessageBox.Show("You're the Winner");
            }
            if (txtBox7.Text == thisplayer && txtBox8.Text == thisplayer && txtBox9.Text == thisplayer)
            {
                MessageBox.Show("You're the Winner");
            }
            if (txtBox1.Text == thisplayer && txtBox4.Text == thisplayer && txtBox7.Text == thisplayer)
            {
                MessageBox.Show("You're the Winner");
            }
            if (txtBox2.Text == thisplayer && txtBox5.Text == thisplayer && txtBox8.Text == thisplayer)
            {
                MessageBox.Show("You're the Winner");
            }
            if (txtBox3.Text == thisplayer && txtBox6.Text == thisplayer && txtBox9.Text == thisplayer)
            {
                MessageBox.Show("You're the Winner");
            }
        }

        private void BoxClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(sender.GetType().GetProperty("Text").GetValue(sender).ToString()))
            {
                sender.GetType().GetProperty("Text").SetValue(sender, CurrentPlayer());
                CheckWinner();
            }
            else
            {
                MessageBox.Show("Pick another spot");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
