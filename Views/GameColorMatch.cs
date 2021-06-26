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
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kavramatik.cs
{
    public partial class GameColorMatch : Form
    {
        String updateScore = String.Format("http://kavramatik.com/api/setScore");
        public string datas;
        int kazanilanSkor;

        public List<colors> tempcolors;
        public List<colors> col;
        public List<dimensions> dimensions;
        public List<shapes> shapes;
        public List<quantities> quantities;
        public List<directions> directions;
        public List<senses> senses;
        public List<opposities> opposities;
        public List<emotions> emotions;
        public List<numbers> numbers;
        
        string[] options = { "Renkler", "Boyutlar", "Şekiller", "Sayılar", "Yönler", "Duyular", "Zıtlıklar", "DUygular" };
        int count = 1;
        
        public List<string> Shuffle(List<string> renk)
        {
            Random rng = new Random();
            int n = renk.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = renk[k];
                renk[k] = renk[n];
                renk[n] = value;
            }

            return renk;
        }

        public GameColorMatch()
        {
            InitializeComponent();
            label8.Visible = false;
            label7.Visible = false;
            button2.Text = "Başla";

        }
        int TabIdIndex = -1;
        int tiklanan = -1;
        int max_oyun_alan = 4;
        List<Panel> picture = new List<Panel>();
        List<int> renkler_list = new List<int>();

        List<string> renkler = new List<string>();
        List<string> temprenkler = new List<string>();
        public string Parse(string veri)
        {
            string cikti = "";

            JObject json = JObject.Parse(veri);
            cikti = json["score"].ToString();

            return cikti;
        }

        public void colorTransfer(List<colors> tempcolors, List<colors> col )
        {
            
            
        }
        public async void dimensionsLoad()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Utils.BASE_URL);
            HttpResponseMessage responseMessage = await client.GetAsync("dimensions?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            dimensions = JsonConvert.DeserializeObject<List<dimensions>>(result);
        }

        private async void  directionsLoad()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Utils.BASE_URL);
            HttpResponseMessage responseMessage = await client.GetAsync("directions?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            directions = JsonConvert.DeserializeObject<List<directions>>(result);
        }

        private async void numbersLoad()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Utils.BASE_URL);
            HttpResponseMessage responseMessage = await client.GetAsync("numbers?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            numbers = JsonConvert.DeserializeObject<List<numbers>>(result);
        }

        private async void sensesLoad()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Utils.BASE_URL);
            HttpResponseMessage responseMessage = await client.GetAsync("senses?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            senses = JsonConvert.DeserializeObject<List<senses>>(result);
        }

        private async void shapesLoad()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Utils.BASE_URL);
            HttpResponseMessage responseMessage = await client.GetAsync("shapes?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            shapes = JsonConvert.DeserializeObject<List<shapes>>(result);
        }

        private async void oppositiesLoad()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Utils.BASE_URL);
            HttpResponseMessage responseMessage = await client.GetAsync("opposites?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            opposities = JsonConvert.DeserializeObject<List<opposities>>(result);
        }
        private async void GameColorMatch_Load(object sender, EventArgs e)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri(Utils.BASE_URL);
            HttpResponseMessage responseMessage = await client.GetAsync("allcolors?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            col = JsonConvert.DeserializeObject<List<colors>>(result);
            comboBox1.Items.AddRange(options);
            oppositiesLoad();
            shapesLoad();
            sensesLoad();
            numbersLoad();
            directionsLoad();
            dimensionsLoad();

            String mail = label2.Text.ToString();

            String showProfile = String.Format("http://kavramatik.com/api/showProfile?user_email=" + mail);
            var request = WebRequest.Create(showProfile);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();

            datas = data.ToString();
            labelScore.Text = Parse(datas);

            //    oyunOlustur();

        }
        string colname;
        string colname2;
        string temp;
        int maxindex = 2;

        
        private void oyunOlustur()
        {
            button2.Text = "Yeniden Başla";
            comboBox1.Visible = false;

            label9.Text = "Aşama - " + count.ToString();
            renkler.Clear();

            if (picture.Count > 0)
            {

                foreach (var item in picture)
                {

                    this.Controls.Remove(item);

                }
                picture.Clear();
            }

            renkler_list.Clear();
            tiklanan = -1;
            TabIdIndex = -1;


            //string[] options = { "Renkler", "Boyutlar", "Şekiller", "Sayılar", "Yönler", "Duyular", "Zıtlıklar", "DUygular" };

            Random rastgele = new Random();
            for (int i = 0; i < max_oyun_alan / 2; i++)
            {

                if (comboBox1.SelectedIndex == 0)
                {
                    do
                    {
                        int index = rastgele.Next(0, 30);

                        temp = col[index].color;
                        colname = col[index].color_name;
                    } while (colname == colname2);

                    colname2 = colname;
                    renkler.Add(temp);
                    renkler.Add(temp);
                }

                else if (comboBox1.SelectedIndex == 1)
                {
                    do
                    {
                        int index = rastgele.Next(0, 15);

                        temp = dimensions[index].dimension_one_image;
                        colname = dimensions[index].dimension_one_text;
                    } while (colname == colname2);

                    colname2 = colname;
                    renkler.Add(temp);
                    renkler.Add(temp);
                }

                else if (comboBox1.SelectedIndex == 2)
                {
                    do
                    {
                        int index = rastgele.Next(0, 9);

                        temp = shapes[index].shape_image;
                        colname = shapes[index].shape_name;
                    } while (colname == colname2);

                    colname2 = colname;
                    renkler.Add(temp);
                    renkler.Add(temp);
                }

                else if (comboBox1.SelectedIndex == 3)
                {
                    do
                    {
                        int index = rastgele.Next(0, 9);

                        temp = numbers[index].number_one_image;
                        colname = numbers[index].number_one_text;
                    } while (colname == colname2);

                    colname2 = colname;
                    renkler.Add(temp);
                    renkler.Add(temp);
                }

                else if (comboBox1.SelectedIndex == 4)
                {
                    do
                    {
                        int index = rastgele.Next(0, 9);

                        temp = directions[index].direction_image;
                        colname = directions[index].direction_name;
                    } while (colname == colname2);

                    colname2 = colname;
                    renkler.Add(temp);
                    renkler.Add(temp);
                }

                else if (comboBox1.SelectedIndex == 5)
                {
                    do
                    {
                        int index = rastgele.Next(0, 9);

                        temp = senses[index].sense_one_image;
                        colname = senses[index].sense_one_image_text;
                    } while (colname == colname2);

                    colname2 = colname;
                    renkler.Add(temp);
                    renkler.Add(temp);
                }


            }
            renkler = Shuffle(renkler);

            var d_top = 200;
            var d_left = 20;

           
            for (int i = 1; i <= max_oyun_alan; i++)
            {
                Panel m = new Panel();

                m.Left = d_left;
                m.Top = d_top;
                m.Width = 80;
                m.Height = 80 ;
                d_left += 110;
                m.Click += tiklama_picture;
                m.TabIndex = i;
                m.Enabled = false;
                m.BackgroundImage = Utils.byteToImg(renkler[i-1]) ;
                renkler_list.Add(i - 1);

                if (maxindex < 6)
                {
                    if (i % maxindex == 0)
                    {
                        d_top += 90;
                        d_left = 20;

                    }

                    this.Controls.Add(m);
                    picture.Add(m);
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        d_top += 90;
                        d_left = 20;

                    }

                    this.Controls.Add(m);
                    picture.Add(m);
                }
                

            }
            button1.Enabled = false;
            button2.Enabled = false;

            timer1.Start();
            comboBox1.Visible = false;
        }

        private void tiklama_picture(object sender, EventArgs e)
        {
            Panel resim = (Panel)sender;
            TabIdIndex = resim.TabIndex - 1;
            picture[TabIdIndex].BackgroundImage = null;

            if (TabIdIndex != tiklanan)
            {

                if (tiklanan != -1)
                {
                  

                    picture[TabIdIndex].BackgroundImage = Utils.byteToImg(renkler[renkler_list[TabIdIndex]]);

                    if (renkler[renkler_list[TabIdIndex]] == renkler[renkler_list[tiklanan]])
                    {

                        timer3.Start();

                    }
                    else
                    {

                        for (int i = 0; i < max_oyun_alan; i++)
                        {
                            picture[i].Enabled = false;
                        }

                        timer2.Start();


                    }

                }
                else
                {

                    tiklanan = TabIdIndex;
                    picture[TabIdIndex].BackgroundImage = Utils.byteToImg(renkler[renkler_list[TabIdIndex]]);

                }

            }

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;

          
            for (int i = 0; i < max_oyun_alan; i++)
            {
                picture[i].Enabled = true;
              
                picture[i].BackgroundImage = global::Kavramatik.cs.Resource1.backimagee;
                picture[i].BackgroundImageLayout = ImageLayout.Stretch;
            }
            timer1.Stop();
        }

      

        private void timer2_Tick(object sender, EventArgs e)
        {

            picture[TabIdIndex].BackgroundImage = global::Kavramatik.cs.Resource1.backimagee;
            picture[TabIdIndex].BackgroundImageLayout = ImageLayout.Stretch;

            picture[tiklanan].BackgroundImage = global::Kavramatik.cs.Resource1.backimagee;
            picture[tiklanan].BackgroundImageLayout = ImageLayout.Stretch;

            //picture[TabIdIndex].BackColor = Color.Gray;
            //picture[tiklanan].BackColor = Color.Gray;
            tiklanan = -1;
            for (int i = 0; i < max_oyun_alan; i++)
            {
                picture[i].Enabled = true;
            }
            tiklanan = -1;

            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            picture[TabIdIndex].Visible = false;
            picture[tiklanan].Visible = false;
            tiklanan = -1;
            timer3.Stop();
            var sonuc = oyunBitti();
            if (sonuc)
            {
                kazanilanSkor = 30;
                scoreUpdate(kazanilanSkor);
                int guncel = kazanilanSkor + Int32.Parse(labelScore.Text);
                labelScore.Text = guncel.ToString();
                count++;
                max_oyun_alan += 2;
              
                maxindex++;
                comboBox1.Visible = true;
                MessageBox.Show("Başardın, Harikasın");
                if (count == 9)
                {
                    label8.Visible = true;
                    button2.Enabled = false;
                    button1.Enabled = false;
                }
             
            }
        }


        private bool oyunBitti()
        {
            int bitti = 0;
            for (int i = 0; i < max_oyun_alan ; i++)
            {

                if (picture[i].Visible == false)
                {
                    bitti++;
                }
               
            }
           
            return (bitti == max_oyun_alan ? true : false);
        }
        public async void WaitSomeTime(int gelen)
        {
            await Task.Delay(gelen);
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        int btn1tiklama = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            btn1tiklama++;
          
            button1.Enabled = false;

            if (btn1tiklama < 3)
            {
                int hak = 3 - btn1tiklama;
                label6.Text = "Kalan ipucu : " + hak.ToString();
                for (int i = 0; i < max_oyun_alan; i++)
                {
                    picture[i].BackgroundImage = Utils.byteToImg(renkler[i]);
                    picture[i].Enabled = false;
                }

                int milliseconds = 900;
                Thread.Sleep(milliseconds);

                timer1.Stop();
                timer1.Start();
            }
            else
            {
                label6.Text = "";
                label5.Text = "İpucu hakkınız dolmuştur";
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            btn1tiklama = 0;
            oyunOlustur();
        }

        async private void scoreUpdate(int kazanilanSkor)
        {
            String mail = label2.Text.ToString();
            int newScore = kazanilanSkor + Int32.Parse(labelScore.Text);

            Score scoreUser = new Score(mail, newScore);


            string json = JsonConvert.SerializeObject(scoreUser);
            var data = new StringContent(json, Encoding.UTF8, "application/json");


            var client = new HttpClient();

            var response = await client.PostAsync(updateScore, data);

            string result = response.Content.ReadAsStringAsync().Result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Games games = new Games();
            games.label2.Text = this.label2.Text;
            games.Show();
            this.Hide();

        }
        int comboboxIndex = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboboxIndex != comboBox1.SelectedIndex)
            {
                maxindex = 2;
                max_oyun_alan = 4;
                count = 1;
            }
            comboboxIndex = comboBox1.SelectedIndex;

        }
    }
}
