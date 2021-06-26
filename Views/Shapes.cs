using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace Kavramatik.cs
{
    public partial class Shapes : Form
    {
        private List<shapes> shapes;
        public Shapes()
        {
            InitializeComponent();
        }

        public void FillBoxes()
        {

            pictureBox1.Image = Utils.byteToImg(shapes[0].shape_image);
            label1.Text = shapes[0].shape_name;




            pictureBox2.Image = Utils.byteToImg(shapes[2].shape_image);
            label2.Text = shapes[2].shape_name;

            pictureBox3.Image = Utils.byteToImg(shapes[4].shape_image);
            label3.Text = shapes[4].shape_name;

            pictureBox4.Image = Utils.byteToImg(shapes[6].shape_image);
            label4.Text = shapes[6].shape_name;

            pictureBox5.Image = Utils.byteToImg(shapes[8].shape_image);
            label5.Text = shapes[8].shape_name;

           

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }
        public bool check(int a)
        {
            bool check = false;
            int kontrol = Properties.Settings.Default.shapes.IndexOf(a.ToString());
            if (kontrol != -1)
            {
                check = true;
                return check;
            }
            else
            {
                return check;
            }
        }
      
        WebBrowser webBrowser1 = new WebBrowser();
        ToolTip Aciklama = new ToolTip();
        private async void Shapes_Load(object sender, EventArgs e)
        {
            if(check(0) == false)
            {
                label6.Visible = false;
            }
            

            if (check(1) == false)
            {
                label7.Visible = false;
            }
            if (check(2) == false)
            {
                label8.Visible = false;
            }
            if (check(3) == false)
            {
                label9.Visible = false;
            }
            if (check(4) == false)
            {
                label10.Visible = false;
            }







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
            HttpResponseMessage responseMessage = await client.GetAsync("shapes?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            shapes = JsonConvert.DeserializeObject<List<shapes>>(result);
            FillBoxes();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = shapes[1].shape_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox2, shapes[1].shape_name);
            ConceptTrainingShapes conceptLearning = new ConceptTrainingShapes();
            conceptLearning.shapes = this.shapes;
            conceptLearning.index = 2;
            conceptLearning.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = shapes[0].shape_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox1, shapes[0].shape_name);
            ConceptTrainingShapes conceptLearning = new ConceptTrainingShapes();
            conceptLearning.shapes = this.shapes;
            conceptLearning.index = 0;
            conceptLearning.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = shapes[2].shape_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox3, shapes[2].shape_name);
            ConceptTrainingShapes conceptLearning = new ConceptTrainingShapes();
            conceptLearning.shapes = this.shapes;
            conceptLearning.index = 4;
            conceptLearning.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = shapes[3].shape_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox4, shapes[3].shape_name);
            ConceptTrainingShapes conceptLearning = new ConceptTrainingShapes();
            conceptLearning.shapes = this.shapes;
            conceptLearning.index = 6;
            conceptLearning.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tta_input_ta").InnerText = shapes[4].shape_name;
            webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            Aciklama.SetToolTip(pictureBox5, shapes[4].shape_name);
            ConceptTrainingShapes conceptLearning = new ConceptTrainingShapes();
            conceptLearning.shapes = this.shapes;
            conceptLearning.index = 8;
            conceptLearning.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
