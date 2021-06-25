using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kavramatik.cs
{
    public partial class Register : Form
    {
        String register = String.Format("http://kavramatik.com/api/register");
        String updateScore = String.Format("http://kavramatik.com/api/setScore");
        String formatPassword = String.Format("http://kavramatik.com/api/formatPassword");
        public Register()
        {
            InitializeComponent();
        }

        async private void btnlogSt_Click(object sender, EventArgs e)
        {
            String mail = txtUsermail.Text.ToString();
            String name = txtUserName.Text.ToString();
            String password = txtPassword.Text.ToString();
            String passwordConfirm = txtPasswordAgain.Text.ToString();

            if (password.Trim() == passwordConfirm.Trim())
            {
                var values = new Dictionary<String, String>
                    {
                        {"user_email",mail },
                        { "user_password",passwordConfirm},
                        {"user_name",name }
                    };
                var data = new FormUrlEncodedContent(values);
                var client = new HttpClient();
                var response = await client.PostAsync(register, data);
                var result = response.Content.ReadAsStringAsync().Result;
               
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginAlternative login = new LoginAlternative();
            login.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
