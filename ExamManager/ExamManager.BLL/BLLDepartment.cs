using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExamManager.DAL;
using ExamManager.Model;

namespace ExamManager.BLL
{
    public class BLLDepartment
    {
        private DALDepartment dalDepartment = new DALDepartment();  //定义私有变量  
        public bool AddDepartment(Department department)            //添加部门信息
        {
            return dalDepartment.AddDepartment(department);
        }
        public bool ModifyDepartment(Department department)         //修改部门信息
        {
            return dalDepartment.ModifyDepartment(department);
        }
        public bool DeleteDepartment(int departmentId)              //删除部门信息
        {
            return dalDepartment.DeleteDepartment(departmentId);
        }
        public IList<Department> GetAllDepartment()                 //获取所有bi部门信息
        {
            return dalDepartment.GetAllDepartment();
        }
        public Department GetDepartmentByDepartmentID(int departmentId)  //按部门编号查询信息
        {
            return dalDepartment.GetDepartmentByDepartmentID(departmentId);
        }

    }
}
