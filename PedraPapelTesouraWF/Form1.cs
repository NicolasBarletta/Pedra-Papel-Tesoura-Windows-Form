using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedraPapelTesouraWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

   


        private void button4_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int pc = r.Next(0, 3);

            if (pc == 0)
            {
                label8.Text = ("PEDRA");
                label9.Text = ("PEDRA");
                label11.Text = ("EMPATE!");

            }
            else if (pc == 1)
            {
                label8.Text = ("PEDRA");
                label9.Text = ("PAPEL");
                label11.Text = ("DERROTA!");

            }
            else if (pc == 2)
            {
                label8.Text = ("PEDRA");
                label9.Text = ("TESOURA");
                label11.Text = ("VITÓRIA!");

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int pc = r.Next(0, 3);

            if (pc == 0)
            {
                label8.Text = ("PAPEL");
                label9.Text = ("PEDRA");
                
                label11.Text = ("VITÓRIA!");
                
            }
            else if (pc == 1)
            {
                label8.Text = ("PAPEL");
                label9.Text = ("PAPEL");
                label11.Text = ("EMPATE!");

            }
            else if (pc == 2)
            {
                label8.Text = ("PAPEL");
                label9.Text = ("TESOURA");
                label11.Text = ("DERROTA!");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int pc = r.Next(0, 3);

            if (pc == 0)
            {
                label8.Text = ("TESOURA");
                label9.Text = ("PEDRA");
                label11.Text = ("DERROTA!");

            }
            else if (pc == 1)
            {
                label8.Text = ("TESOURA");
                label9.Text = ("PAPEL");
                label11.Text = ("VITÓRIA!");

            }
            else if (pc == 2)
            {
                label8.Text = ("TESOURA");
                label9.Text = ("TESOURA");
                label11.Text = ("EMPATE!");

            }
        }
    }
    }

