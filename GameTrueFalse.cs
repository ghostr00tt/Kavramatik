using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sampleframe.cs
{
    public partial class GameTrueFalse : Form
    {
       
        GameDraw f3;
        int Score = 0;
        int i;

        public GameTrueFalse(GameDraw f3)
        {
            InitializeComponent();

        }
     
       

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void next_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Score++;
                i++;
                //if(i!=1)
                if (i == 1)
                {
                    this.label1.Text = "Soru 1";

                }
                else if (i == 2)
                {
                    this.label1.Text = "Soru 2";
                }
                else if (i == 3)
                {
                    this.label1.Text = "Soru 3";
                }
                else if (i == 5)
                {
                    this.label1.Text = "Soru 4";
                }

                else
                {

                }
            }

            else if (radioButton2.Checked)
            {


            }

        }
    }
}
