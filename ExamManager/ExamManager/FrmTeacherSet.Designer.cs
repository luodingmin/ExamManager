namespace ExamManager
{
    partial class FrmTeacherSet
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
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.btSelectTeacher = new System.Windows.Forms.Button();
            this.btAddTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择教师";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Items.AddRange(new object[] {
            "---全选---"});
            this.cmbTeacher.Location = new System.Drawing.Point(81, 22);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(153, 20);
            this.cmbTeacher.TabIndex = 1;
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AllowUserToDeleteRows = false;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Location = new System.Drawing.Point(12, 48);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.RowTemplate.Height = 23;
            this.dgvTeacher.Size = new System.Drawing.Size(825, 263);
            this.dgvTeacher.TabIndex = 2;
            // 
            // btSelectTeacher
            // 
            this.btSelectTeacher.Location = new System.Drawing.Point(258, 20);
            this.btSelectTeacher.Name = "btSelectTeacher";
            this.btSelectTeacher.Size = new System.Drawing.Size(75, 23);
            this.btSelectTeacher.TabIndex = 3;
            this.btSelectTeacher.Text = "查  询";
            this.btSelectTeacher.UseVisualStyleBackColor = true;
            // 
            // btAddTeacher
            // 
            this.btAddTeacher.Location = new System.Drawing.Point(740, 20);
            this.btAddTeacher.Name = "btAddTeacher";
            this.btAddTeacher.Size = new System.Drawing.Size(75, 23);
            this.btAddTeacher.TabIndex = 4;
            this.btAddTeacher.Text = "添加教师";
            this.btAddTeacher.UseVisualStyleBackColor = true;
            this.btAddTeacher.Click += new System.EventHandler(this.btAddTeacher_Click);
            // 
            // FrmTeacherSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 323);
            this.Controls.Add(this.btAddTeacher);
            this.Controls.Add(this.btSelectTeacher);
            this.Controls.Add(this.dgvTeacher);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.label1);
            this.Name = "FrmTeacherSet";
            this.Text = "教师信息设置";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.Button btSelectTeacher;
        private System.Windows.Forms.Button btAddTeacher;
    }
}