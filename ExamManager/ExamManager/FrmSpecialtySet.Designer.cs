namespace ExamManager
{
    partial class FrmSpecialtySet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpecialtyName = new System.Windows.Forms.TextBox();
            this.txtSpecialtyEasyName = new System.Windows.Forms.TextBox();
            this.txtSpecialtyTalk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSpecialtyID = new System.Windows.Forms.TextBox();
            this.btAddSpecialty = new System.Windows.Forms.Button();
            this.btSpecialtyOff = new System.Windows.Forms.Button();
            this.grbSpecialty = new System.Windows.Forms.GroupBox();
            this.dgvSpecialty = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSpecialty = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.grbSpecialty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSpecialtyOff);
            this.groupBox1.Controls.Add(this.btAddSpecialty);
            this.groupBox1.Controls.Add(this.txtSpecialtyID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSpecialtyTalk);
            this.groupBox1.Controls.Add(this.txtSpecialtyEasyName);
            this.groupBox1.Controls.Add(this.txtSpecialtyName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加专业";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择部门";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "---全选---",
            "信息工程学院",
            "财经学院"});
            this.comboBox1.Location = new System.Drawing.Point(83, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "专业名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "专业简称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "专业描述";
            // 
            // txtSpecialtyName
            // 
            this.txtSpecialtyName.Location = new System.Drawing.Point(81, 60);
            this.txtSpecialtyName.Name = "txtSpecialtyName";
            this.txtSpecialtyName.Size = new System.Drawing.Size(209, 21);
            this.txtSpecialtyName.TabIndex = 3;
            // 
            // txtSpecialtyEasyName
            // 
            this.txtSpecialtyEasyName.Location = new System.Drawing.Point(81, 103);
            this.txtSpecialtyEasyName.Name = "txtSpecialtyEasyName";
            this.txtSpecialtyEasyName.Size = new System.Drawing.Size(209, 21);
            this.txtSpecialtyEasyName.TabIndex = 4;
            // 
            // txtSpecialtyTalk
            // 
            this.txtSpecialtyTalk.Location = new System.Drawing.Point(81, 146);
            this.txtSpecialtyTalk.Multiline = true;
            this.txtSpecialtyTalk.Name = "txtSpecialtyTalk";
            this.txtSpecialtyTalk.Size = new System.Drawing.Size(209, 178);
            this.txtSpecialtyTalk.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "专业编号";
            // 
            // txtSpecialtyID
            // 
            this.txtSpecialtyID.Location = new System.Drawing.Point(81, 23);
            this.txtSpecialtyID.Name = "txtSpecialtyID";
            this.txtSpecialtyID.Size = new System.Drawing.Size(209, 21);
            this.txtSpecialtyID.TabIndex = 7;
            // 
            // btAddSpecialty
            // 
            this.btAddSpecialty.Location = new System.Drawing.Point(24, 329);
            this.btAddSpecialty.Name = "btAddSpecialty";
            this.btAddSpecialty.Size = new System.Drawing.Size(75, 23);
            this.btAddSpecialty.TabIndex = 8;
            this.btAddSpecialty.Text = "添  加";
            this.btAddSpecialty.UseVisualStyleBackColor = true;
            // 
            // btSpecialtyOff
            // 
            this.btSpecialtyOff.Location = new System.Drawing.Point(215, 329);
            this.btSpecialtyOff.Name = "btSpecialtyOff";
            this.btSpecialtyOff.Size = new System.Drawing.Size(75, 23);
            this.btSpecialtyOff.TabIndex = 9;
            this.btSpecialtyOff.Text = "取  消";
            this.btSpecialtyOff.UseVisualStyleBackColor = true;
            // 
            // grbSpecialty
            // 
            this.grbSpecialty.Controls.Add(this.cmbSpecialty);
            this.grbSpecialty.Controls.Add(this.label7);
            this.grbSpecialty.Controls.Add(this.dgvSpecialty);
            this.grbSpecialty.Location = new System.Drawing.Point(333, 18);
            this.grbSpecialty.Name = "grbSpecialty";
            this.grbSpecialty.Size = new System.Drawing.Size(560, 380);
            this.grbSpecialty.TabIndex = 3;
            this.grbSpecialty.TabStop = false;
            this.grbSpecialty.Text = "专业信息查询";
            // 
            // dgvSpecialty
            // 
            this.dgvSpecialty.AllowUserToAddRows = false;
            this.dgvSpecialty.AllowUserToDeleteRows = false;
            this.dgvSpecialty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecialty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvSpecialty.Location = new System.Drawing.Point(6, 81);
            this.dgvSpecialty.Name = "dgvSpecialty";
            this.dgvSpecialty.ReadOnly = true;
            this.dgvSpecialty.RowTemplate.Height = 23;
            this.dgvSpecialty.Size = new System.Drawing.Size(540, 300);
            this.dgvSpecialty.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "专业编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "专业名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "专业简称";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "所属部门";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "专业描述";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "请选择专业";
            // 
            // cmbSpecialty
            // 
            this.cmbSpecialty.FormattingEnabled = true;
            this.cmbSpecialty.Location = new System.Drawing.Point(77, 37);
            this.cmbSpecialty.Name = "cmbSpecialty";
            this.cmbSpecialty.Size = new System.Drawing.Size(182, 20);
            this.cmbSpecialty.TabIndex = 4;
            // 
            // FrmSpecialtySet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 422);
            this.Controls.Add(this.grbSpecialty);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSpecialtySet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "专业信息设置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbSpecialty.ResumeLayout(false);
            this.grbSpecialty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSpecialtyTalk;
        private System.Windows.Forms.TextBox txtSpecialtyEasyName;
        private System.Windows.Forms.TextBox txtSpecialtyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtSpecialtyID;
        private System.Windows.Forms.Button btSpecialtyOff;
        private System.Windows.Forms.Button btAddSpecialty;
        private System.Windows.Forms.GroupBox grbSpecialty;
        private System.Windows.Forms.DataGridView dgvSpecialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cmbSpecialty;
        private System.Windows.Forms.Label label7;
    }
}