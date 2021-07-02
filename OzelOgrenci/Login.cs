using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sampleframe.cs.BLL;
using sampleframe.cs.DLL;

namespace sampleframe.cs
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }
        logBLL l = new logBLL();
        DLLLog1 dal = new DLLLog1();
        userBLL ubll = new userBLL();
        userDAL udal = new userDAL();
        
        public static string loggedIn;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            l.username = txtUserS.Text.Trim();
            l.password = txtPwS.Text.Trim();
           

            bool success = dal.loginCheck(l);
            if (success == true)
            {
                MessageBox mb = new MessageBox("Login Successfully", sampleframe.cs.MessageBox.MsgType.success);
                mb.Show();
                //MessageBox.Show("Login Successfully");
                tutorScreen admin = new tutorScreen();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox mb = new MessageBox("Login Fail !!!....Try Again", sampleframe.cs.MessageBox.MsgType.retry);
                mb.Show();
                //MessageBox.Show("Login Fail !!!....Try Again");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnlogSt_Click(object sender, EventArgs e)
        {
           l.username = txtUserS.Text.Trim();
           l.password = txtPwS.Text.Trim();


            bool success = dal.loginCheck(l);
            if (success == true)
            {
                MessageBox mb = new MessageBox("Login Successfully...", sampleframe.cs.MessageBox.MsgType.success);


                if (lblUserType.Text == "Student")
                {
                    stUI ff = new stUI();
                    ff.Show();
                    this.Hide();
                    mb.Show();
                }
                else if (lblUserType.Text == "Tutor")
                {
                    tutorScreen admin = new tutorScreen();
                    admin.Show();
                    this.Hide();
                }
                
            }
            else
            {
                MessageBox mb = new MessageBox("Login Fail !!!....Try Again", sampleframe.cs.MessageBox.MsgType.retry);
                mb.Show();
                txtUserS.Text = "";
                txtPwS.Text = "";
               // MessageBox.Show("Login Fail !!!....Try Again");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (FirstForm.userType == "Student")
            {
                lblUserType.Text = "Student";
            }
            else if (FirstForm.userType == "Tutor")
            {
                lblUserType.Text = "Tutor";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUserType_Click(object sender, EventArgs e)
        {

        }
    }
}
