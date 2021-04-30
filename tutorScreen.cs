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
using MySql.Data.MySqlClient;
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
            textBox1.Text = textBox1.Text + " " + "Merhaba";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Soru";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Soru";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Ne Zaman";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Merhaba";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Hello.wav");
            splayer.Play();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Hayvan";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Görüşürüz";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Ben";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Sen";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Duş";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Sevmek";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "GÖz";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "El";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Tuvalet";
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Yiyecek";
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Ev";
        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "şu anda harekete geçmek";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "İçmek";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Bacak";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Küçük";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Ağız";

        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Büyük";

        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Sinirli";

        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Üzgün";

        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "İstemek";

        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Mutlu";

        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Kadın";

        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Baba";

        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Adam";

        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Anne";

        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Kız Kardeş";

        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Evet";

        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Erkek Kardeş";

        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Hayır";

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
            textBox1.Text = textBox1.Text + " " + "Görüşürüz";
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Ben";
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Sen";
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Yıkamak";
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Sevmek";
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Göz";
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "El";
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " " + "Tuvalet";
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
            textBox1.Text = textBox1.Text + " " + "Hayvan";
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
            txtMessage.Text = txtMessage.Text + " " + "Merhaba";
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
            textBox1.Text = "Merhaba Ben Yemek İstemek";
            btnHello.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

        }

        private void btnGoodBye_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Görüşürüz";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Good bye.wav");
            splayer.Play();
        }

        private void btnMe_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Ben";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\i.wav");
            splayer.Play();
        }

        private void btnYou_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Sen";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\You.wav");
            splayer.Play();
        }

        private void btnWash_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Yıkamak";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Wash.wav");
            splayer.Play();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "İstemek";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Like.wav");
            splayer.Play();
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Göz";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Eye.wav");
            splayer.Play();
        }

        private void btnHand_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "El";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Hand.wav");
            splayer.Play();
        }

        private void btnToilet_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Tuvalet";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Toilet.wav");
            splayer.Play();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Yemek";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Food.wav");
            splayer.Play();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Hayır";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\No.wav");
            splayer.Play();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Evet";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Yes.wav");
            splayer.Play();
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Adam";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Man.wav");
            splayer.Play();
        }

        private void btnWoman_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Kadın";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Woman.wav");
            splayer.Play();
        }

        private void btnWant_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "İstemek";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Want.wav");
            splayer.Play();
        }

        private void btnSad_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Üzgün";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Sad.wav");
            splayer.Play();
        }

        private void btnMouth_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Ağız";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Mouth.wav");
            splayer.Play();
        }

        private void btnLeg_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Bacak";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Leg.wav");
            splayer.Play();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "İçmek";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Drink.wav");
            splayer.Play();
        }

        private void btnHouse_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Ev";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\House.wav");
            splayer.Play();
        }

        private void btnBrother_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Erkek Kardeş";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Brother.wav");
            splayer.Play();
        }

        private void btnSister_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Kız Kardeş";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Sister.wav");
            splayer.Play();
        }

        private void btnMother_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Anne";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Mother.wav");
            splayer.Play();
        }

        private void btnFather_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Babab";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Father .wav");
            splayer.Play();
        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Mutlu";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Happy.wav");
            splayer.Play();
        }

        private void btnAngry_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Kızgın";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Angry.wav");
            splayer.Play();
        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Büyük";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Big.wav");
            splayer.Play();
        }

        private void btnLittle_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Küçük";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Small.wav");
            splayer.Play();
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Hayvan";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Animal.wav");
            splayer.Play();
        }

        private void btnIndicator_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "İşaret";
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

        private void btnSend_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {

            GameAlphabet f2 = new GameAlphabet(this);
            f2.Show();
            this.Hide();
        }

  


        private void button6_Click(object sender, EventArgs e)
        {
            DatabaseCheck d5 = new DatabaseCheck();
            d5.Show();
          
        }

    }
    }





