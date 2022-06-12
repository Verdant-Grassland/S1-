using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Organization
{
    class DB
    {
        //数据库连接字符串
        static string connStr = "Data Source=.;Initial Catalog=OrganizationDB;Integrated Security=True";

        //建立数据库连接对象
        SqlConnection conn = new SqlConnection(connStr);

        #region 查询所有
        public SqlDataReader GetAll()
        {
            try
            {
                //打开数据库
                conn.Open();
                string sql = "select * from Organizations";
                //建立SqlCommand对象
                SqlCommand command = new SqlCommand(sql, conn);
                //执行SQL语句
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
        #endregion

        #region 添加
        public int Add(string name, string desc, string principal,string phone,string date)
        {
            try
            {
                conn.Open();
                /*string sql = @"insert into Organizations(name,description,principal,telephone,RegistrationDate) 
                             values('" + name + "','" + desc + "','" + principal + "','"+phone+"','"+date+"')";*/
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("insert into Organizations(name,description,principal,telephone,RegistrationDate)");
                sb.AppendFormat("    values('{0}','{1}','{2}','{3}','{4}')", name, desc, principal, phone, date);
                //SqlCommand对象建立，作用是用于执行SQL语句
                SqlCommand command = new SqlCommand(sb.ToString(), conn);
                //执行SQL语句
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
