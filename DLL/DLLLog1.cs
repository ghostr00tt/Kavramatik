using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using sampleframe.cs.BLL;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

    class DLLLog1
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        public bool loginCheck(logBLL l)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "SELECT * FROM tbl_stusers WHERE username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }

