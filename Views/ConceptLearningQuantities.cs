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
    public partial class ConceptLearningQuantities : Form
    {

        bool reverse;
        public List<quantities> quantities;
        public int index;
        int randomizedIndex;
        Random rnd = new Random();


        public string colname1 = "";
        public ConceptLearningQuantities()
        {
            InitializeComponent();
        }
        int iteration = 1;
        private void Game1()
        {

            //string colname2 = quantities[index].quantitiy_name;
            //reverse = false;
            //do
            //{
            //    randomizedIndex = rnd.Next(0, 30);
            //    colname1 = quantities[randomizedIndex].quantitiy_name;
            //    if (colname1 == colname2)
            //    {
            //        randomizedIndex = rnd.Next(0, 30);
            //        colname1 = quantities[randomizedIndex].quantitiy_name;

            //    }

            //} while (randomizedIndex == index && colname1 == colname2);
            reverse = false;

            randomizedIndex = index;


            pictureBox1.Image = Utils.byteToImg(quantities[index].quantitiy_one_image);
            pictureBox2.Image = Utils.byteToImg(quantities[randomizedIndex].quantitiy_two_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;


        }
        private void Game2()
        {
            index = index + 1;
            string colname2 = quantities[index].quantitiy_name;
            reverse = true;
            //do
            //{
            //    randomizedIndex = rnd.Next(0, 30);
            //    colname1 = quantities[randomizedIndex].quantitiy_name;
            //    if (colname1 == colname2)
            //    {
            //        randomizedIndex = rnd.Next(0, 30);
            //        colname1 = quantities[randomizedIndex].quantitiy_name;

            //    }

            //} while (randomizedIndex == index && colname1 == colname2);
            randomizedIndex = index;
            pictureBox2.Image = Utils.byteToImg(quantities[index].quantitiy_two_image);
            pictureBox1.Image = Utils.byteToImg(quantities[randomizedIndex].quantitiy_one_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Game3()
        {
            index = index + 1;
            string colname2 = quantities[index].quantitiy_name;
            reverse = false;
            //do
            //{
            //    randomizedIndex = rnd.Next(0, 30);
            //    colname1 = quantities[randomizedIndex].quantitiy_name;
            //    if (colname1 == colname2)
            //    {
            //        randomizedIndex = rnd.Next(0, 30);
            //        colname1 = quantities[randomizedIndex].quantitiy_name;

            //    }

            //} while (randomizedIndex == index && colname1 == colname2);
            randomizedIndex = index;

            pictureBox1.Image = Utils.byteToImg(quantities[index].quantitiy_one_image);
            pictureBox2.Image = Utils.byteToImg(quantities[randomizedIndex].quantitiy_two_image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Game4()
        {
            index = index + 1;
            string colname2 = quantities[index].quantitiy_name;
            reverse = true;
            //do
            //{
            //    randomizedIndex = rnd.Next(0, 30);
            //    colname1 = quantities[randomizedIndex].quantitiy_name;
            //    if (colname1 == colname2)
            //    {
            //        randomizedIndex = rnd.Next(0, 30);
            //        colname1 = quantities[randomizedIndex].quantitiy_name;

            //    }

            //} while (randomizedIndex == index && colname1 == colname2);
            randomizedIndex = index;

            pictureBox2.Image = Utils.byteToImg(quantities[index].quantitiy_two_image);
            pictureBox1.Image = Utils.byteToImg(quantities[randomizedIndex].quantitiy_one_image);
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
        private void ConceptLearningQuantities_Load(object sender, EventArgs e)
        {
            label1.Text = quantities[index].quantitiy_one_text + "  olana  tıkla";
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
                    label1.Text = "Tebrikler, " + quantities[index].quantitiy_name + "'i tamamladın.Ana menüye dön butonu ile çıkabilirsin.";
                    Properties.Settings.Default.quantities = Properties.Settings.Default.quantities + index + " ";
                    bunifuThinButton21.ButtonText = "Ana Menüye Dön";
                }

                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = quantities[index].quantitiy_name + "olanı buldun, Tebrikler";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1, quantities[index].quantitiy_name);




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
                int kontrol = Properties.Settings.Default.quantities.IndexOf(randomizedIndex.ToString());
                if (kontrol == -1)
                {
                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu şekil " + quantities[index].quantitiy_one_text + " değildir";
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                    Aciklama.SetToolTip(pictureBox1, quantities[randomizedIndex].quantitiy_one_text);
                }
                else
                {
                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = quantities[randomizedIndex].quantitiy_two_text;
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                    Aciklama.SetToolTip(pictureBox1, quantities[randomizedIndex].quantitiy_two_text);
                }



            }












            //if(reverse == false)
            //{
            //    iteration++;
            //    if (iteration == 5)
            //    {
            //        bunifuThinButton21.Visible = true;
            //        label1.Text = "Tebrikler, " + quantities[index].quantitiy_name + " rengi tamamladın.Ana menüye dön butonu ile çıkabilirsin.";
            //        Properties.Settings.Default.quantities = Properties.Settings.Default.quantities + index + " ";
            //        bunifuThinButton21.ButtonText = "Ana Menüye Dön";
            //    }

            //    //webBrowser1.Document.GetElementById("tta_input_ta").InnerText = quantities[index].quantitiy_name + "rengi buldun, Tebrikler";
            //    //webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            //    //Aciklama.SetToolTip(pictureBox1, quantities[index].quantitiy_name);




            //    MessageBox.Show("Harikasın");
            //    if (iteration == 2)
            //    {
            //        Game2();
            //    }

            //    if (iteration == 3)
            //    {
            //        Game2();
            //    }

            //    if (iteration == 4)
            //    {
            //        Game4();

            //    }


            //}
            //else
            //{
            //    int kontrol = Properties.Settings.Default.quantities.IndexOf(randomizedIndex.ToString());
            //    if (kontrol == -1)
            //    {
            //        //webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu renk " + quantities[index].quantitiy_name + "değildir";
            //        //webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            //        //Aciklama.SetToolTip(pictureBox1, quantities[randomizedIndex].quantitiy_name);
            //    }
            //    else
            //    {
            //        //webBrowser1.Document.GetElementById("tta_input_ta").InnerText =  quantities[randomizedIndex].quantitiy_name ;
            //        //webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            //        //Aciklama.SetToolTip(pictureBox1, quantities[randomizedIndex].quantitiy_name);
            //    }



            //}

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


            if (reverse == false)
            {
                int kontrol = Properties.Settings.Default.quantities.IndexOf(randomizedIndex.ToString());
                if (kontrol == -1)
                {

                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu şekil " + quantities[index].quantitiy_one_text + "değildir";
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                    Aciklama.SetToolTip(pictureBox2, quantities[randomizedIndex].quantitiy_one_text);

                }

                else
                {

                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = quantities[randomizedIndex].quantitiy_two_text;
                    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                    Aciklama.SetToolTip(pictureBox2, quantities[randomizedIndex].quantitiy_two_text);
                }

            }
            else
            {


                iteration++;
                if (iteration == 5)
                {
                    bunifuThinButton21.Visible = true;
                    label1.Text = "Tebrikler, " + quantities[index].quantitiy_name + " şekli tamamladın.Ana menüye dön butonu ile çıkabilirsin.";
                    Properties.Settings.Default.quantities = Properties.Settings.Default.quantities + index + " ";
                    bunifuThinButton21.ButtonText = "Ana Menüye Dön";
                }
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = quantities[index].quantitiy_name + "şekli buldun, tebrikler";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, quantities[index].quantitiy_name);
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
            //if (reverse == false)
            //{
            //    int kontrol = Properties.Settings.Default.quantities.IndexOf(randomizedIndex.ToString());
            //    if (kontrol == -1)
            //    {
            //        webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu renk " + quantities[index].quantitiy_name + "değildir";
            //        webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            //        Aciklama.SetToolTip(pictureBox2, quantities[randomizedIndex].quantitiy_name);
            //    }
            //    else
            //    {

            //        webBrowser1.Document.GetElementById("tta_input_ta").InnerText = quantities[randomizedIndex].quantitiy_name;
            //        webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            //        Aciklama.SetToolTip(pictureBox2, quantities[randomizedIndex].quantitiy_name);
            //    }

            //}
            //else
            //{


            //    iteration++;
            //    if (iteration == 5)
            //    {
            //        bunifuThinButton21.Visible = true;
            //        label1.Text = "Tebrikler, " + quantities[index].quantitiy_name + " rengi tamamladın.Ana menüye dön butonu ile çıkabilirsin.";
            //        Properties.Settings.Default.quantities = Properties.Settings.Default.quantities + index + " ";
            //        bunifuThinButton21.ButtonText = "Ana Menüye Dön";
            //    }
            //    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = quantities[index].quantitiy_name + "rengi buldun, tebrikler";
            //    webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            //    Aciklama.SetToolTip(pictureBox2, quantities[index].quantitiy_name);
            //    MessageBox.Show("Harikasın");
            //    if (iteration == 2)
            //    {
            //        Game2();
            //    }

            //    if (iteration == 3)
            //    {
            //        Game3();
            //    }

            //    if (iteration == 4)
            //    {
            //        Game4();

            //    }
            //}
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            ConceptTraining concept = new ConceptTraining();
            concept.index = this.index;
            concept.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DimensionsMulti colorsMulti = new DimensionsMulti();
            colorsMulti.Show();
            this.Hide();
        }

    }
}
