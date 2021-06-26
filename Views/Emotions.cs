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
    public partial class Emotions : Form
    {
        private List<emotions> emotions;
        public Emotions()
        {
            InitializeComponent();
        }


        ToolTip Aciklama = new ToolTip();
        WebBrowser webBrowser1 = new WebBrowser();

        private async void Emotions_Load(object sender, EventArgs e)
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
            HttpResponseMessage responseMessage = await client.GetAsync("emotions?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            emotions = JsonConvert.DeserializeObject<List<emotions>>(result);
            FillBoxes();

        }



        public void FillBoxes()
        {
            pictureBox1.Image = Utils.byteToImg(emotions[0].emotion_image);
            label1.Text = emotions[0].emotion_name;




            pictureBox2.Image = Utils.byteToImg(emotions[1].emotion_image);
            label2.Text = emotions[1].emotion_name;

            pictureBox3.Image = Utils.byteToImg(emotions[2].emotion_image);
            label3.Text = emotions[2].emotion_name;

            pictureBox4.Image = Utils.byteToImg(emotions[3].emotion_image);
            label4.Text = emotions[3].emotion_name;




            pictureBox5.Image = Utils.byteToImg(emotions[4].emotion_image);
            label5.Text = emotions[4].emotion_name;






            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
          
           

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = emotions[1].emotion_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox2, emotions[1].emotion_name);
            ConceptTrainingEmotions cncemotions = new ConceptTrainingEmotions();
            cncemotions.emotions = this.emotions;
            cncemotions.index = 1;
            cncemotions.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = emotions[0].emotion_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, emotions[0].emotion_name);

            ConceptTrainingEmotions cncemotions = new ConceptTrainingEmotions();
            cncemotions.emotions = this.emotions;
            cncemotions.index = 0;
            cncemotions.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = emotions[2].emotion_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox3, emotions[2].emotion_name);
            ConceptTrainingEmotions cncemotions = new ConceptTrainingEmotions();
            cncemotions.emotions = this.emotions;
            cncemotions.index = 2;
            cncemotions.Show();
            this.Hide();
        }

     
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = emotions[3].emotion_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox4, emotions[3].emotion_name);

            ConceptTrainingEmotions cncemotions = new ConceptTrainingEmotions();
            cncemotions.emotions = this.emotions;
            cncemotions.index = 3;
            cncemotions.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = emotions[4].emotion_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox5, emotions[4].emotion_name);
            ConceptTrainingEmotions cncemotions = new ConceptTrainingEmotions();
            cncemotions.emotions = this.emotions;
            cncemotions.index = 4;
            cncemotions.Show();
            this.Hide();
        }

      
    }
}
