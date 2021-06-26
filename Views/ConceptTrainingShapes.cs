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
    public partial class ConceptTrainingShapes : Form
    {
        bool reverse;
        public List<shapes> shapes;
        public int index;
        int randomizedIndex;
        Random rnd = new Random();
        int iteration = 1;
        public ConceptTrainingShapes()
        {
            InitializeComponent();
        }

        WebBrowser webBrowser1 = new WebBrowser();
        ToolTip Aciklama = new ToolTip();
        private void ConceptTrainingShapes_Load(object sender, EventArgs e)
        {
            label1.Text = shapes[index].shape_name + " şekli tanımaya ne dersin ? ";
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

            reverse = false;
      
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

            randomizedIndex = index + 2;
            if (index >= 6)
            {
                randomizedIndex = index - 1;
            }
            pictureBox1.Image = Utils.byteToImg(shapes[index].shape_image);
            pictureBox2.Image = Utils.byteToImg(shapes[randomizedIndex].shape_image);
            label2.Text = shapes[index].shape_name.ToString();
            label3.Text = "Bu şekil " + shapes[index].shape_name.ToString() + " değildir ";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void Training2()
        {
            Random rnd = new Random();
            reverse = true;
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

       
            pictureBox2.Image = Utils.byteToImg(shapes[index].shape_image);
            pictureBox1.Image = Utils.byteToImg(shapes[randomizedIndex].shape_image);
            label3.Text = shapes[index].shape_name.ToString();
            label2.Text = "Bu şekil " + shapes[index].shape_name.ToString() + " değildir ";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void Training3()
        {
          
            reverse = false;
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
       
            pictureBox1.Image = Utils.byteToImg(shapes[index].shape_image);
            pictureBox2.Image = Utils.byteToImg(shapes[randomizedIndex].shape_image);
            label2.Text = shapes[index].shape_name.ToString();
            label3.Text = "Bu şekil " + shapes[index].shape_name.ToString() + " değildir ";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void Training4()
        {
            reverse = true;
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

    
            pictureBox2.Image = Utils.byteToImg(shapes[index].shape_image);
            pictureBox1.Image = Utils.byteToImg(shapes[randomizedIndex].shape_image);
            label3.Text = shapes[index].shape_name.ToString();
            label2.Text = "Bu şekil" + shapes[index].shape_name.ToString() + " değildir ";
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
                ConceptLearningShapes conceptLearning = new ConceptLearningShapes();
                conceptLearning.shapes = this.shapes;
                conceptLearning.index = this.index;
                conceptLearning.Show();
                this.Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (reverse == false)
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = shapes[index].shape_text;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1, shapes[index].shape_text);


            }
            else
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu şekil " + shapes[index].shape_text + "değildir";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1, "Bu şekil " + shapes[index].shape_text + " değildir");

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (reverse == false)
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu şekil " + shapes[index].shape_text + "değildir";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, "Bu şekil" + shapes[index].shape_text + "değildir");

            }
            else
            {

                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = shapes[index].shape_text;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, shapes[index].shape_text);

                iteration++;

            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Shapes shapes = new Shapes();
            shapes.Show();
            this.Hide();
        }


    }
}
