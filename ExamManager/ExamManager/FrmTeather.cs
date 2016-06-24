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
    public partial class FrmTeather : Form
    {
        public FrmTeather()
        {
            InitializeComponent();
        }

        private void 帮助HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //鼠标有问题，想拖控件却成双击
        }

        private void 成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExamInput frmExamInput = new FrmExamInput();
            frmExamInput.MdiParent = this;
            frmExamInput.Show();
        }

        private void 信息反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHelper frmHelp = new FrmHelper();
            frmHelp.MdiParent = this;
            frmHelp.Show();
        }

        private void 学生信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeacherInfoSelect frmTeacherInfoSelect = new FrmTeacherInfoSelect();
            frmTeacherInfoSelect.MdiParent = this;
            frmTeacherInfoSelect.Show();
        }

        private void 工作安排ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂无工作安排！");
        }

        private void 课程安排ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeacherSelectLesson frmTeacherSelectLesson = new FrmTeacherSelectLesson();
            frmTeacherSelectLesson.MdiParent = this;
            frmTeacherSelectLesson.Show();
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExamSelect frmExamSelect = new FrmExamSelect();
            frmExamSelect.MdiParent = this;
            frmExamSelect.Show();
        }
    }
}
