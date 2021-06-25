using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class GameTrueFalse : Form
    {
        private List<numbers> numbers;
        GameDraw f3;
        int Score = 0;
        int i=0;
        

        public GameTrueFalse()
        {
            InitializeComponent();

        }

        async private void getProfileDetails()
        {
            String mail = label2.Text.ToString();

            String showProfile = String.Format("http://kavramatik.com/api/showProfile?user_email=" + mail);
            var request = WebRequest.Create(showProfile);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();

            richTextBox1.Text = data.ToString();



        }

        public string Parse(string veri)
        {
            string cikti = "";

            JObject json = JObject.Parse(veri);
            cikti = json["score"].ToString();

            return cikti;
        }
        private async void GameTrueFalse_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Utils.BASE_URL);
            HttpResponseMessage responseMessage = await client.GetAsync("numbers?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            numbers = JsonConvert.DeserializeObject<List<numbers>>(result);


          
                webBrowser1.Navigate("https://www.bing.com/translator/?from=tr&to=en");
                webBrowser1.ScriptErrorsSuppressed = true;
             
            
          
            label3.Visible = false;
            label4.Visible = false;
            getProfileDetails();
            labelScore.Text =Parse(richTextBox1.Text.ToString());
            pictureBox1.Image = Utils.byteToImg(numbers[12].number_one_image);
            pictureBox2.Image = Utils.byteToImg(numbers[12].number_quantity_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.Text = "Soru - ";
            labelSoru.Text = "Yukarıdaki eşleşme sence doğru mu, yanlış mı ?";

        }


        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void Game1()
        {
            pictureBox1.Image = Utils.byteToImg(numbers[11].number_one_image);
            pictureBox2.Image = Utils.byteToImg(numbers[11].number_quantity_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Game2()
        {
            pictureBox1.Image = Utils.byteToImg(numbers[5].number_one_image);
            pictureBox2.Image = Utils.byteToImg(numbers[6].number_quantity_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void Game3()
        {
            pictureBox1.Image = Utils.byteToImg(numbers[3].number_one_image);
            pictureBox2.Image = Utils.byteToImg(numbers[4].number_quantity_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Game4()
        {
            pictureBox1.Image = Utils.byteToImg(numbers[8].number_one_image);
            pictureBox2.Image = Utils.byteToImg(numbers[8].number_quantity_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Game5()
        {
            pictureBox1.Image = Utils.byteToImg(numbers[1].number_one_image);
            pictureBox2.Image = Utils.byteToImg(numbers[1].number_quantity_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        int dogru = 0;
        int yanlis = 0;
        String updateScore = String.Format("http://kavramatik.com/api/setScore");
        async private void scoreUpdate(int kazanilanSkor)
        {
            String mail = label2.Text.ToString();
            int newScore = kazanilanSkor;

            Score scoreUser = new Score(mail, newScore);


            string json = JsonConvert.SerializeObject(scoreUser);
            var data = new StringContent(json, Encoding.UTF8, "application/json");


            var client = new HttpClient();

            var response = await client.PostAsync(updateScore, data);

            //string result = response.Content.ReadAsStringAsync().Result;
        }

        WebBrowser webBrowser1 = new WebBrowser();
        private void next_Click_1(object sender, EventArgs e)
        {

            if (i == 5)
            {
                next.Enabled = false;
            }
            i++;
          
            if (i==1)
            {
                label1.Text = "Soru - " + (i + 1);
                if (radioButton1.Checked)
                {
                    label4.Visible = true;
                    label3.Visible = true;
                    dogru++;
                    labelDogru.Text = dogru.ToString();
                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Tebrikler,Harikasın";
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                    int kazanilanSkor = 10;
                    int guncel = kazanilanSkor + Int32.Parse(labelScore.Text);
                      scoreUpdate(guncel);
                    labelScore.Text = guncel.ToString();
                  

                    Game2();
                }

                else if (radioButton2.Checked)
                {
                    yanlis++;
                    labelYanlis.Text = yanlis.ToString();
                    Game2();

                }
            }
           
           

           else  if (i == 2)
            {
                label1.Text = "Soru - " + (i + 1);
                if (radioButton1.Checked)
                {

                    yanlis++;
                    labelYanlis.Text = yanlis.ToString();
                    Game3();
                   
                }

                else if (radioButton2.Checked)
                {
                    
                    dogru++;
                    labelDogru.Text = dogru.ToString();

                    int kazanilanSkor = 10;
                    int guncel = kazanilanSkor + Int32.Parse(labelScore.Text);
                    scoreUpdate(guncel);
                    labelScore.Text = guncel.ToString();
                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Tebrikler,Harikasın";
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");

                    Game3();

                }
            }
            else if (i == 3)
            {
                label1.Text = "Soru - " + (i + 1);
                if (radioButton1.Checked)
                {

                    yanlis++;
                    labelYanlis.Text = yanlis.ToString();
                    Game4();

                }

                else if (radioButton2.Checked)
                {

                    dogru++;
                    labelDogru.Text = dogru.ToString();

                    int kazanilanSkor = 10;
                    int guncel = kazanilanSkor + Int32.Parse(labelScore.Text);
                    scoreUpdate(guncel);
                    labelScore.Text = guncel.ToString();
                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Tebrikler,Harikasın";
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");

                    Game4();

                }
            }
            else if (i == 4)
            {
                label1.Text = "Soru - " + (i + 1);
                if (radioButton1.Checked)
                {
                    label4.Visible = true;
                    label3.Visible = true;
                    dogru++;
                    labelDogru.Text = dogru.ToString();

                    int kazanilanSkor = 10;
                    int guncel = kazanilanSkor + Int32.Parse(labelScore.Text);
                    scoreUpdate(guncel);
                    labelScore.Text = guncel.ToString();
                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Tebrikler,Harikasın";
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");

                    Game5();
                }

                else if (radioButton2.Checked)
                {
                    yanlis++;
                    labelYanlis.Text = yanlis.ToString();
                    Game5();

                }
            }

            else if (i == 5)
            {
                label1.Text = "Soru - " + (i + 1);
                next.Text = "Bitir";
                 if (radioButton1.Checked)
                {
                    label4.Visible = true;
                    label3.Visible = true;
                    dogru++;
                    labelDogru.Text = dogru.ToString();

                    int kazanilanSkor = 10;
                    int guncel = kazanilanSkor + Int32.Parse(labelScore.Text);
                    scoreUpdate(guncel);
                    labelScore.Text = guncel.ToString();
                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Tebrikler,Harikasın";
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");


                }



                else if (radioButton2.Checked)
                {
                    yanlis++;
                    labelYanlis.Text = yanlis.ToString();
                    Game5();

                }
            }

            else if (i > 6)
            {
                label1.Text = "Soru - 5";
            }
          

            else
            {

            }
            if (radioButton1.Checked)
            {
              
              
            }

            else if (radioButton2.Checked)
            {


            }

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Games games = new Games();
            games.label2.Text = this.label2.Text;
            games.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
