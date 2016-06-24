namespace ExamManager
{
    partial class FrmStudent
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
            this.信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生个人信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学习情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 信息查询ToolStripMenuItem
            // 
            this.信息查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生个人信息查询ToolStripMenuItem,
            this.成绩查询ToolStripMenuItem});
            this.信息查询ToolStripMenuItem.Name = "信息查询ToolStripMenuItem";
            this.信息查询ToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.信息查询ToolStripMenuItem.Text = "信息查询(&Q)";
            this.信息查询ToolStripMenuItem.Click += new System.EventHandler(this.信息查询ToolStripMenuItem_Click);
            // 
            // 学生个人信息查询ToolStripMenuItem
            // 
            this.学生个人信息查询ToolStripMenuItem.Name = "学生个人信息查询ToolStripMenuItem";
            this.学生个人信息查询ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.学生个人信息查询ToolStripMenuItem.Text = "个人信息查询(&E)";
            this.学生个人信息查询ToolStripMenuItem.Click += new System.EventHandler(this.学生个人信息查询ToolStripMenuItem_Click);
            // 
            // 成绩查询ToolStripMenuItem
            // 
            this.成绩查询ToolStripMenuItem.Name = "成绩查询ToolStripMenuItem";
            this.成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.成绩查询ToolStripMenuItem.Text = "成绩查询(&R)";
            this.成绩查询ToolStripMenuItem.Click += new System.EventHandler(this.成绩查询ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息查询ToolStripMenuItem,
            this.课程管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.课程选择ToolStripMenuItem,
            this.学习情况ToolStripMenuItem});
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.课程管理ToolStripMenuItem.Text = "课程管理(&W)";
            // 
            // 课程选择ToolStripMenuItem
            // 
            this.课程选择ToolStripMenuItem.Name = "课程选择ToolStripMenuItem";
            this.课程选择ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.课程选择ToolStripMenuItem.Text = "课程选择(&T)";
            this.课程选择ToolStripMenuItem.Click += new System.EventHandler(this.课程选择ToolStripMenuItem_Click);
            // 
            // 学习情况ToolStripMenuItem
            // 
            this.学习情况ToolStripMenuItem.Name = "学习情况ToolStripMenuItem";
            this.学习情况ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.学习情况ToolStripMenuItem.Text = "学习情况(&Y)";
            this.学习情况ToolStripMenuItem.Click += new System.EventHandler(this.学习情况ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息反馈ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 信息反馈ToolStripMenuItem
            // 
            this.信息反馈ToolStripMenuItem.Name = "信息反馈ToolStripMenuItem";
            this.信息反馈ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.信息反馈ToolStripMenuItem.Text = "信息反馈(&M)";
            this.信息反馈ToolStripMenuItem.Click += new System.EventHandler(this.信息反馈ToolStripMenuItem_Click);
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 402);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生操作界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生个人信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩查询ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学习情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息反馈ToolStripMenuItem;

    }
}