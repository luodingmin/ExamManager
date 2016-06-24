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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void 信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 信息反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHelper frmHelp = new FrmHelper();
            frmHelp.MdiParent = this;
            frmHelp.Show();
        }

        private void 学生个人信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentSelectInfo frmStudentSelectInfo = new FrmStudentSelectInfo();
            frmStudentSelectInfo.MdiParent = this;
            frmStudentSelectInfo.Show();
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentSelectExam frmStudentSelectExam = new FrmStudentSelectExam();
            frmStudentSelectExam.MdiParent = this;
            frmStudentSelectExam.Show();
        }

        private void 课程选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLessonSelect frmLessonSelect = new FrmLessonSelect();
            frmLessonSelect.MdiParent = this;
            frmLessonSelect.Show();
        }

        private void 学习情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudyInfo frmStudyInfo = new FrmStudyInfo();
            frmStudyInfo.MdiParent = this;
            frmStudyInfo.Show();
        }
    }
}
