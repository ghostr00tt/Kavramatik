using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing;
namespace Kavramatik.cs
{
    public partial class GameAlphabet : Form
    {
        public string userMail;
      
        Education f5;
        GameDraw f3;
        LoginAlternative f2;
        public GameAlphabet()
        {
            InitializeComponent();
          
        }

       
        AllChars chars = new AllChars();
        private int i = 0;
        string[] nums = { "0 elma", "1 elma", "2 elma", "3 elma", "4 elma", "5 elma", "6 elma", "7 elma", "8 elma", "9 elma" };
      
        /*  string[] chars = { "A", "B", "C", "D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T",
              "U","V","W","X","Y","Z"};*/
        Boolean workingChar = false, workingNums = false, workingBang = false, workingShon = false;

   

        private void Prev_Click(object sender, EventArgs e)
        {
            if (workingChar && i > 0)
            {
                i--;
                this.TextChar.Text = chars.CharList[i].Character;
                this.pictureBox1.Image = chars.CharList[i].image;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Aciklama.SetToolTip(pictureBox1, chars.CharList[i].Character);
                if (audio.Checked == true)

                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = chars.CharList[i].Character;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
                
            }
            else if (workingNums && i > 0)
            {
                i--;
                this.TextChar.Text = chars.NumList[i].Character;
                this.pictureBox1.Image = chars.NumList[i].image;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Aciklama.SetToolTip(pictureBox1, chars.NumList[i].Character);
                if (audio.Checked == true)

                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = chars.NumList[i].Character;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
               
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (workingChar && i < 25)
            {
                i++;
                this.TextChar.Text = chars.CharList[i].Character;
                this.pictureBox1.Image = chars.CharList[i].image;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Aciklama.SetToolTip(pictureBox1, chars.CharList[i].Character);

                if (audio.Checked == true)

                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = chars.CharList[i].Character;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
               
            }
            else if (workingNums && i < 9)
            {
                i++;
                this.TextChar.Text = chars.NumList[i].Character;
                this.pictureBox1.Image = chars.NumList[i].image;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
               
                if (audio.Checked == true)

                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = chars.NumList[i].Character;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (workingChar && i < 25)
            {
        
                if (audio.Checked == true)

                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = chars.CharList[i].Character;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");

            }
            else if (workingNums && i < 9)
            {       

                if (audio.Checked == true)

                    webBrowser1.Document.GetElementById("tta_input_ta").InnerText = chars.NumList[i].Character;
                webBrowser1.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
            }
        }

        private void TextChar_Click(object sender, EventArgs e)
        {

        }

        private void audio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Digit_Click(object sender, EventArgs e)
        {
            i = 0;
            this.TextChar.Text = chars.NumList[i].Character;
            this.pictureBox1.Image = chars.NumList[i].image;
            SoundPlayer s = chars.NumList[i].sound;
            if (audio.Checked == true)

               
            this.panel1.Visible = true;
            workingChar = false;
         
            workingNums = true;
        }
        WebBrowser webBrowser1 = new WebBrowser();
        ToolTip Aciklama = new ToolTip();
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Navigate("https://www.bing.com/translator/?from=tr&to=en");
                webBrowser1.ScriptErrorsSuppressed = true;
                //Google Translate yi WebBrowser ile Aç
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Alphabet_Click(object sender, EventArgs e)
        {
       
            i = 0;
            this.TextChar.Text = chars.CharList[i].Character;
            this.pictureBox1.Image = chars.CharList[i].image;
            SoundPlayer s = chars.CharList[i].sound;
            if (audio.Checked == true)

               
            this.panel1.Visible = true;
            workingChar = true;
      
            workingNums = false;
        }

        private void blackboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3 = new GameDraw();
            f3.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Games games = new Games();
            games.label2.Text = label1.Text;
            games.Show();
            this.Hide();
        }

    }
}
