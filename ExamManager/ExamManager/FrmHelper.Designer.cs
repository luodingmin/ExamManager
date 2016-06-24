namespace ExamManager
{
    partial class FrmHelper
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "如果有什么意见需要向上级反馈的，可以在下面文本框中填写";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtHelp
            // 
            this.txtHelp.Location = new System.Drawing.Point(12, 58);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(460, 292);
            this.txtHelp.TabIndex = 2;
            this.txtHelp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(37, 367);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "提  交";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btOff
            // 
            this.btOff.Location = new System.Drawing.Point(365, 367);
            this.btOff.Name = "btOff";
            this.btOff.Size = new System.Drawing.Size(75, 23);
            this.btOff.TabIndex = 4;
            this.btOff.Text = "取  消";
            this.btOff.UseVisualStyleBackColor = true;
            this.btOff.Click += new System.EventHandler(this.btOff_Click);
            // 
            // FrmHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 402);
            this.Controls.Add(this.btOff);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.label2);
            this.Name = "FrmHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信息反馈";
            this.Load += new System.EventHandler(this.FrmHelper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btOff;
    }
}