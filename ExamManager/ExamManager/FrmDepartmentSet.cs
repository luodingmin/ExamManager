using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExamManager.BLL;
using ExamManager.Model;

namespace ExamManager
{
    public partial class FrmDepartmentSet : Form
    {
        private BLLDepartment bllDepartment = new BLLDepartment();              //定义BLLDepartment私有变量        
        public FrmDepartmentSet()
        {
            InitializeComponent();
        }

        private void FrmDepartmentSet_Load(object sender, EventArgs e)
        {
            IList<Department> listDepartment = bllDepartment.GetAllDepartment();            //调用bll层GetAllDepartment方法
            listDepartment.Insert(0, new Department { DepartmentName = "--请选择部门--", DepartmentID = -1 });//添加一行
            cmbDepartment.DisplayMember = "DepartmentName";                                 //绑定显示值
            cmbDepartment.ValueMember = "DepartmentID";                                     //绑定值
            cmbDepartment.DataSource = listDepartment;
            dgvDepartment.DataSource = listDepartment;
        }

        private void FrmDepartmentSet_Load_1(object sender, EventArgs e)
        {

        }

        private void cmbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int departmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
            if (departmentId == -1)
            {
                dgvDepartment.DataSource = bllDepartment.GetAllDepartment();

            }
            else
            {
                dgvDepartment.DataSource = bllDepartment.GetDepartmentByDepartmentID(departmentId);

            }
            
        }
        private void AddDepartment()
        {
            string departmentId = txtDepartmentID.Text.Trim();  //接收部门名称的内容，去掉前后空格
            if (string.IsNullOrEmpty(departmentId))          //判断部门名称是否为空
            {
                MessageBox.Show("部门编号不能为空");           //显示错误提示信息
            }
            else
            {
                Department department = new Department();                          //实例化部门实体类以保存数据
                department.DepartmentID = int.Parse(txtDepartmentID.ToString());//设置实体类的值
                department.DepartmentName =txtDepartmentName.Text.Trim();                        
                department.DepartmentEasyName = txtDepartmentEasyName.Text.Trim();
                department.DepartmentBewrite = txtDepartmentTalk.Text; 
                if (bllDepartment.AddDepartment(department))                //添加记录并判断是否成功
                {
                    txtDepartmentID.Text = "";                                        //清空四个文本框的内容
                    txtDepartmentName.Text = "";
                    txtDepartmentTalk.Text = "";
                    txtDepartmentEasyName.Text = "";
                }
                else
                {
                    MessageBox.Show("无法添加部门信息！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error); //显示失败的对话框
                }
            }
        }

        private void btAddDepartment_Click(object sender, EventArgs e)
        {
            AddDepartment();                                    //单机鼠标调用AddDepartment()方法
        }

        private void btOffDepartment_Click(object sender, EventArgs e)
        {
            txtDepartmentID.Text = "";
            txtDepartmentName.Text = "";
            txtDepartmentTalk.Text = "";
            txtDepartmentEasyName.Text = "";
        }
       
    }
}
