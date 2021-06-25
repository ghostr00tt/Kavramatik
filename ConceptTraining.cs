using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kavramatik.cs
{
    public partial class ConceptTraining : Form
    {

        bool reverse;
        public List<colors> colors;
        public int index ;
        int randomizedIndex;
        Random rnd = new Random();
        int iteration = 1;
        public ConceptTraining()
        {
            InitializeComponent();
        }

        WebBrowser webBrowser1 = new WebBrowser();
        ToolTip Aciklama = new ToolTip();
        private void ConceptTraining_Load(object sender, EventArgs e)
        {
            label1.Text = colors[index].color_name + " rengi tanımaya ne dersin ? ";
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
            string colname2 = colors[index].color_name;

            //do
            //{
            //    int index = rastgele.Next(0, 30);

            //    temp = col[index].color;
            //    colname = col[index].color_name;
            //} while (colname == colname2);
            reverse = false;
            do
            {
                randomizedIndex = rnd.Next(0, 30);
                colname1 = colors[randomizedIndex].color_name;
                if (colname1 == colname2)
                {
                    randomizedIndex = rnd.Next(0, 30);
                    colname1 = colors[randomizedIndex].color_name;

                }

            } while (randomizedIndex == index && colname1 == colname2);
            pictureBox1.Image = Utils.byteToImg(colors[index].color_one);
            pictureBox2.Image = Utils.byteToImg(colors[randomizedIndex].color_one);

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = colors[index].color_name.ToString();
            label3.Text = "Bu renk " + colors[index].color_name.ToString() + " değildir ";
            index = index + 1;
        }

        public void Training2()
        {
            string colname2 = colors[index].color_name;
            reverse = true;
            do
            {
                randomizedIndex = rnd.Next(0, 30);
                colname1 = colors[randomizedIndex].color_name;
                if (colname1 == colname2)
                {
                    randomizedIndex = rnd.Next(0, 30);
                    colname1 = colors[randomizedIndex].color_name;

                }

            } while (randomizedIndex == index && colname1 == colname2);
            pictureBox2.Image = Utils.byteToImg(colors[index].color_one);
            pictureBox1.Image = Utils.byteToImg(colors[randomizedIndex].color_one);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = colors[index].color_name.ToString();
            label2.Text = "Bu renk " + colors[index].color_name.ToString() + " değildir ";
            index = index + 1;
        }

        public void Training3()
        {
            string colname2 = colors[index].color_name;
            reverse = false;
            do
            {
                randomizedIndex = rnd.Next(0, 30);
                colname1 = colors[randomizedIndex].color_name;
                if (colname1 == colname2)
                {
                    randomizedIndex = rnd.Next(0, 30);
                    colname1 = colors[randomizedIndex].color_name;

                }

            } while (randomizedIndex == index && colname1 == colname2);
            pictureBox1.Image = Utils.byteToImg(colors[index].color_one);
            pictureBox2.Image = Utils.byteToImg(colors[randomizedIndex].color_one);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = colors[index].color_name.ToString();
            label3.Text = "Bu renk " + colors[index].color_name.ToString() + " değildir ";
            index = index + 1;
        }

        public void Training4()
        {
            string colname2 = colors[index].color_name;
            reverse = true;
            do
            {
                randomizedIndex = rnd.Next(0, 30);
                colname1 = colors[randomizedIndex].color_name;
                if (colname1 == colname2)
                {
                    randomizedIndex = rnd.Next(0, 30);
                    colname1 = colors[randomizedIndex].color_name;

                }

            } while (randomizedIndex == index && colname1 == colname2);
            pictureBox2.Image = Utils.byteToImg(colors[index].color_one);
            pictureBox1.Image = Utils.byteToImg(colors[randomizedIndex].color_one);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = colors[index].color_name.ToString();
            label2.Text = "Bu renk " + colors[index].color_name.ToString() + " değildir ";
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
            if (iteration == 5 || iteration>4)
            {
                
                ConceptLearning conceptLearning = new ConceptLearning();
                conceptLearning.colors = this.colors;
                conceptLearning.index = this.index;
                conceptLearning.Show();
                this.Hide();
              
            }
     

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (reverse == false)
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = colors[index].color_name ;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1, colors[index].color_name);
               
             
            }
            else
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu renk " + colors[index].color_name + " değildir";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox1,"Bu renk " + colors[index].color_name+" değildir");

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (reverse == false)
            {
                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = "Bu renk " + colors[index].color_name + " değildir";
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2,"Bu renk "+  colors[index].color_name+ " değildir");

            }
            else
            {

                webBrowser1.Document.GetElementById("tta_input_ta").InnerText = colors[index].color_name;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                Aciklama.SetToolTip(pictureBox2, colors[index].color_name);
               
                iteration++;
              
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            ColorsMulti colors = new ColorsMulti();
            colors.Show();
            this.Hide();
        }
    }
}
