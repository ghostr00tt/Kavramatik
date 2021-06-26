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
    public partial class Colors : Form
    {
        private List<colors> colors;
        public Colors()
        {
            InitializeComponent();
            label1.Text = "";
        }
        ToolTip Aciklama = new ToolTip();
        WebBrowser webBrowser1 = new WebBrowser();
        private async void Colors_Load(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Navigate("https://www.bing.com/translator/?from=tr&to=en");
                webBrowser1.ScriptErrorsSuppressed = true;
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var client = new HttpClient();
            client.BaseAddress = new Uri(Utils.BASE_URL);
            HttpResponseMessage responseMessage = await client.GetAsync("colors?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            colors = JsonConvert.DeserializeObject<List<colors>>(result);
            //label1.Text = colors[0].color_name.ToUpper();



            //pictureBox1.Image = Utils.byteToImg(colors[0].color);

        }






        int queque = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            queque++;
            if (queque > colors.Count - 1)
            {
                queque = 0;
            }
            //label1.Text = colors[queque].color_name.ToUpper();

            //pictureBox1.Image = Utils.byteToImg(colors[queque].color);
      

        }

        private void button2_Click(object sender, EventArgs e)
        {
            queque--;
            if (queque < 0)
            {
                queque = colors.Count - 1;
            }

            label1.Text = colors[queque].color_name.ToUpper();
           
          

            pictureBox1.Image = Utils.byteToImg(colors[queque].color);
       

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = colors[queque].color_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, colors[queque].color_name);
        }
    }
}
