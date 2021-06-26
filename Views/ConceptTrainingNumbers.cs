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
    public partial class ConceptTrainingNumbers : Form
    {
        bool reverse;
        public List<numbers> numbers;
        public int index;
        int randomizedIndex;
        Random rnd = new Random();
        int iteration = 1;
        public ConceptTrainingNumbers()
        {
            InitializeComponent();
        }

        WebBrowser webBrowser1 = new WebBrowser();
        ToolTip Aciklama = new ToolTip();
        private void ConceptTrainingNumbers_Load(object sender, EventArgs e)
        {
            label1.Text = numbers[index].number_name + " rakamını tanımaya ne dersin ? ";
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

        public void Training1()
        {
            reverse = false;
            do
            {
                randomizedIndex = rnd.Next(0, 9);
            } while (randomizedIndex == index);
            pictureBox1.Image = Utils.byteToImg(numbers[index].number_one_image);
            pictureBox2.Image = Utils.byteToImg(numbers[randomizedIndex].number_one_image);
            label2.Text = numbers[index].number_name.ToString();
            label3.Text = "Bu rakam " + numbers[index].number_name.ToString() + " değildir ";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void Training2()
        {
            reverse = true;
            do
            {
                randomizedIndex = rnd.Next(0, 9);
            } while (randomizedIndex == index);
            pictureBox2.Image = Utils.byteToImg(numbers[index].number_one_image);
            pictureBox1.Image = Utils.byteToImg(numbers[randomizedIndex].number_one_image);
            label3.Text = numbers[index].number_name.ToString();
            label2.Text = "Bu rakam " + numbers[index].number_name.ToString() + " değildir ";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void Training3()
        {
            reverse = false;
            do
            {
                randomizedIndex = rnd.Next(0, 9);
            } while (randomizedIndex == index);
            pictureBox1.Image = Utils.byteToImg(numbers[index].number_one_image);
            pictureBox2.Image = Utils.byteToImg(numbers[randomizedIndex].number_one_image);
            label2.Text = numbers[index].number_name.ToString();
            label3.Text = "Bu rakam " + numbers[index].number_name.ToString() + " değildir ";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void Training4()
        {
            reverse = true;
            do
            {
                randomizedIndex = rnd.Next(0, 9);
            } while (randomizedIndex == index);
            pictureBox2.Image = Utils.byteToImg(numbers[index].number_one_image);
            pictureBox1.Image = Utils.byteToImg(numbers[randomizedIndex].number_one_image);
            label3.Text = numbers[index].number_name.ToString();
            label2.Text = "Bu rakam" + numbers[index].number_name.ToString() + " değildir ";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
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
            if (iteration == 5)
            {
                ConceptLearningNumbers conceptLearning = new ConceptLearningNumbers();
                conceptLearning.numbers = this.numbers;
                conceptLearning.index = this.index;
                conceptLearning.Show();
                this.Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (reverse == false)
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = numbers[index].number_one_text;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1, numbers[index].number_one_text);


            }
            else
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu rakam " + numbers[index].number_one_text + "değildir";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1, "Bu rakam " + numbers[index].number_one_text + " değildir");

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (reverse == false)
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu rakam " + numbers[index].number_one_text + "değildir";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, "Bu rakam" + numbers[index].number_one_text + "değildir");

            }
            else
            {

                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = numbers[index].number_one_text;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, numbers[index].number_one_text);

                iteration++;

            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Numbers numbers = new Numbers();
            numbers.Show();
            this.Hide();
        }

    }
}
