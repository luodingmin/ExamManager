using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamManager
{
    public partial class FrmManager : Form
    {
        public FrmManager()
        {
            InitializeComponent();
        }

        private void 教师管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 信息反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHelper frmHelp = new FrmHelper();
            frmHelp.MdiParent = this;
            frmHelp.Show();
        }

        private void 部门管理RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartmentSet frmDepartmentSet = new FrmDepartmentSet();
            frmDepartmentSet.MdiParent = this;
            frmDepartmentSet.Show();
        }

        private void 专业设置TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSpecialtySet frmSpecialtySet = new FrmSpecialtySet();
            frmSpecialtySet.MdiParent = this;
            frmSpecialtySet.Show();
        }

        private void 基本设置YToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaseInfo frmBaseInfo = new FrmBaseInfo();
            frmBaseInfo.MdiParent = this;
            frmBaseInfo.Show();
        }

        private void 教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeacherSet frmTeacherSet = new FrmTeacherSet();
            frmTeacherSet.MdiParent = this;
            frmTeacherSet.Show();            
        }

        private void 工作安排ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂无工作安排！");
        }

        private void 课程安排ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLessonTeacher frmLessonTeacher = new FrmLessonTeacher();
            frmLessonTeacher.MdiParent = this;
            frmLessonTeacher.Show();
        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentInfoM frmStudentInfoM = new FrmStudentInfoM();
            frmStudentInfoM.MdiParent = this;
            frmStudentInfoM.Show();
        }

        private void 成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExamInput frmExamInput = new FrmExamInput();
            frmExamInput.MdiParent = this;
            frmExamInput.Show();
            
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExamSelect frmExamSelect = new FrmExamSelect();
            frmExamSelect.MdiParent = this;
            frmExamSelect.Show();
        }

        private void 课程安排ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLessonStudent frmLessonStudent = new FrmLessonStudent();
            frmLessonStudent.MdiParent = this;
            frmLessonStudent.Show();
        }
    }
}
