using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kavramatik.cs
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            txtPassword.Hide();
            txtPasswordAgain.Hide();
            txtVerificationCode.Hide();

        }
        String formatPassword = String.Format("http://kavramatik.com/api/formatPassword");
        private void btnlogSt_Click(object sender, EventArgs e)
        {
            String mail = txtUsermail.Text.ToString();
            String sendMailForPassword = String.Format("http://kavramatik.com/api/sendMailForPassword?user_email=" + mail);
            var request = WebRequest.Create(sendMailForPassword);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
       
            btnlogSt.Hide();
            label3.Show();
            label4.Show();
            label5.Show();
            txtPassword.Show();
            txtUsermail.Show();
            txtPasswordAgain.Show();
            txtVerificationCode.Show();

        }

        private void txtUsermail_OnValueChanged(object sender, EventArgs e)
        {

        }

        async private void btnGonder_Click(object sender, EventArgs e)
        {

            String mail = txtUsermail.Text.ToString();
            String code = txtVerificationCode.Text.ToString();
            String password = txtPassword.Text.ToString();
            String passwordConfirm = txtPasswordAgain.Text.ToString();

            if (password.Trim() == passwordConfirm.Trim())
            {
                var values = new Dictionary<String, String>
                    {
                        {"user_email",mail },
                        { "user_password",passwordConfirm},
                        {"verification",code }
                    };
                var data = new FormUrlEncodedContent(values);
                var client = new HttpClient();
                var response = await client.PostAsync(formatPassword, data);
                var result = response.Content.ReadAsStringAsync().Result;
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginAlternative login = new LoginAlternative();
            login.Show();
            this.Hide();

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
