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
    public partial class Opposite : Form
    {
        private List<opposities> opposities;
        public Opposite()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
        }
        ToolTip Aciklama = new ToolTip();
        WebBrowser webBrowser1 = new WebBrowser();
        int queque;


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = opposities[queque].opposite_one_image_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, opposities[queque].opposite_one_image_text);

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = opposities[queque].opposite_two_image_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, opposities[queque].opposite_two_image_text);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            queque++;
            if (queque > opposities.Count - 1)
            {
                queque = 0;
            }
            label1.Text = opposities[queque].opposite_one_image_text;
            label2.Text = opposities[queque].opposite_two_image_text;
            pictureBox1.Image = Utils.byteToImg(opposities[queque].opposite_one_image);
            pictureBox2.Image = Utils.byteToImg(opposities[queque].opposite_two_image);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            queque--;
            if (queque < 0)
            {
                queque = opposities.Count - 1;
            }

            label1.Text = opposities[queque].opposite_one_image_text.ToUpper();
            label2.Text = opposities[queque].opposite_two_image_text.ToUpper();
            label1.Text.ToUpper();
            label2.Text.ToUpper();
            pictureBox1.Image = Utils.byteToImg(opposities[queque].opposite_one_image);
            pictureBox2.Image = Utils.byteToImg(opposities[queque].opposite_two_image);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
        

        }

        private async void Opposite_Load_1(object sender, EventArgs e)
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
            HttpResponseMessage responseMessage = await client.GetAsync("opposites?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            opposities = JsonConvert.DeserializeObject<List<opposities>>(result);

            label1.Text = opposities[0].opposite_one_image_text;
            label2.Text = opposities[0].opposite_two_image_text;
            pictureBox1.Image = Utils.byteToImg(opposities[0].opposite_one_image);
            pictureBox2.Image = Utils.byteToImg(opposities[0].opposite_two_image);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
