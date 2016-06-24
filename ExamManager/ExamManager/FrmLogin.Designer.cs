namespace ExamManager
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbUserType = new System.Windows.Forms.GroupBox();
            this.rdbTypeStudent = new System.Windows.Forms.RadioButton();
            this.rdbTypeTeacher = new System.Windows.Forms.RadioButton();
            this.rdbTypeManager = new System.Windows.Forms.RadioButton();
            this.lbTuichu = new System.Windows.Forms.Label();
            this.grbUserType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(70, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(70, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(129, 56);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(161, 21);
            this.txtUserName.TabIndex = 3;
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(129, 108);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Size = new System.Drawing.Size(161, 21);
            this.txtUserPwd.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(72, 233);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登  录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(215, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grbUserType
            // 
            this.grbUserType.BackColor = System.Drawing.Color.Transparent;
            this.grbUserType.Controls.Add(this.rdbTypeStudent);
            this.grbUserType.Controls.Add(this.rdbTypeTeacher);
            this.grbUserType.Controls.Add(this.rdbTypeManager);
            this.grbUserType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbUserType.Location = new System.Drawing.Point(72, 159);
            this.grbUserType.Name = "grbUserType";
            this.grbUserType.Size = new System.Drawing.Size(218, 58);
            this.grbUserType.TabIndex = 7;
            this.grbUserType.TabStop = false;
            this.grbUserType.Text = "用户类型";
            this.grbUserType.Enter += new System.EventHandler(this.grbUserType_Enter);
            // 
            // rdbTypeStudent
            // 
            this.rdbTypeStudent.AutoSize = true;
            this.rdbTypeStudent.Checked = true;
            this.rdbTypeStudent.Location = new System.Drawing.Point(159, 24);
            this.rdbTypeStudent.Name = "rdbTypeStudent";
            this.rdbTypeStudent.Size = new System.Drawing.Size(53, 16);
            this.rdbTypeStudent.TabIndex = 2;
            this.rdbTypeStudent.TabStop = true;
            this.rdbTypeStudent.Text = "学 生";
            this.rdbTypeStudent.UseVisualStyleBackColor = true;
            // 
            // rdbTypeTeacher
            // 
            this.rdbTypeTeacher.AutoSize = true;
            this.rdbTypeTeacher.Location = new System.Drawing.Point(89, 24);
            this.rdbTypeTeacher.Name = "rdbTypeTeacher";
            this.rdbTypeTeacher.Size = new System.Drawing.Size(53, 16);
            this.rdbTypeTeacher.TabIndex = 1;
            this.rdbTypeTeacher.Text = "教 师";
            this.rdbTypeTeacher.UseVisualStyleBackColor = true;
            // 
            // rdbTypeManager
            // 
            this.rdbTypeManager.AutoSize = true;
            this.rdbTypeManager.Location = new System.Drawing.Point(6, 24);
            this.rdbTypeManager.Name = "rdbTypeManager";
            this.rdbTypeManager.Size = new System.Drawing.Size(59, 16);
            this.rdbTypeManager.TabIndex = 0;
            this.rdbTypeManager.Text = "管理员";
            this.rdbTypeManager.UseVisualStyleBackColor = true;
            // 
            // lbTuichu
            // 
            this.lbTuichu.AutoSize = true;
            this.lbTuichu.BackColor = System.Drawing.Color.Transparent;
            this.lbTuichu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTuichu.ForeColor = System.Drawing.Color.Blue;
            this.lbTuichu.Location = new System.Drawing.Point(242, 289);
            this.lbTuichu.Name = "lbTuichu";
            this.lbTuichu.Size = new System.Drawing.Size(42, 14);
            this.lbTuichu.TabIndex = 9;
            this.lbTuichu.Text = "退 出";
            this.lbTuichu.Click += new System.EventHandler(this.lbTuichu_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::ExamManager.Properties.Resources.Penguins;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.lbTuichu);
            this.Controls.Add(this.grbUserType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserPwd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录界面";
            this.grbUserType.ResumeLayout(false);
            this.grbUserType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbUserType;
        private System.Windows.Forms.RadioButton rdbTypeStudent;
        private System.Windows.Forms.RadioButton rdbTypeTeacher;
        private System.Windows.Forms.RadioButton rdbTypeManager;
        private System.Windows.Forms.Label lbTuichu;
    }
}

