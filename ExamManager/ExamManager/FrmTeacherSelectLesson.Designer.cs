namespace ExamManager
{
    partial class FrmTeacherSelectLesson
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
            this.dgvTeacherSelectLesson = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherSelectLesson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacherSelectLesson
            // 
            this.dgvTeacherSelectLesson.AllowUserToAddRows = false;
            this.dgvTeacherSelectLesson.AllowUserToDeleteRows = false;
            this.dgvTeacherSelectLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeacherSelectLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherSelectLesson.Location = new System.Drawing.Point(12, 12);
            this.dgvTeacherSelectLesson.Name = "dgvTeacherSelectLesson";
            this.dgvTeacherSelectLesson.ReadOnly = true;
            this.dgvTeacherSelectLesson.RowTemplate.Height = 23;
            this.dgvTeacherSelectLesson.Size = new System.Drawing.Size(660, 242);
            this.dgvTeacherSelectLesson.TabIndex = 0;
            // 
            // FrmTeacherSelectLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 262);
            this.Controls.Add(this.dgvTeacherSelectLesson);
            this.Name = "FrmTeacherSelectLesson";
            this.Text = "教师课程安排查询";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherSelectLesson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeacherSelectLesson;
    }
}