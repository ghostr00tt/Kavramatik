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
    public partial class GameDraw : Form
    {
        LoginAlternative f1;
       
        bool painting = false;
        Graphics g;
        GameTrueFalse f4;

        public GameDraw()
        {
            InitializeComponent();
         
            g = panel1.CreateGraphics();
        }


        private void home_Click(object sender, EventArgs e)
        {
            Games games = new Games();
            games.label2.Text = this.label2.Text;
            games.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void reset_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);

        }
        int? prevx = null;
        int? prevy = null;
      

     
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            painting = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (painting)
            {
                Pen pen = new Pen(toolStrip1.ForeColor, float.Parse(this.pensize.Text));
                g.DrawLine(pen, new Point(prevx ?? e.X, prevy ?? e.Y), new Point(e.X, e.Y));
                prevx = e.X;
                prevy = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            painting = false;
            prevx = null;
            prevy = null;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                toolStrip1.ForeColor = cd.Color;
            }
        }

        private void draw_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = true;
        }

        private void Form3_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void quiz_Click(object sender, EventArgs e)
        {
            f4 = new GameTrueFalse();
            this.Hide();
            f4.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pensize_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
