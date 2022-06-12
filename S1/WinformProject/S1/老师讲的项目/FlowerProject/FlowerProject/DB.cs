using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FlowerProject
{
    class DB
    {
        //建立数据库连接的字符串
        static string connStr = "Data Source=.;Initial Catalog=flowerDB;Integrated Security=True";
        //建立数据库的连接对象
        SqlConnection conn = new SqlConnection(connStr);

        #region 查询所有花
        public SqlDataReader GetAll()
        {
            try
            {
                //打开数据库
                conn.Open();
                //建立SQL语句
                string sql = "select * from flower";
                //建立SqlCommand对象
                SqlCommand command = new SqlCommand(sql, conn);
                //执行SQL语句
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                //输出异常信息
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        #endregion

        #region 统计所有花的数量
        public int GetAllCount()
        {
            try
            {
                //打开数据库
                conn.Open();
                //建立SQL语句
                string sql = "select COUNT(*) from flower";
                //建立SqlCommand对象，用于执行SQL语句
                SqlCommand command = new SqlCommand(sql, conn);
                //执行SQL语句
                return Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                //关闭数据库
                conn.Close();
            }
        }
        #endregion

        #region 修改鲜花信息
        public int UpdateFlower(int id, string name, int price)
        {
            try
            {
                conn.Open();
                //string sql = "update flower set name='"+name+"',price="+price+"   where id="+id+"";
                string sql = string.Format("update flower set name='{0}',price={1}   where id={2}", name, price, id);
                SqlCommand command = new SqlCommand(sql, conn);
                //执行增，删，改的SQL语句应用方法
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 删除花的信息
        public int DeleteFlower(int id)
        {
            try
            {
                conn.Open();
                string sql = "delete from flower where id="+id;
                SqlCommand command = new SqlCommand(sql, conn);
                //执行增，删，改的SQL语句应用方法
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

    }
}
