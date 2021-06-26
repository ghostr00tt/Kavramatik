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
    
    public partial class Numbers2 : Form
    {
        private List<numbers> numbers;
        public Numbers2()
        {
            InitializeComponent();


        }
        ToolTip Aciklama = new ToolTip();
        WebBrowser webBrowser1 = new WebBrowser();

        private async void Numbers2_Load(object sender, EventArgs e)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri(Utils.BASE_URL);
            HttpResponseMessage responseMessage = await client.GetAsync("numbers?token_id=464685648465A468464qw8A544688648W6REEWT6V");
            
            string result = await responseMessage.Content.ReadAsStringAsync();
            numbers = JsonConvert.DeserializeObject<List<numbers>>(result);
            FillBoxes();
            try
            {
                webBrowser1.Navigate("https://www.bing.com/translator/?from=tr&to=en");
                webBrowser1.ScriptErrorsSuppressed = true;
                // Translate WebBrowser
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }

        private void FillBoxes()
        {




            pictureBox1.Image = Utils.byteToImg(numbers[8].number_one_image);
            pictureBox2.Image = Utils.byteToImg(numbers[8].number_quantity_image);
            label2.Text = numbers[8].number_one_text; ;
            label1.Text = numbers[8].number_quantity_text;
            label3.Text = numbers[8].number_name;
            pictureBox3.Image = Utils.byteToImg(numbers[9].number_one_image);
            pictureBox4.Image = Utils.byteToImg(numbers[9].number_quantity_image);
            label5.Text = numbers[9].number_one_text;
            label4.Text = numbers[9].number_quantity_text;
            label6.Text = numbers[9].number_name;
            pictureBox5.Image = Utils.byteToImg(numbers[10].number_one_image);
            pictureBox6.Image = Utils.byteToImg(numbers[10].number_quantity_image);
            label8.Text = numbers[10].number_one_text;
            label7.Text = numbers[10].number_quantity_text;
            label9.Text = numbers[10].number_name;
            pictureBox7.Image = Utils.byteToImg(numbers[11].number_one_image);
            pictureBox8.Image = Utils.byteToImg(numbers[11].number_quantity_image);
            label11.Text = numbers[11].number_one_text;
            label10.Text = numbers[11].number_quantity_text;
            label12.Text = numbers[11].number_name;
            pictureBox9.Image = Utils.byteToImg(numbers[12].number_one_image);
            pictureBox10.Image = Utils.byteToImg(numbers[12].number_quantity_image);
            label14.Text = numbers[12].number_one_text;
            label13.Text = numbers[12].number_quantity_text;
            label15.Text = numbers[12].number_name;
            pictureBox11.Image = Utils.byteToImg(numbers[13].number_one_image);
            pictureBox12.Image = Utils.byteToImg(numbers[13].number_quantity_image);
            label17.Text = numbers[13].number_one_text;
            label16.Text = numbers[13].number_quantity_text;
            label18.Text = numbers[13].number_name;
            pictureBox13.Image = Utils.byteToImg(numbers[14].number_one_image);
            pictureBox14.Image = Utils.byteToImg(numbers[14].number_quantity_image);
            label20.Text = numbers[14].number_one_text;
            label19.Text = numbers[14].number_quantity_text;
            label21.Text = numbers[14].number_name;





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
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
          


        }



        private void button1_Click(object sender, EventArgs e)
        {
            Numbers nm = new Numbers();
            nm.Show();
            this.Hide();
          
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConceptTrainingNumbers number = new ConceptTrainingNumbers();
            number.numbers = this.numbers;
            number.index = 8;
            number.Show();
            this.Hide();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ConceptTrainingNumbers number = new ConceptTrainingNumbers();
            number.numbers = this.numbers;
            number.index = 10;
            number.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ConceptTrainingNumbers number = new ConceptTrainingNumbers();
            number.numbers = this.numbers;
            number.index = 9;
            number.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
