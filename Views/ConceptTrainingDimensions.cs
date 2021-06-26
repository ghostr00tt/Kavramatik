using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kavramatik.cs
{
    public partial class ConceptTrainingDimensions : Form
    {

        bool reverse;
        public List<dimensions> dimensions;
        public int index = 0;
        int randomizedIndex;
        Random rnd = new Random();
        int iteration = 1;
        public ConceptTrainingDimensions()
        {
            InitializeComponent();
        }

        WebBrowser webBrowser1 = new WebBrowser();
        ToolTip Aciklama = new ToolTip();
        private void ConceptTrainingDimensions_Load(object sender, EventArgs e)
        {
            label1.Text = dimensions[index].dimension_name + " boyutunu tanımaya ne dersin ? ";
            try
            {
                webBrowser1.Navigate("https://www.bing.com/translator/?from=tr&to=en");
                webBrowser1.ScriptErrorsSuppressed = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Training1();
            bunifuThinButton22.BackColor = Color.Transparent;

        }
        string colname1 = "";


        public void Training1()
        {
            string colname2 = dimensions[index].dimension_name;

            //do
            //{
            //    int index = rastgele.Next(0, 15);

            //    temp = col[index].color;
            //    colname = col[index].dimension_name;
            //} while (colname == colname2);
            reverse = false;
            randomizedIndex = index;
            pictureBox1.Image = Utils.byteToImg(dimensions[index].dimension_one_image);
            pictureBox2.Image = Utils.byteToImg(dimensions[randomizedIndex].dimension_two_image);

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = dimensions[index].dimension_name.ToString();
            label3.Text = "Bu boyut " + dimensions[index].dimension_name.ToString() + " değildir ";
         
        }

        public void Training2()
        {
            string colname2 = dimensions[index].dimension_name;
            reverse = true;
            index++;
            randomizedIndex = index;
            pictureBox2.Image = Utils.byteToImg(dimensions[index].dimension_one_image);
            pictureBox1.Image = Utils.byteToImg(dimensions[randomizedIndex].dimension_two_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = dimensions[index].dimension_name.ToString();
            label2.Text = "Bu boyut " + dimensions[index].dimension_name.ToString() + " değildir ";
          
        }

        public void Training3()
        {
            string colname2 = dimensions[index].dimension_name;
            reverse = false;
            index++;
            randomizedIndex = index;
            pictureBox1.Image = Utils.byteToImg(dimensions[index].dimension_one_image);
            pictureBox2.Image = Utils.byteToImg(dimensions[randomizedIndex].dimension_two_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = dimensions[index].dimension_name.ToString();
            label3.Text = "Bu boyut " + dimensions[index].dimension_name.ToString() + " değildir ";
          
        }

        public void Training4()
        {
            index++;
            randomizedIndex = index;

         
            pictureBox2.Image = Utils.byteToImg(dimensions[index].dimension_one_image);
            pictureBox1.Image = Utils.byteToImg(dimensions[randomizedIndex].dimension_two_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = dimensions[index].dimension_name.ToString();
            label2.Text = "Bu boyut " + dimensions[index].dimension_name.ToString() + " değildir ";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            iteration++;


            if (iteration == 2)
            {
                Training2();
            }

            if (iteration == 3)
            {
                Training3();
            }

            if (iteration == 4)
            {
                Training4();
                bunifuThinButton21.ButtonText = "Alıştırmaya Geç";
            }
            if (iteration == 5 || iteration > 4)
            {

                ConceptLearningDimensions conceptLearning = new ConceptLearningDimensions();
                conceptLearning.dimensions = this.dimensions;
                conceptLearning.index = (this.index - 3 );
                conceptLearning.Show();
                this.Hide();

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (reverse == false)
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = dimensions[index].dimension_name;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1, dimensions[index].dimension_name);


            }
            else
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu boyut " + dimensions[index].dimension_name + " değildir";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1, "Bu boyut " + dimensions[index].dimension_name + " değildir");

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (reverse == false)
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu boyut " + dimensions[index].dimension_name + " değildir";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, "Bu boyut " + dimensions[index].dimension_name + " değildir");

            }
            else
            {

                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = dimensions[index].dimension_name;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, dimensions[index].dimension_name);

                iteration++;

            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DimensionsMulti dimensions = new DimensionsMulti();
            dimensions.Show();
            this.Hide();
        }
    }
}
