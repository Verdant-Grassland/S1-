using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _4月11日下午作业
{
    internal class DBHelper
    {
        static string conStr = "Data Source=DESKTOP-MJ25BUS;Initial Catalog=BookStudioRecordingRoom;User ID=sa;Password=123456";
        static SqlConnection con = new SqlConnection(conStr);
        #region 添加功能
        public static int DoNonQuery(string sql)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(sql, con);
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }
}
