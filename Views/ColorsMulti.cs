using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
namespace Kavramatik.cs
{
    public partial class ColorsMulti : Form
    {
        private List<colors> colors;
        public ColorsMulti()
        {
            InitializeComponent();
        }

        ToolTip Aciklama = new ToolTip();
        WebBrowser webBrowser1 = new WebBrowser();
        private async void ColorsMulti_Load(object sender, EventArgs e)
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
            FillBoxes();

        }



        public void FillBoxes()
        {
            pictureBox1.Image = Utils.byteToImg(colors[0].color);
            label1.Text = colors[0].color_name;




            pictureBox2.Image = Utils.byteToImg(colors[4].color);
            label2.Text = colors[4].color_name;

            pictureBox3.Image = Utils.byteToImg(colors[8].color);
            label3.Text = colors[8].color_name;

            pictureBox4.Image = Utils.byteToImg(colors[12].color);
            label4.Text = colors[12].color_name;

            pictureBox5.Image = Utils.byteToImg(colors[16].color);
            label5.Text = colors[16].color_name;

            pictureBox6.Image = Utils.byteToImg(colors[20].color);
            label6.Text = colors[20].color_name;

            pictureBox7.Image = Utils.byteToImg(colors[24].color);
            label7.Text = colors[24].color_name;

            pictureBox8.Image = Utils.byteToImg(colors[28].color);
            label8.Text = colors[28].color_name;




            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = colors[1].color_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox2, colors[1].color_name);
            ConceptTraining concept = new ConceptTraining();
            concept.colors = this.colors;
            concept.index = 4;
            concept.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = colors[0].color_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, colors[0].color_name);
            ConceptTraining concept = new ConceptTraining();
            concept.colors = this.colors;
            concept.index = 0;
            concept.Show();
            this.Hide();
         

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = colors[2].color_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox3, colors[2].color_name);
            ConceptTraining concept = new ConceptTraining();
            concept.colors = this.colors;
            concept.index = 8;
            concept.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = colors[3].color_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox4, colors[3].color_name);
            ConceptTraining concept = new ConceptTraining();
            concept.colors = this.colors;
            concept.index = 12;
            concept.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = colors[4].color_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox5, colors[4].color_name);
            ConceptTraining concept = new ConceptTraining();
            concept.colors = this.colors;
            concept.index = 16;
            concept.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = colors[5].color_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox6, colors[5].color_name);
            ConceptTraining concept = new ConceptTraining();
            concept.colors = this.colors;
            concept.index = 20;
            concept.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = colors[6].color_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox7, colors[6].color_name);
            ConceptTraining concept = new ConceptTraining();
            concept.colors = this.colors;
            concept.index = 24;
            concept.Show();
            this.Hide();
        }

      


        private void pictureBox8_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = colors[6].color_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox7, colors[6].color_name);
            ConceptTraining concept = new ConceptTraining();
            concept.colors = this.colors;
            concept.index = 28;
            concept.Show();
            this.Hide();
        }
    }
}
