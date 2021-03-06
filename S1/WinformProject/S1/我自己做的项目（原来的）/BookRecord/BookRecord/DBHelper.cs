using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BookRecord
{
    /// <summary>
    /// 数据库访问的类
    /// </summary>
    class DBHelper
    {
        static string conStr = "Data Source=DESKTOP-MJ25BUS;Initial Catalog=BookStudioRecordingRoom;User ID=sa;Password=123456";
        static SqlConnection con = new SqlConnection(conStr);
        
        #region 单一值的方法
        public static Object DoScalar(string sql)
        {
            try
            {
                //打开数据库
                con.Open();
                //建立SqlCommand对象，用于执行SQL语句
                SqlCommand command = new SqlCommand(sql, con);
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region 增删改方法
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

        #region 查询方法
        public static SqlDataReader DoReader(string sql)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(sql, con);
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
        #endregion
    }
}
