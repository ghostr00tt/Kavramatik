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


namespace Kavramatik.cs
{

    public partial class tutorScreen : Form
    {
       public String userMail;
        public String password;

        private List<Opposities> categories;
        private int nextOne = 0;
        public tutorScreen()
        {
            InitializeComponent();
            this.BackColor = Color.White;

       

        }

        


        private async void tutorScreen_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Utils.BASE_URL);
            HttpResponseMessage responseMessage = await client.GetAsync("categories?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            categories = JsonConvert.DeserializeObject<List<Opposities>>(result);

            FillPictureBoxes();

        }

      
        public void FillPictureBoxes()
        {
           
        int pointX = 10;
            int pointY = 180;
            for (int i = 0; i < categories.Count; i++)
            {
                if (nextOne == 5)
                {
                    pointX = 190;
                }

                var picture = new PictureBox
                {
                    Name = "pictureBox" + i,
                    Size = new Size(130, 130),
                    Location = new Point(pointX, pointY),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                    Image = Utils.byteToImg(categories[nextOne].category_image),



                };
                Controls.Add(picture);

                nextOne++;

                pointX += 135;




            }
            nextOne = 0;

        }



        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Yellow, 0, 0, 100, 100);
        }

      

      
   


      


        private void button5_Click(object sender, EventArgs e)
        {

            //GameAlphabet f2 = new GameAlphabet(this);
            //f2.Show();
            //this.Hide();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }
    
        private void button1_Click_3(object sender, EventArgs e)    
        {
           
            //build.Server = "localhost";
            //build.Database = "test_database";
            //build.UserID = "root";
            //build.Password = "admin";
            //String sql = "insert into resources values(@ID,@text,@image)";
            //con = new MySqlConnection(build.ToString());
            
            //cmd = new MySqlCommand(sql, con);
            //con.Open();
            //for (int i = 0; i < 29; i++)
            //{

                
            //    string temp = "C:\\Users\\asus k555l\\source\\repos\\OzelOgrenciDemo\\res\\A"+ (i+1)+".jpg";
            //    cmd.Parameters.AddWithValue("@ID", i);
            //    cmd.Parameters.AddWithValue("@text", texts[i]);
            //    cmd.Parameters.AddWithValue("@image",temp);
            //    cmd.ExecuteNonQuery();
            //    cmd.Parameters.Clear();
                
            //}
            //con.Close();




            //string customPath = "C:\\Users\\asus k555l\\source\\repos\\OzelOgrenciDemo\\res";

            //string filename = "angry.jpg";
            //btn1.BackgroundImage = Image.FromFile(Path.Combine(customPath, filename));

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillPictureBoxes();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }





