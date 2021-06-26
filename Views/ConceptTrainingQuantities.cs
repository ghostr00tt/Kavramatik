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
    public partial class ConceptTrainingQuantities : Form
    {

        bool reverse;
        public List<quantities> quantities;
        public int index = 0;
        int randomizedIndex;
        Random rnd = new Random();
        int iteration = 1;
        public ConceptTrainingQuantities()
        {
            InitializeComponent();
        }

        WebBrowser webBrowser1 = new WebBrowser();
        ToolTip Aciklama = new ToolTip();
        private void ConceptTrainingQuantities_Load(object sender, EventArgs e)
        {
            label1.Text = quantities[index].quantitiy_name + " boyutunu tanımaya ne dersin ? ";
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
            string colname2 = quantities[index].quantitiy_name;

            //do
            //{
            //    int index = rastgele.Next(0, 15);

            //    temp = col[index].color;
            //    colname = col[index].quantitiy_name;
            //} while (colname == colname2);
            reverse = false;
            randomizedIndex = index;
            pictureBox1.Image = Utils.byteToImg(quantities[index].quantitiy_one_image);
            pictureBox2.Image = Utils.byteToImg(quantities[randomizedIndex].quantitiy_two_image);

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = quantities[index].quantitiy_name.ToString();
            label3.Text = " " + quantities[index].quantitiy_name.ToString() + " değildir ";

        }

        public void Training2()
        {
            string colname2 = quantities[index].quantitiy_name;
            reverse = true;
            index++;
            randomizedIndex = index;
            pictureBox2.Image = Utils.byteToImg(quantities[index].quantitiy_one_image);
            pictureBox1.Image = Utils.byteToImg(quantities[randomizedIndex].quantitiy_two_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = quantities[index].quantitiy_name.ToString();
            label2.Text = " " + quantities[index].quantitiy_name.ToString() + " değildir ";

        }

        public void Training3()
        {
            string colname2 = quantities[index].quantitiy_name;
            reverse = false;
            index++;
            randomizedIndex = index;
            pictureBox1.Image = Utils.byteToImg(quantities[index].quantitiy_one_image);
            pictureBox2.Image = Utils.byteToImg(quantities[randomizedIndex].quantitiy_two_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = quantities[index].quantitiy_name.ToString();
            label3.Text = " " + quantities[index].quantitiy_name.ToString() + " değildir ";

        }

        public void Training4()
        {
            index++;
            randomizedIndex = index;

            reverse = true;
            pictureBox2.Image = Utils.byteToImg(quantities[index].quantitiy_one_image);
            pictureBox1.Image = Utils.byteToImg(quantities[randomizedIndex].quantitiy_two_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = quantities[index].quantitiy_name.ToString();
            label2.Text = " " + quantities[index].quantitiy_name.ToString() + " değildir ";
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

                ConceptLearningQuantities conceptLearning = new ConceptLearningQuantities();
                conceptLearning.quantities = this.quantities;
                conceptLearning.index = (this.index - 3);
                conceptLearning.Show();
                this.Hide();

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (reverse == false)
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = quantities[index].quantitiy_name;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1, quantities[index].quantitiy_name);


            }
            else
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = " " + quantities[index].quantitiy_name + " değildir";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1, " " + quantities[index].quantitiy_name + " değildir");

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (reverse == false)
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = " " + quantities[index].quantitiy_name + " değildir";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, " " + quantities[index].quantitiy_name + " değildir");

            }
            else
            {

                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = quantities[index].quantitiy_name;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, quantities[index].quantitiy_name);

                iteration++;

            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DimensionsMulti quantities = new DimensionsMulti();
            quantities.Show();
            this.Hide();
        }

    }
}
