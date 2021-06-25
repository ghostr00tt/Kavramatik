using Newtonsoft.Json;
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
    public partial class Test : Form
    {
        
        private List<colors> colors;
        private List<string> incoming;
        public Test()
        {
            InitializeComponent();
        }
        ToolTip Aciklama = new ToolTip();
       
        WebBrowser webBrowser1 = new WebBrowser();
        private async void Test_Load(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Navigate("https://www.bing.com/translator/?from=tr&to=en");
                webBrowser1.ScriptErrorsSuppressed = true;
                //Google Translate yi WebBrowser ile Aç
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var client = new HttpClient();
            client.BaseAddress = new Uri(Utils.BASE_URL);
            HttpResponseMessage responseMessage = await client.GetAsync("allcolors?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            colors = JsonConvert.DeserializeObject<List<colors>>(result);
            var outgoing = colors;
            var incoming = typeof(colors);
            string temp = incoming.ToString();
            string name = temp.Substring(14);
            
            label1.Text = name.ToString();
            string metin="";
          for (int i = 0; i < 8; i++)
            {
                metin = metin + " pictureBox" + (i + 1) + ".SizeMode = PictureBoxSizeMode.StretchImage; \n";

            }
         
            
        }
        private int queque = 0;

        String updateScore = String.Format("http://kavramatik.com/api/setScore");
        public string datas;
        private async void guncel(int kazanilanskor)
        {
            label2.Text = "arwa213@protonmail.com";
            String mail = label2.Text.ToString();
            int newScore = kazanilanskor;

            Score scoreUser = new Score(mail, newScore);


            string json = JsonConvert.SerializeObject(scoreUser);
            var data = new StringContent(json, Encoding.UTF8, "application/json");


            var client = new HttpClient();

            var response = await client.PostAsync(updateScore, data);

            string result = response.Content.ReadAsStringAsync().Result;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queque++;
            if (queque > colors.Count -1 )
            {
                queque = 0;
            }
                label1.Text = colors[queque].one_tag;
                label2.Text = colors[queque].two_tag;
                pictureBox1.Image = Utils.byteToImg(colors[queque].color_one);
                pictureBox2.Image = Utils.byteToImg(colors[queque].color_two);
            int kazanilanskor = 30;
            guncel(kazanilanskor);

          

        }

        private void button2_Click(object sender, EventArgs e)
        {

            queque--;
            if (queque < 0)
            {
                queque = colors.Count -1 ;
            }
            
            label1.Text = colors[queque].one_tag.ToUpper();
            label2.Text = colors[queque].two_tag.ToUpper();
            label1.Text.ToUpper();
            label2.Text.ToUpper();
            pictureBox1.Image = Utils.byteToImg(colors[queque].color_one);
            pictureBox2.Image = Utils.byteToImg(colors[queque].color_two);
          
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = colors[queque].one_tag;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, colors[queque].one_tag);
       
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = colors[queque].two_tag;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, colors[queque].two_tag);
      
     
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }
    }
}
