using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Kavramatik.cs
{
    public partial class ConceptLearningDirections : Form
    {

        public ConceptLearningDirections()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.bing.com/translator/?from=tr&to=en");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        bool reverse;
        public List<directions> directions;
        public int index;
        int randomizedIndex;
        Random rnd = new Random();




        int iteration = 1;
        private void Game1()
        {
            do
            {
                randomizedIndex = rnd.Next(0, 5);
            } while (randomizedIndex == index);

            reverse = false;
            pictureBox1.Image = Utils.byteToImg(directions[index].direction_image);
            pictureBox2.Image = Utils.byteToImg(directions[randomizedIndex].direction_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        private void Game2()
        {

            do
            {
                randomizedIndex = rnd.Next(0, 5);
            } while (randomizedIndex == index);

            reverse = true;
            pictureBox2.Image = Utils.byteToImg(directions[index].direction_image);
            pictureBox1.Image = Utils.byteToImg(directions[randomizedIndex].direction_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Game3()
        {
            do
            {
                randomizedIndex = rnd.Next(0, 5);
            } while (randomizedIndex == index);

            reverse = false;
            pictureBox1.Image = Utils.byteToImg(directions[index].direction_image);
            pictureBox2.Image = Utils.byteToImg(directions[randomizedIndex].direction_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Game4()
        {
            do
            {
                randomizedIndex = rnd.Next(0, 5);
            } while (randomizedIndex == index);

            reverse = true;
            pictureBox2.Image = Utils.byteToImg(directions[index].direction_image);
            pictureBox1.Image = Utils.byteToImg(directions[randomizedIndex].direction_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private int RandomGenerator(int index)
        {
            var exclude = new HashSet<int>() { index };
            var range = Enumerable.Range(1, 9).Where(i => !exclude.Contains(i));

            var rand = new System.Random();
            int indexTemp = rand.Next(0, 9 - range.Count());
            return range.ElementAt(index);
        }


        WebBrowser webBrowser1 = new WebBrowser();
        ToolTip Aciklama = new ToolTip();
        private void ConceptLearningDirections_Load(object sender, EventArgs e)
        {   
            label1.Text = directions[index].direction_name + " olan konuma tıkla";
        
              

            
         
            bunifuThinButton22.BackColor = Color.Transparent;
            Game1();
            bunifuThinButton21.Visible = false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (reverse == false)
            {
                iteration++;
                if (iteration == 5)
                {
                    bunifuThinButton21.Visible = true;
                    label1.Text = "Tebrikler, " + directions[index].direction_name + " konumunu tamamladın.Ana menüye dön butonu ile çıkabilirsin.";
                    Properties.Settings.Default.directions = Properties.Settings.Default.directions + index + " ";
                    bunifuThinButton21.ButtonText = "Ana Menüye Dön";
                }

                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = directions[index].direction_text + " konumunu buldun, Tebrikler";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1, directions[index].direction_text);




                MessageBox.Show("Harikasın");
                if (iteration == 2)
                {
                    Game2();
                }

                if (iteration == 3)
                {
                    Game3();
                }

                if (iteration == 4)
                {
                    Game4();

                }


            }
            else
            {
                int kontrol = Properties.Settings.Default.directions.IndexOf(randomizedIndex.ToString());
                if (kontrol == -1)
                {
                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText =  directions[index].direction_text + "değildir";
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                    Aciklama.SetToolTip(pictureBox1, directions[randomizedIndex].direction_text);
                }
                else
                {
                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = directions[randomizedIndex].direction_text;
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                    Aciklama.SetToolTip(pictureBox1, directions[randomizedIndex].direction_text);
                }



            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (reverse == false)
            {
                int kontrol = Properties.Settings.Default.directions.IndexOf(randomizedIndex.ToString());
                if (kontrol == -1)
                {
                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText =  directions[index].direction_text + "değil";
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                    Aciklama.SetToolTip(pictureBox2, directions[randomizedIndex].direction_text);
                }
                else
                {

                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = directions[randomizedIndex].direction_text;
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                    Aciklama.SetToolTip(pictureBox2, directions[randomizedIndex].direction_text);
                }

            }
            else
            {


                iteration++;
                if (iteration == 5)
                {
                    bunifuThinButton21.Visible = true;
                    label1.Text = "Tebrikler, " + directions[index].direction_name + " konumunu tamamladın.Ana menüye dön butonu ile çıkabilirsin.";
                    Properties.Settings.Default.directions = Properties.Settings.Default.directions + index + " ";
                    bunifuThinButton21.ButtonText = "Ana Menüye Dön";
                }
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = directions[index].direction_text + " konumunu buldun, tebrikler";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, directions[index].direction_text);
                MessageBox.Show("Harikasın");
                if (iteration == 2)
                {
                    Game2();
                }

                if (iteration == 3)
                {
                    Game3();
                }

                if (iteration == 4)
                {
                    Game4();

                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            ConceptTrainingShapes concept = new ConceptTrainingShapes();
            concept.index = this.index;
            concept.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Directions directions = new Directions();
            directions.Show();
            this.Hide();
        }

    }
}
