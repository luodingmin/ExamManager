namespace ExamManager
{
    partial class FrmLessonSelect
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
            this.dgvLessonStelect = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessonStelect)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLessonStelect
            // 
            this.dgvLessonStelect.AllowUserToAddRows = false;
            this.dgvLessonStelect.AllowUserToDeleteRows = false;
            this.dgvLessonStelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLessonStelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLessonStelect.Location = new System.Drawing.Point(12, 12);
            this.dgvLessonStelect.Name = "dgvLessonStelect";
            this.dgvLessonStelect.ReadOnly = true;
            this.dgvLessonStelect.RowTemplate.Height = 23;
            this.dgvLessonStelect.Size = new System.Drawing.Size(660, 238);
            this.dgvLessonStelect.TabIndex = 0;
            // 
            // FrmLessonSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 262);
            this.Controls.Add(this.dgvLessonStelect);
            this.Name = "FrmLessonSelect";
            this.Text = "课程选择";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessonStelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLessonStelect;
    }
}