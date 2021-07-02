using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace bliz
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1" + " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "9";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Hello";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Question";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Question";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "When";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Hello";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Vihz\Desktop\Bliz\ab.mp3");
            splayer.Play();

        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Animal";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Good Bye";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "I";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "You";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Bathe";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Like";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Eye";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Hand";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Toilet";
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Food";
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "House";
        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "make action in the present";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Drink";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Leg";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Little";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Mouth";

        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Big";

        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Angry";

        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Sad";

        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Want";

        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Happy";

        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Woman";

        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Father";

        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Man";

        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Mather";

        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Sister";

        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Yes";

        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Brother";

        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "No";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\hp\Downloads\abcs.wav");
            splayer.Play();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button17_Click_1(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {

        }

        private void button29_Click_1(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
