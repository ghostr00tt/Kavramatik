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
namespace sampleframe.cs
{
    public partial class GameAlphabet : Form
    {
        tutorScreen f1;
        GameDraw f3;
        Login f2;
        public GameAlphabet(tutorScreen f1)
        {
            InitializeComponent();
            this.f1 = f1;
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
                SoundPlayer s = chars.CharList[i].sound;
                if (audio.Checked == true)

                    s.Play();
            }
            else if (workingNums && i > 0)
            {
                i--;
                this.TextChar.Text = chars.NumList[i].Character;
                this.pictureBox1.Image = chars.NumList[i].image;
                SoundPlayer s = chars.NumList[i].sound;
                if (audio.Checked == true)

                    s.Play();
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (workingChar && i < 25)
            {
                i++;
                this.TextChar.Text = chars.CharList[i].Character;
                this.pictureBox1.Image = chars.CharList[i].image;
                SoundPlayer s = chars.CharList[i].sound;
                if (audio.Checked == true)

                    s.Play();
            }
            else if (workingNums && i < 9)
            {
                i++;
                this.TextChar.Text = chars.NumList[i].Character;
                this.pictureBox1.Image = chars.NumList[i].image;
                SoundPlayer s = chars.NumList[i].sound;
                if (audio.Checked == true)

                    s.Play();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

                s.Play();
            this.panel1.Visible = true;
            workingChar = false;
            workingBang = false;
            workingShon = false;
            workingNums = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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

                s.Play();
            this.panel1.Visible = true;
            workingChar = true;
            workingBang = false;
            workingShon = false;
            workingNums = false;
        }

        private void blackboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3 = new GameDraw(f2,this);
            f3.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }

    }
}
