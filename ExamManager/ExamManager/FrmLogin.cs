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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rdbTypeManager.Checked)
            {
                FrmManager fmg = new FrmManager();
                fmg.Show();
                this.Hide();
            }
            else if (rdbTypeTeacher.Checked)
            {
                FrmTeather ftt = new FrmTeather();
                ftt.Show();
                this.Hide();
            }
            else
            {
                FrmStudent fsd = new FrmStudent();
                fsd.Show();
                this.Hide();
            }
        }

        private void grbUserType_Enter(object sender, EventArgs e)
        {
           
        }

        private void lbTuichu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtUserPwd.Text = "";
            
        }
    }
}
