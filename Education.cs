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

using MySql.Data.MySqlClient;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Kavramatik.cs
{
    public partial class Education : Form
    {
        public string Mail = Properties.Settings.Default.userMail;
        public string password ;
        ToolTip Aciklama = new ToolTip();
        public string display = "multiple";
        private List<Opposities> categories;
        private int nextOne = 0;
        public string anonym = "false";

        public Education()
        {
            InitializeComponent();
            if (anonym == "false")
            {
                getProfileDetails();
            }
           
            lblUsername.Visible = false;
            richTextBox1.Visible = false;
        }

        public string Parse(string veri)
        {
            string cikti = "";

            JObject json = JObject.Parse(veri);
            cikti = json["user_name"].ToString();

            return cikti;
        }
        async private void getProfileDetails()
        {

            if (anonym == "false")
            {
                String mail = Properties.Settings.Default.userMail;

                String showProfile = String.Format("http://kavramatik.com/api/showProfile?user_email=" + mail);
                var request = WebRequest.Create(showProfile);
                request.Method = "GET";

                var webResponse = request.GetResponse();
                var webStream = webResponse.GetResponseStream();

                var reader = new StreamReader(webStream);
                var data = reader.ReadToEnd();

                richTextBox1.Text = data.ToString();
            }

            else
            {
                labeluserName.Text = "Hoşgeldin Anonim";
            }

         
        }
      
        
       
        private async void Form1_Load(object sender, EventArgs e)
        {
           
            var client = new HttpClient();
            client.BaseAddress = new Uri(Utils.BASE_URL);
            HttpResponseMessage responseMessage = await client.GetAsync("categories?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            categories = JsonConvert.DeserializeObject<List<Opposities>>(result);
            FillBoxes();
            if (anonym == "false")
            {
                getProfileDetails();
                labeluserName.Text = "Hoşgeldin " + Parse(richTextBox1.Text.ToString());
            }


        }


        public void FillBoxes()
        {
            pictureBox1.Image = Utils.byteToImg(categories[0].category_image);
            label1.Text = categories[0].category_name;

            pictureBox2.Image = Utils.byteToImg(categories[1].category_image);
            label2.Text = categories[1].category_name;

            pictureBox3.Image = Utils.byteToImg(categories[2].category_image);
            label3.Text = categories[2].category_name;

            pictureBox4.Image = Utils.byteToImg(categories[3].category_image);
            label4.Text = categories[3].category_name;

            pictureBox5.Image = Utils.byteToImg(categories[4].category_image);
            label5.Text = categories[4].category_name;

            pictureBox6.Image = Utils.byteToImg(categories[5].category_image);
            label6.Text = categories[5].category_name;

            pictureBox7.Image = Utils.byteToImg(categories[6].category_image);
            label7.Text = categories[6].category_name;

            pictureBox8.Image = Utils.byteToImg(categories[7].category_image);
            label8.Text = categories[7].category_name;

            pictureBox9.Image = Utils.byteToImg(categories[8].category_image);
            label9.Text = categories[8].category_name;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void FillPictureBoxes()
        {

            int pointX = 10;
            int pointY = 180;
            for (int i = 0; i < categories.Count; i++)
            {
                if (i == 5)
                {
                    pointY = 360;
                    pointX = 10;
                }

                var picture = new PictureBox
                {
                    Name = "pictureBox" + i,
                    Size = new Size(70, 70),
                    Location = new Point(pointX, pointY),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                    Image = Utils.byteToImg(categories[nextOne].category_image),



                };
                Controls.Add(picture);

                nextOne++;

                pointX += 75;




            }
            nextOne = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

                Games f2 = new Games();
                f2.userMail = lblUsername.Text.ToString();
            f2.label2.Text = lblUsername.Text;
                f2.Show();
                this.Hide();
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Renkler")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                if (display == "multiple")
                {
                    ColorsMulti colors2 = new ColorsMulti();
                       colors2.Show();
                }
                else if (display == "single")
                {
                    Colors colors = new Colors();
                     colors.Show();
                }

            }

            //if (display == "multiple")
            //{
            //    ColorsMulti colors2 = new ColorsMulti();
            //    colors2.Show();
            //}
            //else if (display == "single")
            //{
            //    Colors colors = new Colors();
            //    colors.Show();

            //}



        }
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Boyutlar")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                if (display == "multiple")
                {
                    DimensionsMulti dimensionsMulti = new DimensionsMulti();
                       dimensionsMulti.Show();
                }
                else if (display == "single")
                {
                    Dimensions dimensions = new Dimensions();
                        dimensions.Show();
                }

            }
            // if(display == "multiple")
            // {
            //     DimensionsMulti dimensionsMulti = new DimensionsMulti();
            //     dimensionsMulti.Show();
            // }
            //else if (display == "single")
            // {
            //     Dimensions dimensions = new Dimensions();
            //     dimensions.Show();
            // }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Şekiller")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                if (display == "multiple")
                {
                    Shapes shapes = new Shapes();
                    shapes.Show();
                }
                else if (display == "single")
                {
                    ShapesSingle shapesSingle = new ShapesSingle();
                    shapesSingle.Show();
                }

            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Quantities quantities = new Quantities();
            quantities.Show();
          
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
            Aciklama.SetToolTip(pictureBox1, "Renkler");

        }


        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = SystemColors.Control;
          
        }

     

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.Red;
            Aciklama.SetToolTip(pictureBox2, "Boyutlar");

        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.Red;
            Aciklama.SetToolTip(pictureBox3, "Şekiller");
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = SystemColors.Control;
        }




        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = Color.Red;
            Aciklama.SetToolTip(pictureBox4, "Miktarlar");
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = SystemColors.Control;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.BackColor = Color.Red;
            Aciklama.SetToolTip(pictureBox5, "Yönler");
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = SystemColors.Control;
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.BackColor = Color.Red;
            Aciklama.SetToolTip(pictureBox6, "Sayılar");
        }
        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = SystemColors.Control;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.BackColor = Color.Red;
            Aciklama.SetToolTip(pictureBox7, "Duyular");
        }
        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = SystemColors.Control;
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox8.BackColor = Color.Red;
            Aciklama.SetToolTip(pictureBox8, "Duygular");
        }
        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackColor = SystemColors.Control;
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox9.BackColor = Color.Red;
            Aciklama.SetToolTip(pictureBox9, "Kavramlar");
        }
        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.BackColor = SystemColors.Control;
        }

       

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Yönler")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                if (display == "multiple")
                {
                    Directions directions = new Directions();
                    directions.Show();
                }
                else if (display == "single")
                {
                    DirectionsSingle directionsSingle = new DirectionsSingle();
                    directionsSingle.Show();
                }

            }
            //if (display == "multiple")
            //{
            //    Directions directions = new Directions();
            //    directions.Show();
            //}
            //else if (display == "single")
            //{
            //    DirectionsSingle directionsSingle = new DirectionsSingle();
            //    directionsSingle.Show();
            //}

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
            

            
                if (display == "multiple")
                {
                    Numbers numbers = new Numbers();
                    numbers.Show();
                }
                else if (display == "single")
                {
                    NumbersSingle numbersSingle = new NumbersSingle();
                    numbersSingle.Show();
                }
            
        }

        private void labeluserName_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.userMail= lblUsername.Text.ToString();
            settings.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Duyular")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                if (display == "multiple")
                {
                    Senses senses = new Senses();
                    senses.Show();
                }
                else if (display == "single")
                {
                    Senses senses = new Senses();
                    senses.Show();
                }

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            

           
                if (display == "multiple")
                {
                    Emotions emotions = new Emotions();
                    emotions.Show();
                }
                else if (display == "single")
                {
                    Emotions emotions = new Emotions();
                    emotions.Show();
                }

            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Opposite opposite = new Opposite();
            opposite.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.userData = lblUsername.Text.ToString();
            profile.Show();
        }
    }
}
