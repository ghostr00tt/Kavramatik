using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kavramatik.cs
{
    public partial class Profile : Form
    {
        public string userData;
        public Profile()
        {
            InitializeComponent();
        }
        public string Parse(string veri,string parameter)
        {
            string cikti = "";

            JObject json = JObject.Parse(veri);
            cikti = json[parameter].ToString();

            return cikti;
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            String mail = userData;

            String showProfile = String.Format("http://kavramatik.com/api/showProfile?user_email=" + mail);
            var request = WebRequest.Create(showProfile);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
            label4.Text = Parse(data,"user_name");
            label5.Text = Parse(data,"user_email");
            label6.Text = Parse(data,"score");



        }
    }
}
