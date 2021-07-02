using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kavramatik.cs
{
    public partial class Games : Form
    {

        public string userMail;
        public Games()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        
        }

        private void Games_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameDraw f4 = new GameDraw();
            f4.label2.Text = this.label2.Text;
            f4.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameTrueFalse gametf = new GameTrueFalse();
            gametf.label2.Text = this.label2.Text;
            gametf.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GameColorMatch gamecm = new GameColorMatch();
            gamecm.label2.Text = this.label2.Text;
            gamecm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Education education = new Education();
            education.lblUsername.Text = this.label2.Text;
            education.Show();
            this.Hide();
        }
    }
}
