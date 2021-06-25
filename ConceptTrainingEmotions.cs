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
    public partial class ConceptTrainingEmotions : Form
    {
        bool reverse;
        public List<emotions> emotions;
        public int index;
        int randomizedIndex;
        Random rnd = new Random();
        int iteration = 1;
        public ConceptTrainingEmotions()
        {
            InitializeComponent();
        }

        WebBrowser webBrowser1 = new WebBrowser();
        ToolTip Aciklama = new ToolTip();
        private void ConceptTrainingEmotions_Load(object sender, EventArgs e)
        {
            label1.Text = emotions[index].emotion_name + " duygusunu tanımaya ne dersin ? ";
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
                randomizedIndex = rnd.Next(0, 4);
            } while (randomizedIndex == index);
            pictureBox1.Image = Utils.byteToImg(emotions[index].emotion_image);
            pictureBox2.Image = Utils.byteToImg(emotions[randomizedIndex].emotion_image);

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = emotions[index].emotion_name.ToString();
            label3.Text = "Bu duygu " + emotions[index].emotion_name.ToString() + " değildir ";
        }

        public void Training2()
        {
            reverse = true; 
            do
            {
                randomizedIndex = rnd.Next(0, 4);
            } while (randomizedIndex == index);
            pictureBox2.Image = Utils.byteToImg(emotions[index].emotion_image);
            pictureBox1.Image = Utils.byteToImg(emotions[randomizedIndex].emotion_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = emotions[index].emotion_name.ToString();
            label2.Text = " Bu duygu " + emotions[index].emotion_name.ToString() + " değildir ";
        }

        public void Training3()
        {
            int temp = 0;
            reverse = false;
            do
            {
                temp = randomizedIndex;
                
               
                if (temp == randomizedIndex)
                {
                    randomizedIndex = rnd.Next(0, 4);
                }
                
            } while (randomizedIndex == index);
            pictureBox1.Image = Utils.byteToImg(emotions[index].emotion_image);
            pictureBox2.Image = Utils.byteToImg(emotions[randomizedIndex].emotion_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = emotions[index].emotion_name.ToString();
            label3.Text = "Bu duygu " + emotions[index].emotion_name.ToString() + " değildir ";
        }

        public void Training4()
        {
            reverse = true;
            do
            {
                randomizedIndex = rnd.Next(0, 4);
            } while (randomizedIndex == index);
            pictureBox2.Image = Utils.byteToImg(emotions[index].emotion_image);
            pictureBox1.Image = Utils.byteToImg(emotions[randomizedIndex].emotion_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = emotions[index].emotion_name.ToString();
            label2.Text = "Bu duygu " + emotions[index].emotion_name.ToString() + " değildir ";
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
                ConceptLearningEmotions conceptLearning = new ConceptLearningEmotions();
                conceptLearning.emotions = this.emotions;
                conceptLearning.index = this.index;
                conceptLearning.Show();
                this.Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (reverse == false)
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = emotions[index].emotion_text;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1, emotions[index].emotion_text);


            }
            else
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu duygu " + emotions[index].emotion_text + "değildir";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1, "Bu duygu " + emotions[index].emotion_text + " değildir");

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (reverse == false)
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu duygu " + emotions[index].emotion_text + "değildir";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, "Bu duygu" + emotions[index].emotion_text + "değildir");

            }
            else
            {

                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = emotions[index].emotion_text;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, emotions[index].emotion_text);

                iteration++;

            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            ColorsMulti emotions = new ColorsMulti();
            emotions.Show();
            this.Hide();
        }

    }
}
