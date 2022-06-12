using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MySchool
{
    /// <summary>
    /// 数据库连接的类
    /// </summary>
    class DB
    {
        //数据库连接字符串
        static string connStr = "Data Source=.;Initial Catalog=MySchool;Integrated Security=True";
        //建立数据库的连接对象
        SqlConnection conn = new SqlConnection(connStr);

        #region 登录
        public bool Login(string userName, string pwd)
        {
            try
            {
                //打开数据库
                conn.Open();
                string sql = "select COUNT(*) from admin where loginId='" + userName + "' and loginPwd='" + pwd + "'";
                //建立SqlCommand对象，用于执行SQL语句
                SqlCommand command = new SqlCommand(sql, conn);
                //执行SQL语句
                int count = Convert.ToInt32(command.ExecuteScalar());
                //用户存在
                if (count > 0)
                {
                    return true;  //用户存在，登录成功
                }
                else
                {
                    return false; //用户不存在，或是用户名密码不正确
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

        #region 统计学生数据
        public int GetCount()
        {
            try
            {
                //打开数据库
                conn.Open();
                //string sql = "select count(*) from student";
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("select");
                sb.AppendLine("    count(*)");
                sb.AppendLine("from");
                sb.AppendLine("    student");
                //建立SqlCommand对象，用于执行SQL语句
                SqlCommand command = new SqlCommand(sb.ToString(), conn);
                //执行SQL语句
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return -1;  //出现异常，统计失败
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 计算所有同学的平均分
        public int GetAvg()
        {
            try
            {
                //打开数据库
                conn.Open();
                string sql = "select AVG(StudentResult) from result";
                //建立SqlCommand对象，用于执行SQL语句
                SqlCommand command = new SqlCommand(sql, conn);
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                //ex.Message打印系统异常信息
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 读取学生列表
        public SqlDataReader GetStudentList()
        {
            try
            {
                //打开数据库
                conn.Open();
                string sql = "select StudentNo,StudentName,Phone from student";
                SqlCommand command = new SqlCommand(sql,conn);
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
            
        }
        #endregion

        #region 学号查询学生名字
        public string GetNameByNo(string studentNo)
        {
            string name = "";
            try
            {
                conn.Open();
                string sql = "select studentname from student  where studentno='" + studentNo + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                //执行SQL语句
                SqlDataReader reader = command.ExecuteReader();
              
                if (reader.Read())
                {
                    name = reader["studentname"].ToString();
                }
                reader.Close();
                return name;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 根据名字查询信息
        public SqlDataReader SearchByName(string name)
        {
            try
            {
                //打开数据库
                conn.Open();
                string sql = "select * from Student where StudentName like '%"+name+"%'";
                SqlCommand command = new SqlCommand(sql, conn);
                //执行SQL语句
                return  command.ExecuteReader();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
        #endregion

        #region 根据电话查询
        public SqlDataReader GetStudentByPhone(string phone)
        {
            try
            {
                conn.Open();
                string sql = "select * from Student where Phone like '%"+phone+"%'";
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

        #region 增加年级
        public int AddGrade(string gradeName)
        {
            try
            {
                conn.Open();
                //string sql = string.Format("insert into Grade(GradeName) values('{0}')", gradeName);
                string sql = "insert into Grade(GradeName) values('" + gradeName + "')";
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

        #region 修改出生日期
        /// <summary>
        /// 修改出生日期
        /// </summary>
        /// <param name="stuNo">学号</param>
        /// <param name="date">出生日期</param>
        /// <returns></returns>
        public int UpdateDate(string stuNo, string date) 
        {
            try
            {
                conn.Open();
                //string sql = "update student set borndate='"+date+"' where studento='"+stuNo+"'";
                string sql = string.Format("update student set borndate='{0}' where studentno='{1}'", date, stuNo);
                SqlCommand command = new SqlCommand(sql, conn);
                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //抛出异常
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 删除学生，按照学号删除
        public int DeleteStudent(string stuNo)
        {
            try
            {
                conn.Open();
                string sql = "delete from Result where studentNo='" + stuNo + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                int result = command.ExecuteNonQuery();
                //CommandText属性用于保存SQL语句
                command.CommandText = "delete from Student where StudentNo='" + stuNo + "'";
                result = command.ExecuteNonQuery();
                return result;

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
