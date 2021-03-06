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
    public partial class NumbersSingle : Form
    {
        private List<numbers> numbers;
        public NumbersSingle()
        {
            InitializeComponent();
        }

        ToolTip Aciklama = new ToolTip();
        WebBrowser webBrowser1 = new WebBrowser();
        int queque = 0;



        private void pictureBox1_Click(object sender, EventArgs e)
        {

            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = numbers[queque].number_one_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, numbers[queque].number_one_text);

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = numbers[queque].number_quantity_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox2, numbers[queque].number_quantity_text);


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            queque++;
            if (queque > numbers.Count - 1)
            {
                queque = 0;
            }
            label1.Text = numbers[queque].number_one_text;
            label2.Text = numbers[queque].number_quantity_text;
            pictureBox1.Image = Utils.byteToImg(numbers[queque].number_one_image);
            pictureBox2.Image = Utils.byteToImg(numbers[queque].number_quantity_image);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            queque--;
            if (queque < 0)
            {
                queque = numbers.Count - 1;
            }

            label1.Text = numbers[queque].number_one_text.ToUpper();
            label2.Text = numbers[queque].number_quantity_text.ToUpper();
            label1.Text.ToUpper();
            label2.Text.ToUpper();
            pictureBox1.Image = Utils.byteToImg(numbers[queque].number_one_image);
            pictureBox2.Image = Utils.byteToImg(numbers[queque].number_quantity_image);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private async void NumbersSingle_Load(object sender, EventArgs e)
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

            label1.Text = numbers[0].number_one_text;
            label2.Text = numbers[0].number_quantity_text;
            pictureBox1.Image = Utils.byteToImg(numbers[0].number_one_image);
            pictureBox2.Image = Utils.byteToImg(numbers[0].number_quantity_image);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
