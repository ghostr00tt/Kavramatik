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
    public partial class DirectionsSingle : Form
    {
        private List<directions> directions;
        public DirectionsSingle()
        {
            InitializeComponent();
        }
        ToolTip Aciklama = new ToolTip();
        WebBrowser webBrowser1 = new WebBrowser();
        private async void DirectionsSingle_Load(object sender, EventArgs e)
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
            label1.Text = directions[0].direction_text.ToUpper();



            pictureBox1.Image = Utils.byteToImg(directions[0].direction_image);

        }






        int queque = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            queque++;
            if (queque > directions.Count - 1)
            {
                queque = 0;
            }
            label1.Text = directions[queque].direction_text.ToUpper();

            pictureBox1.Image = Utils.byteToImg(directions[queque].direction_image);

            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            queque--;
            if (queque < 0)
            {
                queque = directions.Count - 1;
            }

            label1.Text = directions[queque].direction_text.ToUpper();



            pictureBox1.Image = Utils.byteToImg(directions[queque].direction_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = directions[queque].direction_text;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, directions[queque].direction_text);
        }
    }
}
