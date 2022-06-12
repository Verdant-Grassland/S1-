using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QQManage
{
    class DB
    {
        // static string connStr = "Data Source=.;Initial Catalog=QQDB;Integrated Security=True";
        static string connStr = "server=.;database=qqdb;uid=sa;pwd=admin";
        //数据库连接对象
        SqlConnection conn = new SqlConnection(connStr);

        #region 登录
        public bool Login(string loginId, string loginPwd)
        {
            try
            {
                //打开数据库
                conn.Open();
                string sql = "select COUNT(*) from admin where LoginId='" + loginId + "' and LoginPwd='" + loginPwd + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                int result = Convert.ToInt32(command.ExecuteScalar());
                //用户存在,登录成功
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;   //登录失败
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 显示所有数据
        public SqlDataReader GetAllUser()
        {
            try
            {
                conn.Open();
                string sql = "select * from UserInfo";
                SqlCommand command = new SqlCommand(sql, conn);
                //CommandBehavior.CloseConnection表示关闭SqlDataReader对象时同时关闭数据库
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
        #endregion

        #region 通过编号更新在线天数(增，删，改方法返回结果都做int类型)
        /// <summary>
        /// 通过编号更新在线天数
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <param name="onlineDay">在线天数</param>
        /// <returns>影响行数</returns>
        public int UpdateDayById(int userId, double onlineDay)
        {
            try
            {
                conn.Open();
                //string sql = "update UserInfo set OnLineDay="+onlineDay+"  where UserId="+userId;
                string sql = string.Format("update UserInfo set OnLineDay={0}  where UserId={1}", onlineDay, userId);
                SqlCommand command = new SqlCommand(sql, conn);
                //ExecuteNonQuery方法的作用是执行增，删，改的SQL语句
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

        #region 增加信息
        public int AddUser(string name, string pwd, string email)
        {
            try
            {
                conn.Open();
                //string sql = "insert into UserInfo(UserName,UserPwd,LevelId,Email,OnLineDay) values('"+name+"','"+pwd+"',1,'"+email+"',0)";
                string sql = string.Format("insert into UserInfo(UserName,UserPwd,LevelId,Email,OnLineDay) values('{0}','{1}',1,'{2}',0)", name, pwd, email);
                SqlCommand command = new SqlCommand(sql, conn);
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

        #region 删除
        public int DeleteUser(int id)
        {
            try
            {
                conn.Open();
                string sql = "delete from UserInfo where UserId=" + id;
                SqlCommand command = new SqlCommand(sql, conn);
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

        #region 检索用户的编号和在线天数
        public SqlDataReader SelectUser()
        {
            try
            {
                conn.Open();
                string sql = "select UserId,OnLineDay from UserInfo";
                SqlCommand command = new SqlCommand(sql, conn);
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
        #endregion

        #region 根据用户编号更新等级
        public int UpdateLevel(int userId, int level)
        {
            try
            {
                conn.Open();
                string sql = "update UserInfo set LevelId=" + level + "   where UserId=" + userId;
                SqlCommand command = new SqlCommand(sql, conn);
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                //Console.WriteLine(ex.Message);
                return -1;
            }
        }
        #endregion



    }
}
