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
    public partial class Numbers : Form
    {
        private List<numbers> numbers;
        public Numbers()
        {
            InitializeComponent();
            HideLabels();

            
        }
        ToolTip Aciklama = new ToolTip();
        WebBrowser webBrowser1 = new WebBrowser();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private async void Numbers_Load(object sender, EventArgs e)
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
            HttpResponseMessage responseMessage = await client.GetAsync("numbers?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            numbers = JsonConvert.DeserializeObject<List<numbers>>(result);
            FillBoxes();
        }
        public void HideLabels()
        {
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
         
          
        }
        private void FillBoxes()
        {
            pictureBox1.Image = Utils.byteToImg(numbers[0].number_one_image);
            label1.Text = numbers[0].number_name;

            pictureBox2.Image = Utils.byteToImg(numbers[1].number_one_image);
            label2.Text = numbers[1].number_name;

            pictureBox3.Image = Utils.byteToImg(numbers[2].number_one_image);
            label3.Text = numbers[0].number_name;

            pictureBox4.Image = Utils.byteToImg(numbers[3].number_one_image);
            label4.Text = numbers[3].number_name;

            pictureBox5.Image = Utils.byteToImg(numbers[4].number_one_image);
            label5.Text = numbers[4].number_name;

            pictureBox6.Image = Utils.byteToImg(numbers[5].number_one_image);
            label6.Text = numbers[5].number_name;

            pictureBox7.Image = Utils.byteToImg(numbers[6].number_one_image);
            label7.Text = numbers[6].number_name;

            pictureBox8.Image = Utils.byteToImg(numbers[7].number_one_image);
            label8.Text = numbers[7].number_name;

            pictureBox9.Image = Utils.byteToImg(numbers[8].number_one_image);
            label9.Text = numbers[8].number_name;

            pictureBox10.Image = Utils.byteToImg(numbers[9].number_one_image);
            label10.Text = numbers[9].number_name;








            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;


            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Numbers2 nm2 = new Numbers2();
            nm2.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConceptTrainingNumbers number = new ConceptTrainingNumbers();
            number.numbers = this.numbers;
            number.index = 0;
            number.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ConceptTrainingNumbers number = new ConceptTrainingNumbers();
            number.numbers = this.numbers;
            number.index = 9;
            number.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ConceptTrainingNumbers number = new ConceptTrainingNumbers();
            number.numbers = this.numbers;
            number.index = 2;
            number.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ConceptTrainingNumbers number = new ConceptTrainingNumbers();
            number.numbers = this.numbers;
            number.index = 3;
            number.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ConceptTrainingNumbers number = new ConceptTrainingNumbers();
            number.numbers = this.numbers;
            number.index = 4;
            number.Show();
            this.Hide();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ConceptTrainingNumbers number = new ConceptTrainingNumbers();
            number.numbers = this.numbers;
            number.index = 5;
            number.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ConceptTrainingNumbers number = new ConceptTrainingNumbers();
            number.numbers = this.numbers;
            number.index = 6;
            number.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ConceptTrainingNumbers number = new ConceptTrainingNumbers();
            number.numbers = this.numbers;
            number.index = 7;
            number.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ConceptTrainingNumbers number = new ConceptTrainingNumbers();
            number.numbers = this.numbers;
            number.index = 8;
            number.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            ConceptTrainingNumbers number = new ConceptTrainingNumbers();
            number.numbers = this.numbers;
            number.index = 1;
            number.Show();
            this.Hide();
        }
    }
}
