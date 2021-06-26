using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  
using System.Web;  
using Newtonsoft.Json.Linq;  
using System.Text.RegularExpressions;  
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.IO;
using System.Windows;
using Newtonsoft.Json;
using System.Net.NetworkInformation;

namespace Kavramatik.cs
{

    public partial class LoginAlternative : Form
    {

        public LoginAlternative()
        {
            InitializeComponent();
        }

        String login = String.Format("http://kavramatik.com/api/login");
        String register = String.Format("http://kavramatik.com/api/register");
        String updateScore = String.Format("http://kavramatik.com/api/setScore");
        String formatPassword = String.Format("http://kavramatik.com/api/formatPassword");

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
        string rslt;
        async private void btnlogSt_Click(object sender, EventArgs e)
        {

            String mail = txtUsername.Text.ToString();
            String pssw = txtPassword.Text.ToString();

            Ping ping = new Ping();
            PingReply pingDurumu = ping.Send(IPAddress.Parse("178.233.140.110"));
            if (pingDurumu.Status == IPStatus.Success)
            {
                var values = new Dictionary<String, String>
            {
                {"user_email",mail },
                { "user_password",pssw}
            };
                var data = new FormUrlEncodedContent(values);
                var client = new HttpClient();
                var response = await client.PostAsync(login, data);
                var result = response.Content.ReadAsStringAsync().Result;

                var sonuc = result.IndexOf("true");
                if (sonuc != -1)
                {
                    ChoosingScreen choosingScreen = new ChoosingScreen();
                    choosingScreen.textBox1.Text = txtUsername.Text;
                    Properties.Settings.Default.userMail = this.txtUsername.Text;

                    choosingScreen.Show();
                    this.Hide();
                }

                else
                {
                    label5.Text = "E-posta veya şifre hatalı";
                }
            }
            else
            {
                label5.Text = "Aktif internet bağlantısı bulunmamaktadır, lütfen internet bağlantınızı kontrol ediniz";
            }
          


          

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //if (txtUsername.Text.ToString().Trim() != "" && txtPassword.Text.ToString().Trim() != "")
            //{
            //    using (var client = new HttpClient())
            //    {
            //        client.BaseAddress = new Uri("http://kavramatik.com/");
            //        LoginClass lgn = new LoginClass { userMail = txtUsername.Text.ToString(), userPassword = txtPassword.Text.ToString() };
            //        var response = client.PostAsJsonAsync("api/login", lgn).Result;
            //        var a = response.Content.ReadAsStringAsync();

            //        System.Windows.MessageBox.Show(response.StatusCode.ToString());
            //        System.Windows.MessageBox.Show(response.IsSuccessStatusCode.ToString());
            //        System.Windows.MessageBox.Show(a.Result.ToString());



            //        if (a.Result.ToString().Trim() == "1")
            //        {
            //            lblErrorMessage.Text = "Loggedin successfully.";
            //            lblErrorMessage.ForeColor = Color.Green;

            //        }
            //        else
            //        {


            //            lblErrorMessage.Text = "Invalid login credentials.";
            //            lblErrorMessage.ForeColor = Color.Red;
            //        }
            //    }
            //}
            //else if (txtUsername.Text.ToString().Trim() == "" && txtPassword.Text.ToString().Trim() == "")
            //{
            //    //errorProvider1.SetError(txtUsername, "Please enter the email");
            //    //errorProvider1.SetError(txtPassword, "Please enter the password");
            //}
            //else if (txtUsername.Text.ToString().Trim() == "")
            //{
            //    //errorProvider1.SetError(txtUsername, "Please enter the email");
            //}
            //else if (txtPassword.Text.ToString().Trim() == "")
            //{
            //    //errorProvider1.SetError(txtPassword, "Please enter the password");
            //} 

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ChoosingScreen choosingScreen = new ChoosingScreen();
            choosingScreen.anonym = "true";
            choosingScreen.Show();
            this.Hide();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}








//if (txtUsername.Text.ToString().Trim() != "" && txtPassword.Text.ToString().Trim() != "")
//{
//    using (var client = new HttpClient())
//    {
//        client.BaseAddress = new Uri("http://kavramatik.com/");
//        LoginClass lgn = new LoginClass { userMail = txtUsername.Text.ToString(), userPassword= txtPassword.Text.ToString() };
//        var response = client.PostAsJsonAsync("api/Login/Login", lgn).Result;
//        var a = response.Content.ReadAsStringAsync();
//        if (a.Result.ToString().Trim() == "1")
//        {
//            lblErrorMessage.Text = "Loggedin successfully.";
//            lblErrorMessage.ForeColor = Color.Green;

//        }
//        else
//        {


//            lblErrorMessage.Text = "Invalid login credentials.";
//            lblErrorMessage.ForeColor = Color.Red;
//        }
//    }
//}
//else if (txtUsername.Text.ToString().Trim() == "" && txtPassword.Text.ToString().Trim() == "")
//{
//    //errorProvider1.SetError(txtUsername, "Please enter the email");
//    //errorProvider1.SetError(txtPassword, "Please enter the password");
//}
//else if (txtUsername.Text.ToString().Trim() == "")
//{
//    //errorProvider1.SetError(txtUsername, "Please enter the email");
//}
//else if (txtPassword.Text.ToString().Trim() == "")
//{
//    //errorProvider1.SetError(txtPassword, "Please enter the password");
//}


///////////////////////////////////////////////////////////////////////////////////////////


//l.username = txtUserS.Text.Trim();
//l.password = txtPwS.Text.Trim();


//bool success = dal.loginCheck(l);
//if (success == true)
//{
//    MessageBox mb = new MessageBox("Giriş Başarılı", Kavramatik.cs.MessageBox.MsgType.success);



//        tutorScreen admin = new tutorScreen();
//        admin.Show();
//        this.Hide();


//}
//else
//{
//    MessageBox mb = new MessageBox("Hatalı Giriş,Tekrar Deneyiniz", Kavramatik.cs.MessageBox.MsgType.retry);
//    mb.Show();
//    txtUserS.Text = "";
//    txtPwS.Text = "";
// MessageBox.Show("Login Fail !!!....Try Again");

//////////////////////////////////////////////////////////////////////////

//string token = "?token_id=464685648465A468464qw8A544688648W6REEWT6V";
//string userMail = txtUsername.Text.ToString();
//string userPassword = txtPassword.Text.ToString();

//// Create a request using a URL that can receive a post. 
//HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://kavramatik.com/api/login");
//// Set the Method property of the request to POST.
//request.Method = "POST";
//request.Credentials = CredentialCache.DefaultCredentials;
//((HttpWebRequest)request).UserAgent = "Mozilla/4.0 (compatible; MSIE 5.01; Windows NT 5.0)";
//// Create POST data and convert it to a byte array.
//string postData = "token=" + token +
//    "&userMail=" + userMail +
//    "&userPassword=" + userPassword;
//byte[] byteArray = Encoding.UTF8.GetBytes(postData);
//// Set the ContentType property of the WebRequest.
//request.ContentType = "application/json; charset=utf-8";
//// Set the ContentLength property of the WebRequest.
//request.ContentLength = byteArray.Length;
//// Get the request stream.
//Stream dataStream = request.GetRequestStream();
//// Write the data to the request stream.
//dataStream.Write(byteArray, 0, byteArray.Length);
//// Close the Stream object.
//dataStream.Close();
//// Get the response.
//WebResponse response = request.GetResponse();
//// Display the status.
//System.Windows.MessageBox.Show(((HttpWebResponse)response).StatusDescription);
//// Get the stream containing content returned by the server.
//dataStream = response.GetResponseStream();
//// Open the stream using a StreamReader for easy access.
//StreamReader reader = new StreamReader(dataStream);
//// Read the content.
//string responseFromServer = reader.ReadToEnd();
//// Display the content.
//System.Windows.MessageBox.Show(responseFromServer);
//// Clean up the streams.
//reader.Close();
//dataStream.Close();
//response.Close();