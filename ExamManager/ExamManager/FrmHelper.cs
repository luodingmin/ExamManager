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
    public partial class FrmHelper : Form
    {
        public FrmHelper()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //鼠标有问题，想拖控件却成双击
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //鼠标有问题，想拖控件却成双击
        }

        private void FrmHelper_Load(object sender, EventArgs e)
        {
            //鼠标有问题，想拖控件却成双击
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //鼠标有问题，想拖控件却成双击
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (txtHelp.Text == "")   //用null不行         
            {
                MessageBox.Show("不允许上交空文档！");
            }
            else
            {
                txtHelp.Text = "";
                MessageBox.Show("已经提交至上级有关部门！可能会收不到他们的回复！");
            }
        }

        private void btOff_Click(object sender, EventArgs e)
        {
            txtHelp.Text = "";
            this.Close();
            
        }
    }
}
