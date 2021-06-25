using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kavramatik.cs
{
    public partial class ApiTest : Form
    {

        private List<Opposities> categories;
        private int nextOne = 0;
    

        public ApiTest()
        {
            InitializeComponent();
        }

        public void FillPictureBoxes()
        {
            int pointX = 10;
            int pointY = 10;
            int count = 1;
            int number = 0;
            for (int i = 0; i < 30 ; i++)
            {
               

                var picture = new PictureBox
                {
                    Name = "pictureBox" + i,
                    Size = new Size(130, 130),
                    Location = new Point(pointX, pointY),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                    Image = Utils.byteToImg(categories[nextOne].category_image),



                };
                Controls.Add(picture);

               
                
               

                if (nextOne < 8)
                {
                    nextOne++;
                }
                else
                {
                    nextOne = 0;
                }

                if (i == 9 | i == 19 | i == 29)
                {
                    pointY += 135;
                    pointX = 10;
                }
                else
                {
                    pointX += 135;
                }


            }
            
        }






        private void button1_Click(object sender, EventArgs e)
        {




            //if (nextOne < categories.Count)
            //{
            //    label1.Text = nextOne.ToString();
            //    pictureBox1.Image = Utils.byteToImg(categories[nextOne].category_image);
            //    pictureBox2.Image = Utils.byteToImg(categories[nextOne].category_image);
            //    nextOne++;
            //}
            //else
            //{
            //    nextOne = 0;

            //}
            FillPictureBoxes();



        }


        private async void ApiTest_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Utils.BASE_URL);
            HttpResponseMessage responseMessage = await client.GetAsync("categories?token_id=464685648465A468464qw8A544688648W6REEWT6V");

            string result = await responseMessage.Content.ReadAsStringAsync();
            categories = JsonConvert.DeserializeObject<List<Opposities>>(result);
           




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
