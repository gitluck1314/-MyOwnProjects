using System;

namespace ScoreManagement
{
    partial class FormStudent
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stuBZ = new System.Windows.Forms.TextBox();
            this.stuXH = new System.Windows.Forms.TextBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.stuZXF = new System.Windows.Forms.TextBox();
            this.stuZY = new System.Windows.Forms.TextBox();
            this.stuCS = new System.Windows.Forms.TextBox();
            this.stuXM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cjDGV = new System.Windows.Forms.DataGridView();
            this.outbtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cjDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 551);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "个人信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stuBZ);
            this.groupBox2.Controls.Add(this.stuXH);
            this.groupBox2.Controls.Add(this.female);
            this.groupBox2.Controls.Add(this.male);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.stuZXF);
            this.groupBox2.Controls.Add(this.stuZY);
            this.groupBox2.Controls.Add(this.stuCS);
            this.groupBox2.Controls.Add(this.stuXM);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lable2);
            this.groupBox2.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(113, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 458);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学生信息";
            // 
            // stuBZ
            // 
            this.stuBZ.Location = new System.Drawing.Point(108, 242);
            this.stuBZ.Multiline = true;
            this.stuBZ.Name = "stuBZ";
            this.stuBZ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stuBZ.Size = new System.Drawing.Size(370, 130);
            this.stuBZ.TabIndex = 23;
            // 
            // stuXH
            // 
            this.stuXH.Location = new System.Drawing.Point(108, 57);
            this.stuXH.Name = "stuXH";
            this.stuXH.Size = new System.Drawing.Size(120, 26);
            this.stuXH.TabIndex = 22;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(193, 170);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(42, 20);
            this.female.TabIndex = 20;
            this.female.Text = "女";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.Location = new System.Drawing.Point(110, 170);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(42, 20);
            this.male.TabIndex = 19;
            this.male.TabStop = true;
            this.male.Text = "男";
            this.male.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "注意： 加*为必填字段";
            // 
            // stuZXF
            // 
            this.stuZXF.Location = new System.Drawing.Point(358, 168);
            this.stuZXF.Name = "stuZXF";
            this.stuZXF.Size = new System.Drawing.Size(120, 26);
            this.stuZXF.TabIndex = 13;
            // 
            // stuZY
            // 
            this.stuZY.Location = new System.Drawing.Point(358, 113);
            this.stuZY.Name = "stuZY";
            this.stuZY.Size = new System.Drawing.Size(120, 26);
            this.stuZY.TabIndex = 12;
            // 
            // stuCS
            // 
            this.stuCS.Location = new System.Drawing.Point(358, 58);
            this.stuCS.Name = "stuCS";
            this.stuCS.Size = new System.Drawing.Size(120, 26);
            this.stuCS.TabIndex = 11;
            // 
            // stuXM
            // 
            this.stuXM.Location = new System.Drawing.Point(108, 113);
            this.stuXM.Name = "stuXM";
            this.stuXM.Size = new System.Drawing.Size(120, 26);
            this.stuXM.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "总学分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "性别*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "专业";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "备注";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "出生日期*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名*";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(47, 61);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(48, 16);
            this.lable2.TabIndex = 1;
            this.lable2.Text = "学号*";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "查看成绩";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(775, 518);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cjDGV);
            this.groupBox3.Location = new System.Drawing.Point(39, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(696, 411);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "个人成绩";
            // 
            // cjDGV
            // 
            this.cjDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cjDGV.Location = new System.Drawing.Point(158, 36);
            this.cjDGV.Margin = new System.Windows.Forms.Padding(4);
            this.cjDGV.Name = "cjDGV";
            this.cjDGV.RowTemplate.Height = 23;
            this.cjDGV.Size = new System.Drawing.Size(360, 358);
            this.cjDGV.TabIndex = 11;
            this.cjDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cjDGV_CellContentClick);
            // 
            // outbtn
            // 
            this.outbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.outbtn.Location = new System.Drawing.Point(732, 12);
            this.outbtn.Name = "outbtn";
            this.outbtn.Size = new System.Drawing.Size(40, 23);
            this.outbtn.TabIndex = 12;
            this.outbtn.Text = "退出";
            this.outbtn.UseVisualStyleBackColor = true;
            this.outbtn.Click += new System.EventHandler(this.outbtn_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.outbtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormStudent";
            this.Text = "学生成绩查询";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cjDGV)).EndInit();
            this.ResumeLayout(false);

        }
       
        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button outbtn;
        private System.Windows.Forms.TextBox stuBZ;
        private System.Windows.Forms.TextBox stuXH;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stuZXF;
        private System.Windows.Forms.TextBox stuZY;
        private System.Windows.Forms.TextBox stuCS;
        private System.Windows.Forms.TextBox stuXM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView cjDGV;
    }
}