namespace ScoreManagement
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScoreFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生信息ToolStripMenuItem,
            this.学生成绩ToolStripMenuItem,
            this.课程信息ToolStripMenuItem,
            this.权限管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生信息ToolStripMenuItem
            // 
            this.学生信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchFormToolStripMenuItem,
            this.ModifyFormToolStripMenuItem});
            this.学生信息ToolStripMenuItem.Name = "学生信息ToolStripMenuItem";
            this.学生信息ToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.学生信息ToolStripMenuItem.Text = "学生信息 ";
            // 
            // SearchFormToolStripMenuItem
            // 
            this.SearchFormToolStripMenuItem.Name = "SearchFormToolStripMenuItem";
            this.SearchFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SearchFormToolStripMenuItem.Text = "查询";
            this.SearchFormToolStripMenuItem.Click += new System.EventHandler(this.SearchFormToolStripMenuItem_Click);
            // 
            // ModifyFormToolStripMenuItem
            // 
            this.ModifyFormToolStripMenuItem.Name = "ModifyFormToolStripMenuItem";
            this.ModifyFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ModifyFormToolStripMenuItem.Text = "修改";
            this.ModifyFormToolStripMenuItem.Click += new System.EventHandler(this.ModifyFormToolStripMenuItem_Click);
            // 
            // 学生成绩ToolStripMenuItem
            // 
            this.学生成绩ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScoreFormToolStripMenuItem});
            this.学生成绩ToolStripMenuItem.Name = "学生成绩ToolStripMenuItem";
            this.学生成绩ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学生成绩ToolStripMenuItem.Text = "学生成绩";
            // 
            // ScoreFormToolStripMenuItem
            // 
            this.ScoreFormToolStripMenuItem.Name = "ScoreFormToolStripMenuItem";
            this.ScoreFormToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ScoreFormToolStripMenuItem.Text = "录入";
            this.ScoreFormToolStripMenuItem.Click += new System.EventHandler(this.ScoreFormToolStripMenuItem_Click);
            // 
            // 课程信息ToolStripMenuItem
            // 
            this.课程信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询ToolStripMenuItem,
            this.修改ToolStripMenuItem});
            this.课程信息ToolStripMenuItem.Name = "课程信息ToolStripMenuItem";
            this.课程信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.课程信息ToolStripMenuItem.Text = "课程信息";
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.查询ToolStripMenuItem.Text = "查询";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 权限管理ToolStripMenuItem
            // 
            this.权限管理ToolStripMenuItem.Name = "权限管理ToolStripMenuItem";
            this.权限管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.权限管理ToolStripMenuItem.Text = "权限管理";
            this.权限管理ToolStripMenuItem.Click += new System.EventHandler(this.权限管理ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(671, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 395);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "学生成绩管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScoreFormToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem 课程信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限管理ToolStripMenuItem;
    }
}

