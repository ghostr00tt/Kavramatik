using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using sampleframe.cs.BLL;

namespace sampleframe.cs.DLL
{
    class userDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        #region Select Data from Database
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbl_stusers ";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox mb = new MessageBox(ex.Message, sampleframe.cs.MessageBox.MsgType.success);
               
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        #endregion
        #region Insert Data in Database
        public bool Insert(userBLL c)
        {
            bool isSuccess = false;
            SqlConnection Conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbl_stusers (fullname,address,dob,parentName,tellnumber,username,password,userType) VALUES (@fullname,@address,@dob,@parentName,@tellnumber,@username,@password,@userType)";

                SqlCommand cmd = new SqlCommand(sql, Conn);
                cmd.Parameters.AddWithValue("@fullname", c.fullname);
                cmd.Parameters.AddWithValue("@address", c.address);
                cmd.Parameters.AddWithValue("@dob", c.dob);
                cmd.Parameters.AddWithValue("@parentName", c.parentName);
                cmd.Parameters.AddWithValue("@tellnumber", c.tell);
                cmd.Parameters.AddWithValue("@username", c.username);
                cmd.Parameters.AddWithValue("@password", c.password);
                cmd.Parameters.AddWithValue("@userType",c.userType);
                Conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox mb = new MessageBox(ex.Message, sampleframe.cs.MessageBox.MsgType.success);
            }
            finally
            {
                Conn.Close();
            }
            return isSuccess;
        }
        #endregion
    }
}

 