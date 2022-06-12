using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ticket
{
    /// <summary>
    /// 数据库访问的类
    /// </summary>
    class DBHelper
    {
        static string connStr = "Data Source=.;Initial Catalog=Ticket;Integrated Security=True";
        static SqlConnection conn = new SqlConnection(connStr);

        #region 单一值的方法
        public static Object DoScalar(string sql)
        {
            try
            {
                //打开数据库
                conn.Open();
                //建立SqlCommand对象，用于执行SQL语句
                SqlCommand command = new SqlCommand(sql, conn);
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 增删改方法
        public static int DoNonQuery(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 查询方法
        public static SqlDataReader DoReader(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            } 
        }
        #endregion

        #region 查询方法DataSet
        public static DataTable DoQuery(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds);
                return ds.Tables[0];
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
