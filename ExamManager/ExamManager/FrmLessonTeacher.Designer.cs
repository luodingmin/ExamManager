namespace ExamManager
{
    partial class FrmLessonTeacher
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
            this.cmbTeacherL = new System.Windows.Forms.ComboBox();
            this.cmbClassL = new System.Windows.Forms.ComboBox();
            this.cmbLessonL = new System.Windows.Forms.ComboBox();
            this.btOKL = new System.Windows.Forms.Button();
            this.btCancelL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择教师";
            // 
            // cmbTeacherL
            // 
            this.cmbTeacherL.FormattingEnabled = true;
            this.cmbTeacherL.Location = new System.Drawing.Point(109, 24);
            this.cmbTeacherL.Name = "cmbTeacherL";
            this.cmbTeacherL.Size = new System.Drawing.Size(166, 20);
            this.cmbTeacherL.TabIndex = 2;
            // 
            // cmbClassL
            // 
            this.cmbClassL.FormattingEnabled = true;
            this.cmbClassL.Location = new System.Drawing.Point(109, 70);
            this.cmbClassL.Name = "cmbClassL";
            this.cmbClassL.Size = new System.Drawing.Size(166, 20);
            this.cmbClassL.TabIndex = 3;
            // 
            // cmbLessonL
            // 
            this.cmbLessonL.FormattingEnabled = true;
            this.cmbLessonL.Location = new System.Drawing.Point(109, 123);
            this.cmbLessonL.Name = "cmbLessonL";
            this.cmbLessonL.Size = new System.Drawing.Size(166, 20);
            this.cmbLessonL.TabIndex = 4;
            // 
            // btOKL
            // 
            this.btOKL.Location = new System.Drawing.Point(66, 201);
            this.btOKL.Name = "btOKL";
            this.btOKL.Size = new System.Drawing.Size(75, 23);
            this.btOKL.TabIndex = 5;
            this.btOKL.Text = "确  定";
            this.btOKL.UseVisualStyleBackColor = true;
            // 
            // btCancelL
            // 
            this.btCancelL.Location = new System.Drawing.Point(200, 201);
            this.btCancelL.Name = "btCancelL";
            this.btCancelL.Size = new System.Drawing.Size(75, 23);
            this.btCancelL.TabIndex = 6;
            this.btCancelL.Text = "取  消";
            this.btCancelL.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "请选择班级";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "请选择课程";
            // 
            // FrmLessonTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 259);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancelL);
            this.Controls.Add(this.btOKL);
            this.Controls.Add(this.cmbLessonL);
            this.Controls.Add(this.cmbClassL);
            this.Controls.Add(this.cmbTeacherL);
            this.Controls.Add(this.label1);
            this.Name = "FrmLessonTeacher";
            this.Text = "教师课程安排";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTeacherL;
        private System.Windows.Forms.ComboBox cmbClassL;
        private System.Windows.Forms.ComboBox cmbLessonL;
        private System.Windows.Forms.Button btOKL;
        private System.Windows.Forms.Button btCancelL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}