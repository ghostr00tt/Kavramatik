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

namespace sampleframe.cs
{
    public partial class stUI : Form
    {
        public stUI()
        {
            InitializeComponent();
        }

        

        private void button2_Click_3(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " " + "Merhaba";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\asus k555l\source\repos\OzelOgrenci\wave\Hello.wav");
            splayer.Play();
        }

        private void stUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMessage.Text =  " ";
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
            txtMessage.Text = txtMessage.Text + " " + "Beğenmek";
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
            txtMessage.Text = txtMessage.Text + " " + "Baba";
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
            txtMessage.Text = txtMessage.Text + " " + "Sinirli";
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            txtMessage.Text = " ";
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

        private void btnSend_Click(object sender, EventArgs e)
        {

        }
    }
}
