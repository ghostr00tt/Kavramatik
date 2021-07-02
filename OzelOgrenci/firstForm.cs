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
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
           
        }
        public static string userType;

        private void app1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADDstudent f2 = new ADDstudent();
            f2.Show();
            //this.Hide();

            this.Visible = false;
            //signin.ActiveForm
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADDtutor f3 = new ADDtutor();
            f3.Show();
            this.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userType = "Student";
            ADDstudent f2 = new ADDstudent();
            f2.Show();
            //this.Hide();

            this.Visible = false;
            //signin.ActiveForm
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            userType = "Tutor";
            ADDstudent f2 = new ADDstudent();
            f2.Show();
            //this.Hide();

            this.Visible = false;
            //signin.ActiveForm
        }
    }
}
