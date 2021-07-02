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
    public partial class ADDstudent : Form
    {
        public ADDstudent()
        {
            InitializeComponent();
            this.BackColor = Color.White;
       
        }
        public static string userType;
        FirstForm ff = new FirstForm();
        userBLL u = new userBLL();
        userDAL dal = new userDAL();
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Yellow, 0, 0, 100, 100);
        }
        private void labelStudentLog_Click(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Login f4 = new Login();
            f4.Show();
            this.Visible = false;
        }

        private void signin_Load(object sender, EventArgs e)
        {
            if (FirstForm.userType == "Student") {
                lblUserType.Text = "Student";
            }
            else if (FirstForm.userType == "Tutor") {
                lblUserType.Text = "Tutor";
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Login f4 = new Login();
            f4.Show();
            this.Visible = false;

        }
        private void clear()
        {
            u.fullname = txtFullName.Text;
            u.address = txtAddress.Text;
            u.parentName = txtParentName.Text;
            u.tell = txtTel.Text;
            u.username = txtusername.Text;
            u.password = txtpassword.Text;

            txtFullName.Text = "";
            txtAddress.Text = "";
            txtParentName.Text = "";
            txtTel.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
            txtrepassword.Text = "";


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (lblUserType.Text == "Student") {
                userType = "Student";
            }
            else if (lblUserType.Text == "Tutor")
            {
                userType = "Tutor";
            }
            if (txtpassword.Text == txtrepassword.Text)
            {
                u.fullname = txtFullName.Text;
                u.address = txtAddress.Text;
                u.dob = dateTimePicker1.Value;
                u.parentName = txtParentName.Text;
                u.tell = txtTel.Text;
                u.username = txtusername.Text;
                u.password = txtpassword.Text;
                u.userType = lblUserType.Text;

                bool success = dal.Insert(u);
                if (success == true)
                {

                    MessageBox mb = new MessageBox("User Added Successfully!!!", sampleframe.cs.MessageBox.MsgType.success);
                    mb.Show();
                    clear();
                    Login f4 = new Login();
                    f4.Show();
                    this.Visible = false;

                }
                else
                {
                    MessageBox mb = new MessageBox("Fail to Added!!!", sampleframe.cs.MessageBox.MsgType.retry);
                    mb.Show();
                    
                }
                DataTable dt = dal.Select();
            }
            else {
                MessageBox mb = new MessageBox("Passwords are not matched!!!", sampleframe.cs.MessageBox.MsgType.retry);
                mb.Show();
            }





            
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnT1_Click(object sender, EventArgs e)
        {
            Login f4 = new Login();
            f4.Show();
            this.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblUserType.Text == "Student")
            {
                userType = "Student";
            }
            else if (lblUserType.Text == "Tutor")
            {
                userType = "Tutor";
            }
                    if (txtpassword.Text == txtrepassword.Text)
                    {
                        u.fullname = txtFullName.Text;
                        u.address = txtAddress.Text;
                        u.dob = dateTimePicker1.Value;
                        u.parentName = txtParentName.Text;
                        u.tell = txtTel.Text;
                        u.username = txtusername.Text;
                        u.password = txtpassword.Text;
                        u.userType = lblUserType.Text;

                        bool success = dal.Insert(u);
                        if (txtFullName.Text == "") {
                            MessageBox mb = new MessageBox("Please fill the full name...", sampleframe.cs.MessageBox.MsgType.retry);
                            mb.Show();
                           // MessageBox.Show("Please fill the full name...");
                        }
                        else if (txtAddress.Text == "")
                        {
                            MessageBox mb = new MessageBox("Please fill the address...", sampleframe.cs.MessageBox.MsgType.retry);
                            mb.Show();
                           // MessageBox.Show("Please fill the address...");
                        }
                        else if (txtParentName.Text == "")
                        {
                            MessageBox mb = new MessageBox("Please fill the parent's name...", sampleframe.cs.MessageBox.MsgType.retry);
                            mb.Show();
                           // MessageBox.Show("Please fill the parent's name...");
                        }
                        else if (txtTel.Text == "")
                        {
                            MessageBox mb = new MessageBox("Please fill the telephone number...", sampleframe.cs.MessageBox.MsgType.retry);
                            mb.Show();
                            //MessageBox.Show("Please fill the telephone number...");
                        }
                        else if (txtusername.Text == "")
                        {
                            MessageBox mb = new MessageBox("Please fill the Username...", sampleframe.cs.MessageBox.MsgType.retry);
                            mb.Show();
                           // MessageBox.Show("Please fill the Username...");
                        }
                        else if (txtpassword.Text == "")
                        {
                            MessageBox mb = new MessageBox("Please fill the password...", sampleframe.cs.MessageBox.MsgType.retry);
                            mb.Show();
                           // MessageBox.Show("Please fill the password...");
                        }
                        else if (txtrepassword.Text == "")
                        {
                            MessageBox mb = new MessageBox("Please fill the re-enter password field...", sampleframe.cs.MessageBox.MsgType.retry);
                            mb.Show();
                            //MessageBox.Show("Please fill the re-enter password field...");
                        }
                        else {
                            if (success == true)
                            {
                                MessageBox mb = new MessageBox("User Added Successfully!!!", sampleframe.cs.MessageBox.MsgType.success);
                                
                                //MessageBox.Show("User Added Successfully!!!");
                                clear();
                                Login f4 = new Login();
                                f4.Show();
                                this.Visible = false;
                                mb.Show();

                            }
                            else
                            {
                                MessageBox mb = new MessageBox("Fail to Added!!!", sampleframe.cs.MessageBox.MsgType.retry);
                                mb.Show();
                               // MessageBox.Show("Fail to Added!!!");
                            }
                            DataTable dt = dal.Select();
                        }
                        }

                               
                    else
                    {
                        MessageBox mb = new MessageBox("Passwords are not matched!!!", sampleframe.cs.MessageBox.MsgType.retry);
                        mb.Show();
                    }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUserType_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
