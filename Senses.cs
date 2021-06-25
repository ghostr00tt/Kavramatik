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
    public partial class Senses : Form
    {
        private List<senses> senses;
        public Senses()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
        }

        ToolTip Aciklama = new ToolTip();
        WebBrowser webBrowser1 = new WebBrowser();


        private async void Senses_Load(object sender, EventArgs e)
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
            HttpResponseMessage responseMessage = await client.GetAsync("senses?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            senses = JsonConvert.DeserializeObject<List<senses>>(result);
            FillBoxes();
        }

        public void FillBoxes()
        {
            pictureBox1.Image = Utils.byteToImg(senses[0].sense_one_image);
            pictureBox2.Image = Utils.byteToImg(senses[0].sense_two_image);
            label1.Text = senses[0].sense_name;
            label2.Text = senses[0].sense_one_image_text;
            label3.Text = senses[0].sense_two_image_text;


            pictureBox4.Image = Utils.byteToImg(senses[4].sense_one_image);
            pictureBox3.Image = Utils.byteToImg(senses[4].sense_two_image);
            label4.Text = senses[4].sense_name;
            label5.Text = senses[4].sense_one_image_text;
            label6.Text = senses[4].sense_two_image_text;


            pictureBox5.Image = Utils.byteToImg(senses[8].sense_one_image);
            pictureBox6.Image = Utils.byteToImg(senses[8].sense_two_image);
            label7.Text = senses[8].sense_name;
            label8.Text = senses[8].sense_one_image_text;
            label9.Text = senses[8].sense_two_image_text;


            pictureBox7.Image = Utils.byteToImg(senses[11].sense_one_image);
            pictureBox8.Image = Utils.byteToImg(senses[11].sense_two_image);
            label10.Text = senses[11].sense_name;
            label11.Text = senses[11].sense_one_image_text;
            label12.Text = senses[11].sense_two_image_text;

            pictureBox9.Image = Utils.byteToImg(senses[15].sense_one_image);
            pictureBox10.Image = Utils.byteToImg(senses[15].sense_two_image);
            label13.Text = senses[15].sense_name;
            label14.Text = senses[15].sense_one_image_text;
            label15.Text = senses[15].sense_two_image_text;

            pictureBox11.Image = Utils.byteToImg(senses[19].sense_one_image);
            pictureBox12.Image = Utils.byteToImg(senses[19].sense_two_image);
            label16.Text = senses[19].sense_name;
            label17.Text = senses[19].sense_one_image_text;
            label18.Text = senses[19].sense_two_image_text;
            //label3.Text = senses[2].sense_name;

            //pictureBox2.Image = Utils.byteToImg(senses[1].sense_one_image);
            //label2.Text = senses[1].sense_name;

            //pictureBox3.Image = Utils.byteToImg(senses[2].sense_one_image);
            //label3.Text = senses[2].sense_name;


            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;


            //pictureBox2.Image = Utils.byteToImg(senses[1].sense_one_image);
            //label2.Text = senses[1].sense_name;

            //pictureBox3.Image = Utils.byteToImg(senses[2].sense_one_image);
            //label3.Text = senses[2].sense_name;

            //pictureBox4.Image = Utils.byteToImg(senses[3].sense_one_image);
            //label4.Text = senses[3].sense_name;

            //pictureBox5.Image = Utils.byteToImg(senses[4].sense_one_image);
            //label5.Text = senses[4].sense_name;

            //pictureBox6.Image = Utils.byteToImg(senses[5].sense_one_image);
            //label6.Text = senses[5].sense_name;

            //pictureBox7.Image = Utils.byteToImg(senses[6].sense_one_image);
            //label7.Text = senses[6].sense_name;

            //pictureBox8.Image = Utils.byteToImg(senses[7].sense_one_image);
            //label8.Text = senses[7].sense_name;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)  
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = senses[0].sense_one_image_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, senses[0].sense_one_image_text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = senses[0].sense_two_image_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox2, senses[0].sense_two_image_text);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = senses[4].sense_one_image_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox4, senses[4].sense_one_image_text);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = senses[4].sense_two_image_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox3, senses[4].sense_two_image_text);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = senses[8].sense_one_image_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox5, senses[8].sense_one_image_text);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = senses[8].sense_two_image_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox6, senses[8].sense_two_image_text);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = senses[11].sense_one_image_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox7, senses[11].sense_one_image_text);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = senses[11].sense_two_image_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox8, senses[11].sense_two_image_text);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = senses[15].sense_one_image_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox9, senses[15].sense_one_image_text);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = senses[15].sense_two_image_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox10, senses[15].sense_two_image_text);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = senses[19].sense_one_image_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox11, senses[5].sense_one_image_text);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = senses[19].sense_two_image_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox12, senses[5].sense_two_image_text);
        }


    }
}
