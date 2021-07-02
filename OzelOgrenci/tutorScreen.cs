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
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using sampleframe.cs.BLL;
namespace sampleframe.cs
{
    public partial class tutorScreen : Form
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        List<userBLL> categori = new List<userBLL>();
        public tutorScreen()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            lblStudent.Text = "";
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Yellow, 0, 0, 100, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
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
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Hello.wav");
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

        private void button31_Click_1(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Good bye";
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "I";
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "You";
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "wash";
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Like";
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Eye";
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Hand";
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Toilet";
        }

        private void button28_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = " ";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Animal";
        }

        private void StuSymbols_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            SqlConnection conn = new SqlConnection(myconnstring);
            conn.Open();
            SqlCommand cmdCate = new SqlCommand("SELECT * FROM tbl_stusers", conn);

            SqlDataReader dr = cmdCate.ExecuteReader();
            while (dr.Read())
            {
                listStudent.Items.Add(dr["fullname"]);
                categori.Add(new userBLL()
                {
                    Id = ((int)dr["Id"]),
                    fullname = dr["fullname"] as string
                });
            }
            conn.Close();
        }

        private void button30_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Text = " ";
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Hello";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Hello.wav");
            splayer.Play();
        }

        private void lisiStudent_onItemSelected(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStudent.Text = listStudent.Text;
            textBox1.Text = "Hello I want food";
            btnHello.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

        }

        private void btnGoodBye_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Good Bye";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Good bye.wav");
            splayer.Play();
        }

        private void btnMe_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "I";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\i.wav");
            splayer.Play();
        }

        private void btnYou_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "you";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\You.wav");
            splayer.Play();
        }

        private void btnWash_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "wash";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Wash.wav");
            splayer.Play();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "like";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Like.wav");
            splayer.Play();
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "eye";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Eye.wav");
            splayer.Play();
        }

        private void btnHand_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "hand";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Hand.wav");
            splayer.Play();
        }

        private void btnToilet_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "toilet";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Toilet.wav");
            splayer.Play();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "food";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Food.wav");
            splayer.Play();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "no";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\No.wav");
            splayer.Play();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "yes";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Yes.wav");
            splayer.Play();
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "man";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Man.wav");
            splayer.Play();
        }

        private void btnWoman_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "woman";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Woman.wav");
            splayer.Play();
        }

        private void btnWant_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "want";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Want.wav");
            splayer.Play();
        }

        private void btnSad_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "sad";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Sad.wav");
            splayer.Play();
        }

        private void btnMouth_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "mouth";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Mouth.wav");
            splayer.Play();
        }

        private void btnLeg_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "leg";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Leg.wav");
            splayer.Play();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "drink";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Drink.wav");
            splayer.Play();
        }

        private void btnHouse_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "house";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\House.wav");
            splayer.Play();
        }

        private void btnBrother_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "brother";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Brother.wav");
            splayer.Play();
        }

        private void btnSister_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "sister";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Sister.wav");
            splayer.Play();
        }

        private void btnMother_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "mother";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Mother.wav");
            splayer.Play();
        }

        private void btnFather_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "father";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Father .wav");
            splayer.Play();
        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "happy";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Happy.wav");
            splayer.Play();
        }

        private void btnAngry_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "angry";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Angry.wav");
            splayer.Play();
        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "big";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Big.wav");
            splayer.Play();
        }

        private void btnLittle_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "small";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Small.wav");
            splayer.Play();
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "animal";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Animal.wav");
            splayer.Play();
        }

        private void btnIndicator_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "indicator";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Indicator.wav");
            splayer.Play();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMessage.Text != string.Empty)
                {
                    int txtlength = txtMessage.Text.Length;
                    if (txtlength != 1)
                    {

                        txtMessage.Text = txtMessage.Text.Substring(0, txtMessage.Text.LastIndexOf(" ")).Trim();

                    }
                    else
                    {
                        txtMessage.Text = 0.ToString();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {

        }
    }

}
