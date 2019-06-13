namespace ScoreManagement
{
    partial class FormTeacher
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
            this.StuCJ_DGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancle = new System.Windows.Forms.Button();
            this.stuXF = new System.Windows.Forms.TextBox();
            this.stuCJ = new System.Windows.Forms.TextBox();
            this.stuXM = new System.Windows.Forms.TextBox();
            this.stuKCM = new System.Windows.Forms.ComboBox();
            this.stuXH = new System.Windows.Forms.ComboBox();
            this.stuZY = new System.Windows.Forms.ComboBox();
            this.del = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kch = new System.Windows.Forms.ComboBox();
            this.ks = new System.Windows.Forms.TextBox();
            this.kcxf = new System.Windows.Forms.TextBox();
            this.kcm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.kxm = new System.Windows.Forms.Label();
            this.kbCancle = new System.Windows.Forms.Button();
            this.xq = new System.Windows.Forms.TextBox();
            this.kbDel = new System.Windows.Forms.Button();
            this.kbUpd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.outBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuCJ_DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(12, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 525);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.StuCJ_DGV);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "学生成绩录入及修改";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // StuCJ_DGV
            // 
            this.StuCJ_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuCJ_DGV.Location = new System.Drawing.Point(16, 224);
            this.StuCJ_DGV.Name = "StuCJ_DGV";
            this.StuCJ_DGV.RowTemplate.Height = 23;
            this.StuCJ_DGV.Size = new System.Drawing.Size(735, 247);
            this.StuCJ_DGV.TabIndex = 5;
            this.StuCJ_DGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StuCJ_DGV_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancle);
            this.groupBox1.Controls.Add(this.stuXF);
            this.groupBox1.Controls.Add(this.stuCJ);
            this.groupBox1.Controls.Add(this.stuXM);
            this.groupBox1.Controls.Add(this.stuKCM);
            this.groupBox1.Controls.Add(this.stuXH);
            this.groupBox1.Controls.Add(this.stuZY);
            this.groupBox1.Controls.Add(this.del);
            this.groupBox1.Controls.Add(this.upd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(16, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 195);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成绩录入或修改";
            // 
            // cancle
            // 
            this.cancle.Location = new System.Drawing.Point(551, 147);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(75, 23);
            this.cancle.TabIndex = 14;
            this.cancle.Text = "取消";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // stuXF
            // 
            this.stuXF.Location = new System.Drawing.Point(575, 94);
            this.stuXF.Name = "stuXF";
            this.stuXF.Size = new System.Drawing.Size(120, 26);
            this.stuXF.TabIndex = 13;
            // 
            // stuCJ
            // 
            this.stuCJ.Location = new System.Drawing.Point(334, 95);
            this.stuCJ.Name = "stuCJ";
            this.stuCJ.Size = new System.Drawing.Size(120, 26);
            this.stuCJ.TabIndex = 12;
            // 
            // stuXM
            // 
            this.stuXM.Location = new System.Drawing.Point(90, 95);
            this.stuXM.Name = "stuXM";
            this.stuXM.Size = new System.Drawing.Size(120, 26);
            this.stuXM.TabIndex = 11;
            // 
            // stuKCM
            // 
            this.stuKCM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuKCM.FormattingEnabled = true;
            this.stuKCM.Location = new System.Drawing.Point(575, 43);
            this.stuKCM.Name = "stuKCM";
            this.stuKCM.Size = new System.Drawing.Size(120, 24);
            this.stuKCM.TabIndex = 10;
            this.stuKCM.SelectedIndexChanged += new System.EventHandler(this.stuKCM_SelectedIndexChanged);
            // 
            // stuXH
            // 
            this.stuXH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuXH.FormattingEnabled = true;
            this.stuXH.Location = new System.Drawing.Point(334, 43);
            this.stuXH.Name = "stuXH";
            this.stuXH.Size = new System.Drawing.Size(120, 24);
            this.stuXH.TabIndex = 9;
            this.stuXH.SelectedIndexChanged += new System.EventHandler(this.stuXH_SelectedIndexChanged);
            // 
            // stuZY
            // 
            this.stuZY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuZY.FormattingEnabled = true;
            this.stuZY.Location = new System.Drawing.Point(90, 42);
            this.stuZY.Name = "stuZY";
            this.stuZY.Size = new System.Drawing.Size(120, 24);
            this.stuZY.TabIndex = 8;
            this.stuZY.SelectedIndexChanged += new System.EventHandler(this.stuZY_SelectedIndexChanged);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(349, 147);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 7;
            this.del.Text = "删除";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // upd
            // 
            this.upd.Location = new System.Drawing.Point(135, 147);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(75, 23);
            this.upd.TabIndex = 6;
            this.upd.Text = "更新";
            this.upd.UseVisualStyleBackColor = true;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "学分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "课程名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "成绩";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "专业";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "新课程的开启";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kch);
            this.groupBox2.Controls.Add(this.ks);
            this.groupBox2.Controls.Add(this.kcxf);
            this.groupBox2.Controls.Add(this.kcm);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.kxm);
            this.groupBox2.Controls.Add(this.kbCancle);
            this.groupBox2.Controls.Add(this.xq);
            this.groupBox2.Controls.Add(this.kbDel);
            this.groupBox2.Controls.Add(this.kbUpd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(116, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 414);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新课程";
            // 
            // kch
            // 
            this.kch.FormattingEnabled = true;
            this.kch.Location = new System.Drawing.Point(343, 163);
            this.kch.Name = "kch";
            this.kch.Size = new System.Drawing.Size(121, 24);
            this.kch.TabIndex = 30;
            this.kch.SelectedIndexChanged += new System.EventHandler(this.kch_SelectedIndexChanged);
            // 
            // ks
            // 
            this.ks.Location = new System.Drawing.Point(113, 241);
            this.ks.Name = "ks";
            this.ks.Size = new System.Drawing.Size(120, 26);
            this.ks.TabIndex = 29;
            // 
            // kcxf
            // 
            this.kcxf.Location = new System.Drawing.Point(343, 81);
            this.kcxf.Name = "kcxf";
            this.kcxf.Size = new System.Drawing.Size(120, 26);
            this.kcxf.TabIndex = 28;
            // 
            // kcm
            // 
            this.kcm.Location = new System.Drawing.Point(113, 81);
            this.kcm.Name = "kcm";
            this.kcm.Size = new System.Drawing.Size(120, 26);
            this.kcm.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "课时";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(281, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "学  分";
            // 
            // kxm
            // 
            this.kxm.AutoSize = true;
            this.kxm.Location = new System.Drawing.Point(35, 85);
            this.kxm.Name = "kxm";
            this.kxm.Size = new System.Drawing.Size(72, 16);
            this.kxm.TabIndex = 24;
            this.kxm.Text = "课程名称";
            // 
            // kbCancle
            // 
            this.kbCancle.Location = new System.Drawing.Point(343, 241);
            this.kbCancle.Name = "kbCancle";
            this.kbCancle.Size = new System.Drawing.Size(113, 27);
            this.kbCancle.TabIndex = 23;
            this.kbCancle.Text = "取消";
            this.kbCancle.UseVisualStyleBackColor = true;
            this.kbCancle.Click += new System.EventHandler(this.kbCancle_Click);
            // 
            // xq
            // 
            this.xq.Location = new System.Drawing.Point(113, 161);
            this.xq.Name = "xq";
            this.xq.Size = new System.Drawing.Size(120, 26);
            this.xq.TabIndex = 20;
            // 
            // kbDel
            // 
            this.kbDel.Location = new System.Drawing.Point(343, 320);
            this.kbDel.Name = "kbDel";
            this.kbDel.Size = new System.Drawing.Size(113, 27);
            this.kbDel.TabIndex = 19;
            this.kbDel.Text = "删除";
            this.kbDel.UseVisualStyleBackColor = true;
            this.kbDel.Click += new System.EventHandler(this.kbDel_Click);
            // 
            // kbUpd
            // 
            this.kbUpd.Location = new System.Drawing.Point(113, 320);
            this.kbUpd.Name = "kbUpd";
            this.kbUpd.Size = new System.Drawing.Size(113, 27);
            this.kbUpd.TabIndex = 18;
            this.kbUpd.Text = "更新";
            this.kbUpd.UseVisualStyleBackColor = true;
            this.kbUpd.Click += new System.EventHandler(this.kbUpd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "课程号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "开课时间";
            // 
            // outBtn
            // 
            this.outBtn.Location = new System.Drawing.Point(709, 12);
            this.outBtn.Name = "outBtn";
            this.outBtn.Size = new System.Drawing.Size(75, 23);
            this.outBtn.TabIndex = 0;
            this.outBtn.Text = "退出";
            this.outBtn.UseVisualStyleBackColor = true;
            this.outBtn.Click += new System.EventHandler(this.outBtn_Click);
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.outBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormTeacher";
            this.Text = "学生成绩管理系统";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StuCJ_DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView StuCJ_DGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.TextBox stuXF;
        private System.Windows.Forms.TextBox stuCJ;
        private System.Windows.Forms.TextBox stuXM;
        private System.Windows.Forms.ComboBox stuKCM;
        private System.Windows.Forms.ComboBox stuXH;
        private System.Windows.Forms.ComboBox stuZY;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button outBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ks;
        private System.Windows.Forms.TextBox kcxf;
        private System.Windows.Forms.TextBox kcm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label kxm;
        private System.Windows.Forms.Button kbCancle;
        private System.Windows.Forms.TextBox xq;
        private System.Windows.Forms.Button kbDel;
        private System.Windows.Forms.Button kbUpd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox kch;
    }
}