namespace ExamManager
{
    partial class FrmDepartmentSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtDepartmentEasyName = new System.Windows.Forms.TextBox();
            this.txtDepartmentTalk = new System.Windows.Forms.TextBox();
            this.btAddDepartment = new System.Windows.Forms.Button();
            this.btOffDepartment = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDepartment = new System.Windows.Forms.GroupBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.grbDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "部门名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "部门简称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "部门编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "部门描述";
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Location = new System.Drawing.Point(100, 20);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(211, 21);
            this.txtDepartmentID.TabIndex = 4;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(100, 62);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(211, 21);
            this.txtDepartmentName.TabIndex = 5;
            // 
            // txtDepartmentEasyName
            // 
            this.txtDepartmentEasyName.Location = new System.Drawing.Point(100, 104);
            this.txtDepartmentEasyName.Name = "txtDepartmentEasyName";
            this.txtDepartmentEasyName.Size = new System.Drawing.Size(211, 21);
            this.txtDepartmentEasyName.TabIndex = 6;
            // 
            // txtDepartmentTalk
            // 
            this.txtDepartmentTalk.Location = new System.Drawing.Point(100, 145);
            this.txtDepartmentTalk.Multiline = true;
            this.txtDepartmentTalk.Name = "txtDepartmentTalk";
            this.txtDepartmentTalk.Size = new System.Drawing.Size(211, 189);
            this.txtDepartmentTalk.TabIndex = 7;
            // 
            // btAddDepartment
            // 
            this.btAddDepartment.Location = new System.Drawing.Point(29, 349);
            this.btAddDepartment.Name = "btAddDepartment";
            this.btAddDepartment.Size = new System.Drawing.Size(75, 23);
            this.btAddDepartment.TabIndex = 8;
            this.btAddDepartment.Text = "添  加";
            this.btAddDepartment.UseVisualStyleBackColor = true;
            this.btAddDepartment.Click += new System.EventHandler(this.btAddDepartment_Click);
            // 
            // btOffDepartment
            // 
            this.btOffDepartment.Location = new System.Drawing.Point(236, 349);
            this.btOffDepartment.Name = "btOffDepartment";
            this.btOffDepartment.Size = new System.Drawing.Size(75, 23);
            this.btOffDepartment.TabIndex = 9;
            this.btOffDepartment.Text = "取  消";
            this.btOffDepartment.UseVisualStyleBackColor = true;
            this.btOffDepartment.Click += new System.EventHandler(this.btOffDepartment_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDepartmentTalk);
            this.groupBox1.Controls.Add(this.btOffDepartment);
            this.groupBox1.Controls.Add(this.txtDepartmentEasyName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDepartmentID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btAddDepartment);
            this.groupBox1.Controls.Add(this.txtDepartmentName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 382);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加部门";
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AllowUserToAddRows = false;
            this.dgvDepartment.AllowUserToDeleteRows = false;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgvDepartment.Location = new System.Drawing.Point(12, 65);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.ReadOnly = true;
            this.dgvDepartment.RowTemplate.Height = 23;
            this.dgvDepartment.Size = new System.Drawing.Size(496, 300);
            this.dgvDepartment.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DepartmentID";
            this.Column1.HeaderText = "部门编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DepartmentName";
            this.Column2.HeaderText = "部门名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DepartmentEasyName";
            this.Column3.HeaderText = "部门简称";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DepartmentBewrite";
            this.Column5.HeaderText = "部门描述";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // grbDepartment
            // 
            this.grbDepartment.Controls.Add(this.cmbDepartment);
            this.grbDepartment.Controls.Add(this.label5);
            this.grbDepartment.Controls.Add(this.dgvDepartment);
            this.grbDepartment.Location = new System.Drawing.Point(359, 12);
            this.grbDepartment.Name = "grbDepartment";
            this.grbDepartment.Size = new System.Drawing.Size(521, 380);
            this.grbDepartment.TabIndex = 12;
            this.grbDepartment.TabStop = false;
            this.grbDepartment.Text = "部门信息查询";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "---全选---",
            "信息工程学院",
            "财经学院"});
            this.cmbDepartment.Location = new System.Drawing.Point(83, 25);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(226, 20);
            this.cmbDepartment.TabIndex = 13;
            this.cmbDepartment.SelectionChangeCommitted += new System.EventHandler(this.cmbDepartment_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "请选择部门";
            // 
            // FrmDepartmentSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 405);
            this.Controls.Add(this.grbDepartment);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDepartmentSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门信息设置";
            this.Load += new System.EventHandler(this.FrmDepartmentSet_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.grbDepartment.ResumeLayout(false);
            this.grbDepartment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtDepartmentEasyName;
        private System.Windows.Forms.TextBox txtDepartmentTalk;
        private System.Windows.Forms.Button btAddDepartment;
        private System.Windows.Forms.Button btOffDepartment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.GroupBox grbDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}