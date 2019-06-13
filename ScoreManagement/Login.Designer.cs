namespace ScoreManagement
{
    partial class Login
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SignUp_btn = new System.Windows.Forms.Button();
            this.rbtnstudent = new System.Windows.Forms.RadioButton();
            this.rbtnteacher = new System.Windows.Forms.RadioButton();
            this.rbtnmanager = new System.Windows.Forms.RadioButton();
            this.Cancle_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(254, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生成绩管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(312, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(312, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "密  码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(303, 390);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 3;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(424, 228);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(231, 30);
            this.username.TabIndex = 4;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(424, 301);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(231, 30);
            this.password.TabIndex = 5;
            // 
            // SignUp_btn
            // 
            this.SignUp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SignUp_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SignUp_btn.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SignUp_btn.Location = new System.Drawing.Point(316, 447);
            this.SignUp_btn.Margin = new System.Windows.Forms.Padding(4);
            this.SignUp_btn.Name = "SignUp_btn";
            this.SignUp_btn.Size = new System.Drawing.Size(116, 38);
            this.SignUp_btn.TabIndex = 8;
            this.SignUp_btn.Text = "登录";
            this.SignUp_btn.UseVisualStyleBackColor = false;
            this.SignUp_btn.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // rbtnstudent
            // 
            this.rbtnstudent.AutoSize = true;
            this.rbtnstudent.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnstudent.Location = new System.Drawing.Point(329, 373);
            this.rbtnstudent.Name = "rbtnstudent";
            this.rbtnstudent.Size = new System.Drawing.Size(76, 28);
            this.rbtnstudent.TabIndex = 9;
            this.rbtnstudent.TabStop = true;
            this.rbtnstudent.Text = "学生";
            this.rbtnstudent.UseVisualStyleBackColor = true;
            // 
            // rbtnteacher
            // 
            this.rbtnteacher.AutoSize = true;
            this.rbtnteacher.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnteacher.Location = new System.Drawing.Point(447, 373);
            this.rbtnteacher.Name = "rbtnteacher";
            this.rbtnteacher.Size = new System.Drawing.Size(76, 28);
            this.rbtnteacher.TabIndex = 10;
            this.rbtnteacher.TabStop = true;
            this.rbtnteacher.Text = "教师";
            this.rbtnteacher.UseVisualStyleBackColor = true;
            // 
            // rbtnmanager
            // 
            this.rbtnmanager.AutoSize = true;
            this.rbtnmanager.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnmanager.Location = new System.Drawing.Point(555, 373);
            this.rbtnmanager.Name = "rbtnmanager";
            this.rbtnmanager.Size = new System.Drawing.Size(100, 28);
            this.rbtnmanager.TabIndex = 11;
            this.rbtnmanager.TabStop = true;
            this.rbtnmanager.Text = "管理员";
            this.rbtnmanager.UseVisualStyleBackColor = true;
            // 
            // Cancle_btn
            // 
            this.Cancle_btn.Font = new System.Drawing.Font("隶书", 15F);
            this.Cancle_btn.Location = new System.Drawing.Point(539, 447);
            this.Cancle_btn.Name = "Cancle_btn";
            this.Cancle_btn.Size = new System.Drawing.Size(116, 38);
            this.Cancle_btn.TabIndex = 12;
            this.Cancle_btn.Text = "取消";
            this.Cancle_btn.UseVisualStyleBackColor = true;
            this.Cancle_btn.Click += new System.EventHandler(this.Cancle_butn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ScoreManagement.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(978, 602);
            this.Controls.Add(this.Cancle_btn);
            this.Controls.Add(this.rbtnmanager);
            this.Controls.Add(this.rbtnteacher);
            this.Controls.Add(this.rbtnstudent);
            this.Controls.Add(this.SignUp_btn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button SignUp_btn;
        private System.Windows.Forms.RadioButton rbtnstudent;
        private System.Windows.Forms.RadioButton rbtnteacher;
        private System.Windows.Forms.RadioButton rbtnmanager;
        private System.Windows.Forms.Button Cancle_btn;
    }
}