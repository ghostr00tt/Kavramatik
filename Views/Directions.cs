using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace Kavramatik.cs
{
    public partial class Directions : Form
    {
        private List<directions> directions;
        public Directions()
        {
            InitializeComponent();
        }

        readonly WebBrowser webBrowser1 = new WebBrowser();
        private async void Directions_Load(object sender, EventArgs e)
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
            HttpResponseMessage responseMessage = await client.GetAsync("directions?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            directions = JsonConvert.DeserializeObject<List<directions>>(result);
            FillBoxes();
        }

        private void FillBoxes()
        {
            pictureBox1.Image = Utils.byteToImg(directions[0].direction_image);
            label1.Text = directions[0].direction_name;




            pictureBox2.Image = Utils.byteToImg(directions[4].direction_image);
            label2.Text = directions[4].direction_name;

            pictureBox3.Image = Utils.byteToImg(directions[8].direction_image);
            label3.Text = directions[8].direction_name;

            pictureBox4.Image = Utils.byteToImg(directions[12].direction_image);
            label4.Text = directions[12].direction_name;

            pictureBox5.Image = Utils.byteToImg(directions[16].direction_image);
            label5.Text = directions[16].direction_name;

            pictureBox6.Image = Utils.byteToImg(directions[20].direction_image);
            label6.Text = directions[20].direction_name;


            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        readonly ToolTip Aciklama = new ToolTip();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = directions[0].direction_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, directions[0].direction_name);

            ConceptTrainingDirections cnctd = new ConceptTrainingDirections();
            cnctd.index = 0;
            cnctd.directions = directions;
            cnctd.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = directions[1].direction_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox2, directions[1].direction_name);
            ConceptTrainingDirections cnctd = new ConceptTrainingDirections();
            cnctd.index = 4;
            cnctd.directions = directions;
            cnctd.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = directions[2].direction_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox3, directions[2].direction_name);
            ConceptTrainingDirections cnctd = new ConceptTrainingDirections();
            cnctd.index = 8;
            cnctd.directions = directions;
            cnctd.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = directions[3].direction_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox4, directions[3].direction_name);
            ConceptTrainingDirections cnctd = new ConceptTrainingDirections();
            cnctd.index = 12;
            cnctd.directions = directions;
            cnctd.Show();
            Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = directions[4].direction_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox5, directions[4].direction_name);
            ConceptTrainingDirections cnctd = new ConceptTrainingDirections();
            cnctd.index = 16;
            cnctd.directions = directions;
            cnctd.Show();
            Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = directions[5].direction_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox6, directions[5].direction_name);
            ConceptTrainingDirections cnctd = new ConceptTrainingDirections();
            cnctd.index = 20;
            cnctd.directions = directions;
            cnctd.Show();
            Hide();
        }
    }
}
