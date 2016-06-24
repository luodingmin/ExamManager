namespace ExamManager
{
    partial class FrmAddTeacher
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rdbMen = new System.Windows.Forms.RadioButton();
            this.rdbWomen = new System.Windows.Forms.RadioButton();
            this.grbSex = new System.Windows.Forms.GroupBox();
            this.cmbPost = new System.Windows.Forms.ComboBox();
            this.cmbSpecialty = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.grbSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓  名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "教师编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "职  务";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "任课专业";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "联系方式";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 21);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 21);
            this.textBox2.TabIndex = 7;
            // 
            // rdbMen
            // 
            this.rdbMen.AutoSize = true;
            this.rdbMen.Checked = true;
            this.rdbMen.Location = new System.Drawing.Point(32, 20);
            this.rdbMen.Name = "rdbMen";
            this.rdbMen.Size = new System.Drawing.Size(35, 16);
            this.rdbMen.TabIndex = 8;
            this.rdbMen.TabStop = true;
            this.rdbMen.Text = "男";
            this.rdbMen.UseVisualStyleBackColor = true;
            this.rdbMen.CheckedChanged += new System.EventHandler(this.rdbMen_CheckedChanged);
            // 
            // rdbWomen
            // 
            this.rdbWomen.AutoSize = true;
            this.rdbWomen.Location = new System.Drawing.Point(164, 20);
            this.rdbWomen.Name = "rdbWomen";
            this.rdbWomen.Size = new System.Drawing.Size(35, 16);
            this.rdbWomen.TabIndex = 9;
            this.rdbWomen.Text = "女";
            this.rdbWomen.UseVisualStyleBackColor = true;
            // 
            // grbSex
            // 
            this.grbSex.Controls.Add(this.rdbMen);
            this.grbSex.Controls.Add(this.rdbWomen);
            this.grbSex.Location = new System.Drawing.Point(12, 116);
            this.grbSex.Name = "grbSex";
            this.grbSex.Size = new System.Drawing.Size(243, 55);
            this.grbSex.TabIndex = 10;
            this.grbSex.TabStop = false;
            this.grbSex.Text = "性  别";
            // 
            // cmbPost
            // 
            this.cmbPost.FormattingEnabled = true;
            this.cmbPost.Location = new System.Drawing.Point(71, 202);
            this.cmbPost.Name = "cmbPost";
            this.cmbPost.Size = new System.Drawing.Size(184, 20);
            this.cmbPost.TabIndex = 11;
            // 
            // cmbSpecialty
            // 
            this.cmbSpecialty.FormattingEnabled = true;
            this.cmbSpecialty.Location = new System.Drawing.Point(71, 248);
            this.cmbSpecialty.Name = "cmbSpecialty";
            this.cmbSpecialty.Size = new System.Drawing.Size(184, 20);
            this.cmbSpecialty.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(72, 294);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(183, 21);
            this.txtPhone.TabIndex = 13;
            // 
            // FrmAddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 352);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.cmbSpecialty);
            this.Controls.Add(this.cmbPost);
            this.Controls.Add(this.grbSex);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddTeacher";
            this.Text = "教师添加";
            this.grbSex.ResumeLayout(false);
            this.grbSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rdbMen;
        private System.Windows.Forms.RadioButton rdbWomen;
        private System.Windows.Forms.GroupBox grbSex;
        private System.Windows.Forms.ComboBox cmbPost;
        private System.Windows.Forms.ComboBox cmbSpecialty;
        private System.Windows.Forms.TextBox txtPhone;
    }
}