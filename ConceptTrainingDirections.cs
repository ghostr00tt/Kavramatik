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
    public partial class ConceptTrainingDirections : Form
    {
        bool reverse;
        public List<directions> directions;
        public int index;
        int randomizedIndex;
        Random rnd = new Random();
        int iteration = 1;
        public ConceptTrainingDirections()
        {
            InitializeComponent();
        }

        WebBrowser webBrowser1 = new WebBrowser();
        ToolTip Aciklama = new ToolTip();
        private void ConceptTrainingDirections_Load(object sender, EventArgs e)
        {
            label1.Text = directions[index].direction_name + " kavramını tanımaya ne dersin ? ";
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
                randomizedIndex = rnd.Next(0, 5);
            } while (randomizedIndex == index);
            pictureBox1.Image = Utils.byteToImg(directions[index].direction_image);
            pictureBox2.Image = Utils.byteToImg(directions[randomizedIndex].direction_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = directions[index].direction_name.ToString();
            label3.Text =  directions[index].direction_name.ToString() + " değil ";
        }

        public void Training2()
        {
            reverse = true;
            do
            {
                randomizedIndex = rnd.Next(0, 5);
            } while (randomizedIndex == index);
            pictureBox2.Image = Utils.byteToImg(directions[index].direction_image);
            pictureBox1.Image = Utils.byteToImg(directions[randomizedIndex].direction_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = directions[index].direction_name.ToString();
            label2.Text =   directions[index].direction_name.ToString() + " değil ";
        }

        public void Training3()
        {
            reverse = false;
            do
            {
                randomizedIndex = rnd.Next(0, 5);
            } while (randomizedIndex == index);
            pictureBox1.Image = Utils.byteToImg(directions[index].direction_image);
            pictureBox2.Image = Utils.byteToImg(directions[randomizedIndex].direction_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = directions[index].direction_name.ToString();
            label3.Text =  directions[index].direction_name.ToString() + " değil";
        }

        public void Training4()
        {
            reverse = true;
            do
            {
                randomizedIndex = rnd.Next(0, 5);
            } while (randomizedIndex == index);
            pictureBox2.Image = Utils.byteToImg(directions[index].direction_image);
            pictureBox1.Image = Utils.byteToImg(directions[randomizedIndex].direction_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = directions[index].direction_name.ToString();
            label2.Text =  directions[index].direction_name.ToString() + " değil ";
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
                ConceptLearningDirections conceptLearning = new ConceptLearningDirections();
                conceptLearning.directions = this.directions;
                conceptLearning.index = this.index;
                conceptLearning.Show();
                this.Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (reverse == false)
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = directions[index].direction_text;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1, directions[index].direction_text);


            }
            else
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = directions[index].direction_text + "değil";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1,  directions[index].direction_text + " değil");

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (reverse == false)
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = directions[index].direction_text + "değil";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, directions[index].direction_text + "değil");

            }
            else
            {

                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = directions[index].direction_text;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, directions[index].direction_text);

                iteration++;

            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            ColorsMulti directions = new ColorsMulti();
            directions.Show();
            this.Hide();
        }


    }
}
