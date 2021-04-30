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
  
    public partial class LoginAlternative : Form
    {
       
        public LoginAlternative()
        {
            InitializeComponent();
        }
        logBLL l = new logBLL();
        DLLLog1 dal = new DLLLog1();
        userBLL ubll = new userBLL();
        userDAL udal = new userDAL();

        private void LoginAlternative_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserS_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnlogSt_Click(object sender, EventArgs e)
        {

            l.username = txtUserS.Text.Trim();
            l.password = txtPwS.Text.Trim();
           

            bool success = dal.loginCheck(l);
            if (success == true)
            {
                MessageBox mb = new MessageBox("Giriş Başarılı", sampleframe.cs.MessageBox.MsgType.success);


               
                    tutorScreen admin = new tutorScreen();
                    admin.Show();
                    this.Hide();
               

            }
            else
            {
                MessageBox mb = new MessageBox("Hatalı Giriş,Tekrar Deneyiniz", sampleframe.cs.MessageBox.MsgType.retry);
                mb.Show();
                txtUserS.Text = "";
                txtPwS.Text = "";
                // MessageBox.Show("Login Fail !!!....Try Again");
            }
        }
    }
}
