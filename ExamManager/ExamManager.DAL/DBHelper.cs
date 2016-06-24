using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;                  //添加引用
using System.Data.SqlClient;        //添加引用
using ExamManager.Model;            //添加引用


namespace ExamManager.DAL
{
    public class DBHelper
    {
        private static readonly string connString = "";

        #region 公共方法
        /// <summary>
        /// 执行SQL语句并返回受影响的行数（应用于 增、改、删）
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="values">数据组形式的SQL语句参数</param>
        /// <returns></returns>
        public static int ExecuteCommand(string sql, params SqlParameter[] values)
        {
            using (SqlConnection conn = new SqlConnection(connString))  //定义数据库连接对象
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))      //定义数据库命令对象
                {
                    try
                    {
                        conn.Open();                                        //打开连接
                        cmd.Parameters.AddRange(values);                    //以数组的形式传递SQL语句的参数
                        int rows = cmd.ExecuteNonQuery();                   //执行SQL命令并得到返影响的行数
                        return rows;                                        //方法返回值
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// ExecuteReader(string sql):查询并返回SqlDataReader,调用后一定要关闭连接
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlDataReader reader = null;                         //定义SqlDataReader用于接收查询结果
            SqlConnection conn = new SqlConnection(connString);  //定义连接对象
            SqlCommand cmd = new SqlCommand(sql, conn);          //定义SQL命令对象
            conn.Open();                                         //打开连接
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);  //执行命令并得到 结果集
            return reader;                                       //返回结果
        }

        /// <summary>
        /// ExecuteReader(string sql):查询并返回SqlDataReader,调用后一定要关闭连接
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="values">数据组形式的SQL语句参数</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] values)
        {
            SqlDataReader reader = null;                         //定义SqlDataReader用于接收查询结果
            SqlConnection conn = new SqlConnection(connString);  //定义连接对象
            SqlCommand cmd = new SqlCommand(sql, conn);          //定义SQL命令对象
            conn.Open();                                         //打开连接             
            cmd.Parameters.AddRange(values);                     //传递SQL语句的参数
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);  //执行命令并得到 结果集
            return reader;                                       //返回结果
        }

        /// <summary>
        /// 以数据集返回查询的结果（适用于结果为多条记录的查询）
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public static DataSet Query(string sql)
        {
            DataSet ds = new DataSet();                    //定义数据集以保存查询结果
            using (SqlConnection conn = new SqlConnection(connString))    //管理连接对象
            {
                SqlDataAdapter ada = new SqlDataAdapter(sql, conn);       //定义数据适配器对象
                conn.Open();                                              //打开连接
                ada.Fill(ds);                                             //填充数据
            }
            return ds;                                                    //返回结果
        }


        /// <summary>
        /// 以数据集返回查询的结果（适用于结果为多条记录的查询）
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="values">数据组形式的SQL语句参数</param>
        /// <returns></returns>
        public static DataSet Query(string sql, params SqlParameter[] values)
        {
            DataSet ds = new DataSet();                    //定义数据集以保存查询结果
            using (SqlConnection conn = new SqlConnection(connString))    //管理连接对象
            {
                SqlDataAdapter ada = new SqlDataAdapter(sql, conn);       //定义数据适配器对象
                conn.Open();                                              //打开连接
                ada.SelectCommand.Parameters.AddRange(values);            //传递SQL语句的参数
                ada.Fill(ds);                                             //填充数据
            }
            return ds;                                                    //返回结果
        }

        /// <summary>
        /// 描述：将DataTable的内容写入到SQL SERVER 中指定的表
        /// </summary>
        /// <param name="srcColumns">DataTable中的字段名列表</param>
        /// <param name="dscColumns">SQL SERVER 数据库表的字段名列表</param>
        /// <param name="srcDt">作为数据来源的DataTable</param>
        /// <param name="dscTable">被写入数据的数据库表名</param>
        /// <returns></returns>
        public static bool DataTableIntoSqlTable(string[] srcColumns, string[] dscColumns, DataTable srcDt, string dscTable)
        {
            bool flag = false;                    //默认写入失败
            using (SqlConnection conn = new SqlConnection(connString))     //创建数据库连接对象
            {   //创建sqlBulkCopy对象，用于大量数据添加操作
                using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(connString, SqlBulkCopyOptions.UseInternalTransaction))
                {
                    sqlBulkCopy.BulkCopyTimeout = 600;   //指定超时时间，以秒为单位，默认是30秒，设为0则不限时间
                    sqlBulkCopy.DestinationTableName = dscTable;  //数据复制的目标数据库的 表名

                    for (int i = 0; i < srcColumns.Length; i++)    //使用循环进行源表和目标表之间的字段名映射
                    {
                        sqlBulkCopy.ColumnMappings.Add(srcColumns[i], dscColumns[i]);
                    }
                    try
                    {
                        sqlBulkCopy.WriteToServer(srcDt);  //将数据表dt的内容 写入到数据库中 临时表TempTeacher中
                        flag = true;                   //写入成功修改标志值为真
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return flag;
        }


        #endregion
    }
}
