using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Center_Learning
{
    class database
    {


        SqlConnection conn = new SqlConnection(@"Data Source="+Properties.Settings.Default.servername+";Initial Catalog="+Properties.Settings.Default.databasename+";Integrated Security=True");
        SqlCommand cmd = new SqlCommand();






        //select , search
        public DataTable readdata(string stmt, string Message)


        {
            DataTable tbl = new DataTable();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                tbl.Load(cmd.ExecuteReader());
                conn.Close();

                if (Message != "")
                {
                    MessageBox.Show(Message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            return tbl;

        }

        //excute
        public bool excutedata(string stmt, string message)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                if (message != "")
                {
                    MessageBox.Show(message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }


        }

    }
}
