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
    public partial class FrmTeacherSet : Form
    {
        public FrmTeacherSet()
        {
            InitializeComponent();
        }

        private void btAddTeacher_Click(object sender, EventArgs e)
        {
            FrmAddTeacher frmAddTeacher = new FrmAddTeacher();
            frmAddTeacher.Show();
            this.Hide();
        }
    }
}
