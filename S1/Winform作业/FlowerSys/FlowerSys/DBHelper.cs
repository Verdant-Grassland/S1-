using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FlowerSys
{
    internal class DBHelper
    {
        static string conStr = "Data Source=DESKTOP-M3HNRPJ;Initial Catalog=FlowerSys;User ID=sa;Password = 123456";
        static SqlConnection con = new SqlConnection(conStr);

        #region 单一值的方法
        public static Object DoScalar(string sql)
        {
            try
            {
                con.Open();
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
                SqlCommand command = new SqlCommand(sql,con);
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

        #region 查询方法DateSet
        public static DataTable DoQuery(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
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
