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
    public partial class Quantities : Form
    {
        private List<quantities> quantities;
        public Quantities()
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

            label15.Visible = false;
            label13.Visible = false;
            label14.Visible = false;


            pictureBox10.Visible = false;
            pictureBox9.Visible = false;
        }
        public void FillBoxes()
        {



            pictureBox1.Image = Utils.byteToImg(quantities[0].quantitiy_one_image);
            pictureBox2.Image = Utils.byteToImg(quantities[0].quantitiy_two_image);
            label1.Text = quantities[0].quantitiy_name;
            label2.Text = quantities[0].quantitiy_one_text;
            label3.Text = quantities[0].quantitiy_two_text;


            pictureBox3.Image = Utils.byteToImg(quantities[4].quantitiy_one_image);
            pictureBox4.Image = Utils.byteToImg(quantities[4].quantitiy_two_image);
            label4.Text = quantities[4].quantitiy_name;
            label5.Text = quantities[4].quantitiy_one_text;
            label6.Text = quantities[4].quantitiy_two_text;


            pictureBox5.Image = Utils.byteToImg(quantities[8].quantitiy_one_image);
            pictureBox6.Image = Utils.byteToImg(quantities[8].quantitiy_two_image);
            label7.Text = quantities[8].quantitiy_name;
            label8.Text = quantities[8].quantitiy_one_text;
            label9.Text = quantities[8].quantitiy_two_text;


            pictureBox7.Image = Utils.byteToImg(quantities[11].quantitiy_one_image);
            pictureBox8.Image = Utils.byteToImg(quantities[11].quantitiy_two_image);
            label10.Text = quantities[14].quantitiy_name;
            label11.Text = quantities[14].quantitiy_one_text;
            label12.Text = quantities[14].quantitiy_two_text;


            pictureBox10.Image = Utils.byteToImg(quantities[4].quantitiy_one_image);
            pictureBox9.Image = Utils.byteToImg(quantities[4].quantitiy_two_image);
            label13.Text = quantities[4].quantitiy_name;
            label14.Text = quantities[4].quantitiy_one_text;
            label15.Text = quantities[4].quantitiy_two_text;

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

        }
        private async void Quantities_Load(object sender, EventArgs e)
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
            HttpResponseMessage responseMessage = await client.GetAsync("quantities?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            quantities = JsonConvert.DeserializeObject<List<quantities>>(result);
            FillBoxes();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = quantities[0].quantitiy_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, quantities[0].quantitiy_name);
            ConceptTrainingQuantities conceptLearning = new ConceptTrainingQuantities();
            conceptLearning.quantities = this.quantities;
            conceptLearning.index = 11;
            conceptLearning.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = quantities[0].quantitiy_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, quantities[0].quantitiy_name);
            ConceptTrainingQuantities conceptLearning = new ConceptTrainingQuantities();
            conceptLearning.quantities = this.quantities;
            conceptLearning.index = 8;
            conceptLearning.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = quantities[0].quantitiy_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, quantities[0].quantitiy_name);
            ConceptTrainingQuantities conceptLearning = new ConceptTrainingQuantities();
            conceptLearning.quantities = this.quantities;
            conceptLearning.index = 4;
            conceptLearning.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        WebBrowser webBrowser1 = new WebBrowser();
        ToolTip Aciklama = new ToolTip();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = quantities[0].quantitiy_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, quantities[0].quantitiy_name);
            ConceptTrainingQuantities conceptLearning = new ConceptTrainingQuantities();
            conceptLearning.quantities = this.quantities;
            conceptLearning.index = 0;
            conceptLearning.Show();
            this.Hide();
        }
    }
}
