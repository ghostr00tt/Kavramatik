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
    public partial class ChoosingScreen : Form
    {
        public String[] usermail;
        public string password;
        public string anonym = "false";
        public ChoosingScreen()
        {
            InitializeComponent();
        }

        private void ChoosingScreen_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                 Games game = new Games();
            if (anonym == "false")
            {
                game.label2.Text = this.textBox1.Text;
            }
          
                   game.Show();
                 this.Hide();

        }

        private void buttonEducation_Click(object sender, EventArgs e)
        {
            Education education = new Education();
            if(anonym == "false")
            {
                education.lblUsername.Text = textBox1.Text;
            }
            else
            {
                education.anonym = "true";
            }
          
            
            education.Show();
            this.Hide();
        }
        

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
