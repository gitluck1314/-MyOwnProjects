namespace ScoreManagement
{
    partial class FormMain
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
            this.studentGroupBox = new System.Windows.Forms.GroupBox();
            this.StuDGV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stuCancle = new System.Windows.Forms.Button();
            this.stuBZ = new System.Windows.Forms.TextBox();
            this.stuXH = new System.Windows.Forms.TextBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.stuDelete = new System.Windows.Forms.Button();
            this.stuUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.teacherGroupBox = new System.Windows.Forms.GroupBox();
            this.Tfemale = new System.Windows.Forms.RadioButton();
            this.Tmale = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.roles = new System.Windows.Forms.TextBox();
            this.tnum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.TeacherDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.studentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuDGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.teacherGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 557);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.studentGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "学生管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // studentGroupBox
            // 
            this.studentGroupBox.Controls.Add(this.StuDGV);
            this.studentGroupBox.Controls.Add(this.groupBox2);
            this.studentGroupBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.studentGroupBox.Location = new System.Drawing.Point(-4, 0);
            this.studentGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.studentGroupBox.Name = "studentGroupBox";
            this.studentGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.studentGroupBox.Size = new System.Drawing.Size(784, 535);
            this.studentGroupBox.TabIndex = 7;
            this.studentGroupBox.TabStop = false;
            // 
            // StuDGV
            // 
            this.StuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuDGV.Location = new System.Drawing.Point(25, 268);
            this.StuDGV.Name = "StuDGV";
            this.StuDGV.RowTemplate.Height = 23;
            this.StuDGV.Size = new System.Drawing.Size(734, 233);
            this.StuDGV.TabIndex = 21;
            this.StuDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StuDGV_RowHeaderMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stuCancle);
            this.groupBox2.Controls.Add(this.stuBZ);
            this.groupBox2.Controls.Add(this.stuXH);
            this.groupBox2.Controls.Add(this.female);
            this.groupBox2.Controls.Add(this.male);
            this.groupBox2.Controls.Add(this.stuDelete);
            this.groupBox2.Controls.Add(this.stuUpdate);
            this.groupBox2.Controls.Add(this.label1);
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
            this.groupBox2.Location = new System.Drawing.Point(25, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 237);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学生信息";
            // 
            // stuCancle
            // 
            this.stuCancle.Location = new System.Drawing.Point(640, 190);
            this.stuCancle.Name = "stuCancle";
            this.stuCancle.Size = new System.Drawing.Size(75, 23);
            this.stuCancle.TabIndex = 24;
            this.stuCancle.Text = "取消";
            this.stuCancle.UseVisualStyleBackColor = true;
            this.stuCancle.Click += new System.EventHandler(this.stuCancle_Click);
            // 
            // stuBZ
            // 
            this.stuBZ.Location = new System.Drawing.Point(589, 34);
            this.stuBZ.Multiline = true;
            this.stuBZ.Name = "stuBZ";
            this.stuBZ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stuBZ.Size = new System.Drawing.Size(126, 130);
            this.stuBZ.TabIndex = 23;
            // 
            // stuXH
            // 
            this.stuXH.Location = new System.Drawing.Point(77, 35);
            this.stuXH.Name = "stuXH";
            this.stuXH.Size = new System.Drawing.Size(120, 26);
            this.stuXH.TabIndex = 22;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(162, 142);
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
            this.male.Location = new System.Drawing.Point(79, 142);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(42, 20);
            this.male.TabIndex = 19;
            this.male.TabStop = true;
            this.male.Text = "男";
            this.male.UseVisualStyleBackColor = true;
            // 
            // stuDelete
            // 
            this.stuDelete.Location = new System.Drawing.Point(559, 190);
            this.stuDelete.Name = "stuDelete";
            this.stuDelete.Size = new System.Drawing.Size(75, 23);
            this.stuDelete.TabIndex = 17;
            this.stuDelete.Text = "删除";
            this.stuDelete.UseVisualStyleBackColor = true;
            this.stuDelete.Click += new System.EventHandler(this.stuDelete_Click);
            // 
            // stuUpdate
            // 
            this.stuUpdate.Location = new System.Drawing.Point(478, 190);
            this.stuUpdate.Name = "stuUpdate";
            this.stuUpdate.Size = new System.Drawing.Size(75, 23);
            this.stuUpdate.TabIndex = 16;
            this.stuUpdate.Text = "更新";
            this.stuUpdate.UseVisualStyleBackColor = true;
            this.stuUpdate.Click += new System.EventHandler(this.stuUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "注意： 加*为必填字段";
            // 
            // stuZXF
            // 
            this.stuZXF.Location = new System.Drawing.Point(356, 143);
            this.stuZXF.Name = "stuZXF";
            this.stuZXF.Size = new System.Drawing.Size(120, 26);
            this.stuZXF.TabIndex = 13;
            // 
            // stuZY
            // 
            this.stuZY.Location = new System.Drawing.Point(356, 89);
            this.stuZY.Name = "stuZY";
            this.stuZY.Size = new System.Drawing.Size(120, 26);
            this.stuZY.TabIndex = 12;
            // 
            // stuCS
            // 
            this.stuCS.Location = new System.Drawing.Point(356, 34);
            this.stuCS.Name = "stuCS";
            this.stuCS.Size = new System.Drawing.Size(120, 26);
            this.stuCS.TabIndex = 11;
            // 
            // stuXM
            // 
            this.stuXM.Location = new System.Drawing.Point(77, 89);
            this.stuXM.Name = "stuXM";
            this.stuXM.Size = new System.Drawing.Size(120, 26);
            this.stuXM.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "总学分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "性别*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "专业";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "备注";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "出生日期*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名*";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(16, 39);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(48, 16);
            this.lable2.TabIndex = 1;
            this.lable2.Text = "学号*";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.teacherGroupBox);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "教师管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // teacherGroupBox
            // 
            this.teacherGroupBox.Controls.Add(this.Tfemale);
            this.teacherGroupBox.Controls.Add(this.Tmale);
            this.teacherGroupBox.Controls.Add(this.label11);
            this.teacherGroupBox.Controls.Add(this.username);
            this.teacherGroupBox.Controls.Add(this.label9);
            this.teacherGroupBox.Controls.Add(this.cancelBtn);
            this.teacherGroupBox.Controls.Add(this.roles);
            this.teacherGroupBox.Controls.Add(this.tnum);
            this.teacherGroupBox.Controls.Add(this.label10);
            this.teacherGroupBox.Controls.Add(this.label2);
            this.teacherGroupBox.Controls.Add(this.del);
            this.teacherGroupBox.Controls.Add(this.upd);
            this.teacherGroupBox.Controls.Add(this.TeacherDGV);
            this.teacherGroupBox.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.teacherGroupBox.Location = new System.Drawing.Point(3, 17);
            this.teacherGroupBox.Name = "teacherGroupBox";
            this.teacherGroupBox.Size = new System.Drawing.Size(770, 439);
            this.teacherGroupBox.TabIndex = 0;
            this.teacherGroupBox.TabStop = false;
            this.teacherGroupBox.Text = "教师信息";
            // 
            // Tfemale
            // 
            this.Tfemale.AutoSize = true;
            this.Tfemale.Location = new System.Drawing.Point(200, 203);
            this.Tfemale.Name = "Tfemale";
            this.Tfemale.Size = new System.Drawing.Size(42, 20);
            this.Tfemale.TabIndex = 23;
            this.Tfemale.Text = "女";
            this.Tfemale.UseVisualStyleBackColor = true;
            // 
            // Tmale
            // 
            this.Tmale.AutoSize = true;
            this.Tmale.Checked = true;
            this.Tmale.Location = new System.Drawing.Point(134, 203);
            this.Tmale.Name = "Tmale";
            this.Tmale.Size = new System.Drawing.Size(42, 20);
            this.Tmale.TabIndex = 22;
            this.Tmale.TabStop = true;
            this.Tmale.Text = "男";
            this.Tmale.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "性    别:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(134, 113);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 26);
            this.username.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "姓    名：";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(134, 362);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 23);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // roles
            // 
            this.roles.Location = new System.Drawing.Point(134, 157);
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(100, 26);
            this.roles.TabIndex = 15;
            // 
            // tnum
            // 
            this.tnum.Location = new System.Drawing.Point(134, 70);
            this.tnum.Name = "tnum";
            this.tnum.Size = new System.Drawing.Size(100, 26);
            this.tnum.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "权    限：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "教师工号：";
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(134, 317);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(100, 23);
            this.del.TabIndex = 11;
            this.del.Text = "删除";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // upd
            // 
            this.upd.Location = new System.Drawing.Point(134, 273);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(100, 23);
            this.upd.TabIndex = 10;
            this.upd.Text = "更新";
            this.upd.UseVisualStyleBackColor = true;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // TeacherDGV
            // 
            this.TeacherDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherDGV.Location = new System.Drawing.Point(285, 70);
            this.TeacherDGV.Name = "TeacherDGV";
            this.TeacherDGV.RowTemplate.Height = 23;
            this.TeacherDGV.Size = new System.Drawing.Size(442, 315);
            this.TeacherDGV.TabIndex = 9;
            this.TeacherDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TeacherDGV_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(4, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // outBtn
            // 
            this.outBtn.Location = new System.Drawing.Point(732, 8);
            this.outBtn.Name = "outBtn";
            this.outBtn.Size = new System.Drawing.Size(40, 23);
            this.outBtn.TabIndex = 8;
            this.outBtn.Text = "退出";
            this.outBtn.UseVisualStyleBackColor = true;
            this.outBtn.Click += new System.EventHandler(this.outBtn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 572);
            this.Controls.Add(this.outBtn);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "学生成绩管理系统";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.studentGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StuDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.teacherGroupBox.ResumeLayout(false);
            this.teacherGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox studentGroupBox;
        private System.Windows.Forms.DataGridView StuDGV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox stuBZ;
        private System.Windows.Forms.TextBox stuXH;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Button stuDelete;
        private System.Windows.Forms.Button stuUpdate;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox teacherGroupBox;
        private System.Windows.Forms.TextBox roles;
        private System.Windows.Forms.TextBox tnum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.DataGridView TeacherDGV;
        private System.Windows.Forms.Button stuCancle;
        private System.Windows.Forms.Button outBtn;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.RadioButton Tfemale;
        private System.Windows.Forms.RadioButton Tmale;
        private System.Windows.Forms.Label label11;
    }

}