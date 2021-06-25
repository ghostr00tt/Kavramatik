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
    public partial class Dimensions : Form
    {
        private List<dimensions> dimensions;
        public Dimensions()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
          
           
        }
        ToolTip Aciklama = new ToolTip();
        WebBrowser webBrowser1 = new WebBrowser();
        int queque;
    
        private async void Dimensions_Load(object sender, EventArgs e)
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

            label1.Text = dimensions[0].dimension_one_text;
            label2.Text = dimensions[0].dimension_two_text;
            pictureBox1.Image = Utils.byteToImg(dimensions[0].dimension_one_image);
            pictureBox2.Image = Utils.byteToImg(dimensions[0].dimension_two_image);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }

      



        private void pictureBox1_Click(object sender, EventArgs e)
        {

            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = dimensions[queque].dimension_one_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, dimensions[queque].dimension_one_text);

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = dimensions[queque].dimension_two_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, dimensions[queque].dimension_two_text);


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            queque++;
            if (queque > dimensions.Count - 1)
            {
                queque = 0;
            }
            label1.Text = dimensions[queque].dimension_one_text;
            label2.Text = dimensions[queque].dimension_two_text;
            pictureBox1.Image = Utils.byteToImg(dimensions[queque].dimension_one_image);
            pictureBox2.Image = Utils.byteToImg(dimensions[queque].dimension_two_image);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            queque--;
            if (queque < 0)
            {
                queque = dimensions.Count - 1;
            }

            label1.Text = dimensions[queque].dimension_one_text.ToUpper();
            label2.Text = dimensions[queque].dimension_two_text.ToUpper();
            label1.Text.ToUpper();
            label2.Text.ToUpper();
            pictureBox1.Image = Utils.byteToImg(dimensions[queque].dimension_one_image);
            pictureBox2.Image = Utils.byteToImg(dimensions[queque].dimension_two_image);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
