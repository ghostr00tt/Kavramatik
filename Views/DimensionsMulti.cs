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
    public partial class DimensionsMulti : Form
    {
        private List<dimensions> dimensions;
        public DimensionsMulti()
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
      
        }

        ToolTip Aciklama = new ToolTip();
        WebBrowser webBrowser1 = new WebBrowser();

     
        private async void DimensionsMulti_Load(object sender, EventArgs e)
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
            HttpResponseMessage responseMessage = await client.GetAsync("dimensions?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            dimensions = JsonConvert.DeserializeObject<List<dimensions>>(result);
            FillBoxes();
        }

        public void FillBoxes()
        {
            pictureBox1.Image = Utils.byteToImg(dimensions[0].dimension_one_image);
            pictureBox2.Image = Utils.byteToImg(dimensions[0].dimension_two_image);
            label1.Text = dimensions[0].dimension_name;
            label2.Text = dimensions[0].dimension_one_text;
            label3.Text = dimensions[0].dimension_two_text;


            pictureBox3.Image = Utils.byteToImg(dimensions[4].dimension_one_image);
            pictureBox4.Image = Utils.byteToImg(dimensions[4].dimension_two_image);
            label4.Text = dimensions[4].dimension_name;
            label5.Text = dimensions[4].dimension_one_text;
            label6.Text = dimensions[4].dimension_two_text;


            pictureBox5.Image = Utils.byteToImg(dimensions[8].dimension_one_image);
            pictureBox6.Image = Utils.byteToImg(dimensions[8].dimension_two_image);
            label7.Text = dimensions[8].dimension_name;
            label8.Text = dimensions[8].dimension_one_text;
            label9.Text = dimensions[8].dimension_two_text;


            pictureBox7.Image = Utils.byteToImg(dimensions[12].dimension_one_image);
            pictureBox8.Image = Utils.byteToImg(dimensions[12].dimension_two_image);
            label10.Text = dimensions[12].dimension_name;
            label11.Text = dimensions[12].dimension_one_text;
            label12.Text = dimensions[12].dimension_two_text;
            //label3.Text = dimensions[2].dimension_name;

            //pictureBox2.Image = Utils.byteToImg(dimensions[1].dimension_one_image);
            //label2.Text = dimensions[1].dimension_name;

            //pictureBox3.Image = Utils.byteToImg(dimensions[2].dimension_one_image);
            //label3.Text = dimensions[2].dimension_name;


            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;


            //pictureBox2.Image = Utils.byteToImg(dimensions[1].dimension_one_image);
            //label2.Text = dimensions[1].dimension_name;

            //pictureBox3.Image = Utils.byteToImg(dimensions[2].dimension_one_image);
            //label3.Text = dimensions[2].dimension_name;

            //pictureBox4.Image = Utils.byteToImg(dimensions[3].dimension_one_image);
            //label4.Text = dimensions[3].dimension_name;

            //pictureBox5.Image = Utils.byteToImg(dimensions[4].dimension_one_image);
            //label5.Text = dimensions[4].dimension_name;

            //pictureBox6.Image = Utils.byteToImg(dimensions[5].dimension_one_image);
            //label6.Text = dimensions[5].dimension_name;

            //pictureBox7.Image = Utils.byteToImg(dimensions[6].dimension_one_image);
            //label7.Text = dimensions[6].dimension_name;

            //pictureBox8.Image = Utils.byteToImg(dimensions[7].dimension_one_image);
            //label8.Text = dimensions[7].dimension_name;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = dimensions[0].dimension_one_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, dimensions[0].dimension_one_text);

            ConceptTrainingDimensions conceptTrainingDimensions = new ConceptTrainingDimensions();
            conceptTrainingDimensions.dimensions = this.dimensions;
            conceptTrainingDimensions.index = 0;
            conceptTrainingDimensions.Show();
            this.Hide();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = dimensions[0].dimension_two_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox2, dimensions[0].dimension_two_text);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = dimensions[1].dimension_one_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox4, dimensions[1].dimension_one_text);

            ConceptTrainingDimensions conceptTrainingDimensions = new ConceptTrainingDimensions();
            conceptTrainingDimensions.dimensions = this.dimensions;
            conceptTrainingDimensions.index = 4;
            conceptTrainingDimensions.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = dimensions[1].dimension_two_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox3, dimensions[1].dimension_two_text);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = dimensions[2].dimension_one_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox5, dimensions[2].dimension_one_text);

            ConceptTrainingDimensions conceptTrainingDimensions = new ConceptTrainingDimensions();
            conceptTrainingDimensions.dimensions = this.dimensions;
            conceptTrainingDimensions.index = 8;
            conceptTrainingDimensions.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = dimensions[2].dimension_two_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox6, dimensions[2].dimension_two_text);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = dimensions[3].dimension_one_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox7, dimensions[3].dimension_one_text);

            ConceptTrainingDimensions conceptTrainingDimensions = new ConceptTrainingDimensions();
            conceptTrainingDimensions.dimensions = this.dimensions;
            conceptTrainingDimensions.index = 12;
            conceptTrainingDimensions.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = dimensions[3].dimension_two_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox8, dimensions[3].dimension_two_text);
        }
    }
}
