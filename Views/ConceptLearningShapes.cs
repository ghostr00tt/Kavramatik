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
    public partial class ConceptLearningShapes : Form
    {
        public ConceptLearningShapes()
        {
            InitializeComponent();
        }

        bool reverse;
        public List<shapes> shapes;
        public int index;
        int randomizedIndex;
        Random rnd = new Random();



        string colname1 = "";
        int iteration = 1;
        private void Game1()
        {
            string colname2 = shapes[index].shape_name;
            do
            {
                randomizedIndex = rnd.Next(0, 9);
                colname1 = shapes[randomizedIndex].shape_name;
                if (colname1 == colname2)
                {
                    randomizedIndex = rnd.Next(0, 9);
                    colname1 = shapes[randomizedIndex].shape_name;

                }

            } while (randomizedIndex == index && colname1 == colname2);

            reverse = false;
            randomizedIndex = index + 2;
            if (index >= 6)
            {
                randomizedIndex = index - 1;
            }
            pictureBox1.Image = Utils.byteToImg(shapes[index].shape_image);
            pictureBox2.Image = Utils.byteToImg(shapes[randomizedIndex].shape_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        private void Game2()
        {

            string colname2 = shapes[index].shape_name;
            do
            {
                randomizedIndex = rnd.Next(0, 9);
                colname1 = shapes[randomizedIndex].shape_name;
                if (colname1 == colname2)
                {
                    randomizedIndex = rnd.Next(0, 9);
                    colname1 = shapes[randomizedIndex].shape_name;

                }

            } while (randomizedIndex == index && colname1 == colname2);

            reverse = true;

            randomizedIndex = index + 3;
            if (index >= 6)
            {
                randomizedIndex = index - 3;
            }
            pictureBox2.Image = Utils.byteToImg(shapes[index].shape_image);
            pictureBox1.Image = Utils.byteToImg(shapes[randomizedIndex].shape_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Game3()
        {
            string colname2 = shapes[index].shape_name;
            do
            {
                randomizedIndex = rnd.Next(0, 9);
                colname1 = shapes[randomizedIndex].shape_name;
                if (colname1 == colname2)
                {
                    randomizedIndex = rnd.Next(0, 9);
                    colname1 = shapes[randomizedIndex].shape_name;

                }

            } while (randomizedIndex == index && colname1 == colname2);

            reverse = false;
            randomizedIndex = index + 4;
            if (index >= 6)
            {
                randomizedIndex = index - 4;
            }
            pictureBox1.Image = Utils.byteToImg(shapes[index].shape_image);
            pictureBox2.Image = Utils.byteToImg(shapes[randomizedIndex].shape_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Game4()
        {
            string colname2 = shapes[index].shape_name;
            do
            {
                randomizedIndex = rnd.Next(0, 9);
                colname1 = shapes[randomizedIndex].shape_name;
                if (colname1 == colname2)
                {
                    randomizedIndex = rnd.Next(0, 9);
                    colname1 = shapes[randomizedIndex].shape_name;

                }

            } while (randomizedIndex == index && colname1 == colname2);

            reverse = true;

            randomizedIndex = index + 5;
            if (index >= 6)
            {
                randomizedIndex = index - 5;
            }
            pictureBox2.Image = Utils.byteToImg(shapes[index].shape_image);
            pictureBox1.Image = Utils.byteToImg(shapes[randomizedIndex].shape_image);
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
        private void ConceptLearningShapes_Load(object sender, EventArgs e)
        {
            label1.Text = shapes[index].shape_name + " olan şekle tıkla";
            try
            {
                webBrowser1.Navigate("https://www.bing.com/translator/?from=tr&to=en");
                webBrowser1.ScriptErrorsSuppressed = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    label1.Text = "Tebrikler, " + shapes[index].shape_name + " şekli tamamladın.Ana menüye dön butonu ile çıkabilirsin.";
                    Properties.Settings.Default.shapes = Properties.Settings.Default.shapes + index + " ";
                    bunifuThinButton21.ButtonText = "Ana Menüye Dön";
                }

                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = shapes[index].shape_text + "şekli buldun, Tebrikler";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1, shapes[index].shape_text);




                MessageBox.Show("Harikasın");
                if (iteration == 2)
                {
                    Game2();
                }

                if (iteration == 3)
                {
                    Game2();
                }

                if (iteration == 4)
                {
                    Game4();

                }


            }
            else
            {
                int kontrol = Properties.Settings.Default.shapes.IndexOf(randomizedIndex.ToString());
                if (kontrol == -1)
                {
                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu şekil " + shapes[index].shape_text + "değildir";
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                    Aciklama.SetToolTip(pictureBox1, shapes[randomizedIndex].shape_text);
                }
                else
                {
                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = shapes[randomizedIndex].shape_text;
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                    Aciklama.SetToolTip(pictureBox1, shapes[randomizedIndex].shape_text);
                }



            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (reverse == false)
            {
                int kontrol = Properties.Settings.Default.shapes.IndexOf(randomizedIndex.ToString());
                if (kontrol == -1)
                {
                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu şekil " + shapes[index].shape_text + "değildir";
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                    Aciklama.SetToolTip(pictureBox2, shapes[randomizedIndex].shape_text);
                }
                else
                {

                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = shapes[randomizedIndex].shape_text;
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                    Aciklama.SetToolTip(pictureBox2, shapes[randomizedIndex].shape_text);
                }

            }
            else
            {


                iteration++;
                if (iteration == 5)
                {
                    bunifuThinButton21.Visible = true;
                    label1.Text = "Tebrikler, " + shapes[index].shape_name + " şekli tamamladın.Ana menüye dön butonu ile çıkabilirsin.";
                    Properties.Settings.Default.shapes = Properties.Settings.Default.shapes + index + " ";
                    bunifuThinButton21.ButtonText = "Ana Menüye Dön";
                }
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = shapes[index].shape_text + "şekli buldun, tebrikler";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, shapes[index].shape_text);
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
            Shapes colorsMulti = new Shapes();
            colorsMulti.Show();
            this.Hide();
        }
    }
}
