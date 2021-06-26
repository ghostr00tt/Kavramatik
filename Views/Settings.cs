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
    public partial class Settings : Form
    {

        public string userMail;
        public Settings()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Education education = new Education();
            education.lblUsername.Text = userMail;
            if (checkBox2.Checked== true)
            {
                education.display = "single";
            }
            else
            {
                education.display = "multiple";
            }
            education.Show();
            this.Hide();
        }
    }
}
