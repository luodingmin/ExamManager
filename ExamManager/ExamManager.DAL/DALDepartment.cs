using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ExamManager.Model;

namespace ExamManager.DAL
{
    public class DALDepartment
    {
        /// <summary>
        /// AddDepartment:添加部门信息
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public bool AddDepartment(Department department)
        {           
            string sql = "insert into Department(DepartmentID, DepartmentName, DepartmentEasyName,DepartmentBewrite) values(@DepartmentID, @DepartmentName, @DepartmentEasyName,@DepartmentBewrite)";
            SqlParameter[] parameters = {    
                                            new SqlParameter("@DepartmentID", SqlDbType.Int),                  //指定变量名、类型
                                            new SqlParameter("@DepartmentName", SqlDbType.VarChar, 50),        
                                            new SqlParameter("@DepartmentEasyName", SqlDbType.VarChar, 50),    
                                            new SqlParameter("@DepartmentBewrite", SqlDbType.VarChar, 200)    
                                        };
            parameters[0].Value = department.DepartmentID;                       //给SQL参数赋值
            parameters[1].Value = department.DepartmentName;            
            parameters[2].Value = department.DepartmentEasyName;        
            parameters[3].Value = department.DepartmentBewrite;

            int n = DBHelper.ExecuteCommand(sql, parameters);                //调用执行DBHelper中的ExecuteCommand方法并返回结果
            return n == 1;                                                   //受影响行为等于1，返回真值，否则为假值
        }

        /// <summary>
        /// ModifyDepartment:修改部门信息
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public bool ModifyDepartment(Department department)
        {
            string sql = "update Department set DepartmentName = @DepartmentName, DepartmentEasyName = @DepartmentEasyName, DepartmentBewrite = @DepartmentBewrite where DepartmentID = @DepartmentID";
            SqlParameter[] parameters = {
                                            new SqlParameter("@DepartmentName", SqlDbType.VarChar, 50),              //指定变量名、类型
                                            new SqlParameter("@DepartmentEasyName", SqlDbType.VarChar, 50),
                                            new SqlParameter("@DepartmentBewrite", SqlDbType.VarChar, 200),
                                            new SqlParameter("@DepartmentID", SqlDbType.Int)
                                        };

            parameters[0].Value = department.DepartmentName;                           //给SQL参数赋值
            parameters[1].Value = department.DepartmentEasyName;
            parameters[2].Value = department.DepartmentBewrite;
            parameters[3].Value = department.DepartmentID;

            int n = DBHelper.ExecuteCommand(sql, parameters);                     //调用执行DBHelper中的ExecuteCommand方法并返回结果
            return n == 1;                                                        //受影响行为等于1，返回真值，否则为假值
        }

        /// <summary>
        /// DeleteDepartment(int departmentId):按部门编号删除一条记录
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        public bool DeleteDepartment(int departmentId)
        {
            string sql = "delete from Department where DepartmentID = @DepartmentID";
            SqlParameter parameter = new SqlParameter("@DepartmentID", SqlDbType.Int);        //指定变量名、类型
            parameter.Value = departmentId;                                                   //设置SQL参数值
            int n = DBHelper.ExecuteCommand(sql, parameter);                                  //调用执行DBHelper中的ExecuteCommand方法并返回结果
            return n == 1;                                                                    //受影响行为等于1，返回真值，否则为假值
            
        }
       /// <summary>
        ///  GetAllDepartment:获取所有部门信息
       /// </summary>
       /// <returns></returns>
        public IList<Department> GetAllDepartment()
        {
            IList<Department> listDepartment = new List<Department>();                        //定义保存结果的泛型集合
            string sql = "select * from Department";                      
            using (SqlDataReader reader = DBHelper.ExecuteReader(sql))                        //using 管理SqlDataReader对象，结束时自动关闭
            {
                while (reader.Read())                                                         //读取每一行数据
                {
                    Department department = new Department();                                 //实例化实体类Department用于保存当前的一条记录
                    department.DepartmentID = int.Parse(reader["DepartmentID"].ToString());   //获取字段值
                    department.DepartmentName = reader["DepartmentName"].ToString();       
                    department.DepartmentEasyName = reader["DepartmentEasyName"].ToString();     
                    department.DepartmentBewrite = reader["DepartmentBewrite"].ToString(); 
                    listDepartment.Add(department);                                           //添加一条记录到结果集合中
                }
            }
            return listDepartment;            //返回查询结果
        }

        /// <summary>
        /// GetDepartmentByDepartmentID(int departmentId):按部门编号查询并返回一条记录
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        public Department GetDepartmentByDepartmentID(int departmentId)
        {
            Department department = new Department();                                     //定义保存结果的实体类
            string sql = "select * from Department where DepartmentID = @DepartmentID";   //定义SQL语句
            SqlParameter parameter = new SqlParameter("@DepartmentID", SqlDbType.Int);    //定义SQL语句的参数
            parameter.Value = departmentId;                                               //设置SQL参数 的值
            using (SqlDataReader reader = DBHelper.ExecuteReader(sql, parameter))         //执行SQL命令并返回结果
            {
                if (reader.Read())                                                        //读取一行数据
                {
                    department.DepartmentID = int.Parse(reader["DepartmentID"].ToString());        //获取字段值
                    department.DepartmentName = reader["DepartmentName"].ToString();
                    department.DepartmentEasyName = reader["DepartmentEasyName"].ToString();
                    department.DepartmentBewrite = reader["DepartmentBewrite"].ToString(); 
                }
            }
            return department;     //返回查询结果
        }


    }
}
