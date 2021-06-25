using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SpeechLib;
namespace Kavramatik.cs
{
    public partial class DatabaseCheck : Form
    {
        public DatabaseCheck()
        {
            InitializeComponent();
            build.Server = "localhost";
            build.Database = "test_database";
            build.UserID = "root";
            build.Password = "admin";
            connection = new MySqlConnection(build.ToString());
            Listele_Ara("Select *from admin");
            SpVoice voice = new SpVoice();
            voice.Speak("Mysql veritabanı deneme ekranına hoşgeldiniz. Kullanıcı adı");
            voice.Speak(build.UserID);
            voice.Speak("ve Şifre ");
            voice.Speak(build.Password);

        }
     

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection connection;


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }


        public DataTable Listele_Ara(string query)
        {
            DataTable tbl = new DataTable();
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(tbl);
            dataGridView1.DataSource = tbl;
            connection.Close();

            return tbl;
        }
    }
}
