namespace ScoreManagement
{
    partial class ScoreForm
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
            this.stuDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.update1 = new System.Windows.Forms.Button();
            this.delete1 = new System.Windows.Forms.Button();
            this.stuZY = new System.Windows.Forms.ComboBox();
            this.stuXH = new System.Windows.Forms.ComboBox();
            this.stuKCM = new System.Windows.Forms.ComboBox();
            this.stuXM = new System.Windows.Forms.TextBox();
            this.stuCJ = new System.Windows.Forms.TextBox();
            this.stuXF = new System.Windows.Forms.TextBox();
            this.cancle1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stuDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(319, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "学生成绩录入";
            // 
            // stuDGV
            // 
            this.stuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuDGV.Location = new System.Drawing.Point(25, 277);
            this.stuDGV.Name = "stuDGV";
            this.stuDGV.RowTemplate.Height = 23;
            this.stuDGV.Size = new System.Drawing.Size(735, 247);
            this.stuDGV.TabIndex = 3;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "学号";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "成绩";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "学分";
            // 
            // update1
            // 
            this.update1.Location = new System.Drawing.Point(135, 147);
            this.update1.Name = "update1";
            this.update1.Size = new System.Drawing.Size(75, 23);
            this.update1.TabIndex = 6;
            this.update1.Text = "更新";
            this.update1.UseVisualStyleBackColor = true;
            // 
            // delete1
            // 
            this.delete1.Location = new System.Drawing.Point(349, 147);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(75, 23);
            this.delete1.TabIndex = 7;
            this.delete1.Text = "删除";
            this.delete1.UseVisualStyleBackColor = true;
            // 
            // stuZY
            // 
            this.stuZY.FormattingEnabled = true;
            this.stuZY.Location = new System.Drawing.Point(90, 42);
            this.stuZY.Name = "stuZY";
            this.stuZY.Size = new System.Drawing.Size(120, 24);
            this.stuZY.TabIndex = 8;
            // 
            // stuXH
            // 
            this.stuXH.FormattingEnabled = true;
            this.stuXH.Location = new System.Drawing.Point(334, 43);
            this.stuXH.Name = "stuXH";
            this.stuXH.Size = new System.Drawing.Size(120, 24);
            this.stuXH.TabIndex = 9;
            // 
            // stuKCM
            // 
            this.stuKCM.FormattingEnabled = true;
            this.stuKCM.Location = new System.Drawing.Point(575, 43);
            this.stuKCM.Name = "stuKCM";
            this.stuKCM.Size = new System.Drawing.Size(120, 24);
            this.stuKCM.TabIndex = 10;
            // 
            // stuXM
            // 
            this.stuXM.Location = new System.Drawing.Point(90, 95);
            this.stuXM.Name = "stuXM";
            this.stuXM.Size = new System.Drawing.Size(120, 26);
            this.stuXM.TabIndex = 11;
            // 
            // stuCJ
            // 
            this.stuCJ.Location = new System.Drawing.Point(334, 95);
            this.stuCJ.Name = "stuCJ";
            this.stuCJ.Size = new System.Drawing.Size(120, 26);
            this.stuCJ.TabIndex = 12;
            // 
            // stuXF
            // 
            this.stuXF.Location = new System.Drawing.Point(575, 94);
            this.stuXF.Name = "stuXF";
            this.stuXF.Size = new System.Drawing.Size(120, 26);
            this.stuXF.TabIndex = 13;
            // 
            // cancle1
            // 
            this.cancle1.Location = new System.Drawing.Point(551, 147);
            this.cancle1.Name = "cancle1";
            this.cancle1.Size = new System.Drawing.Size(75, 23);
            this.cancle1.TabIndex = 14;
            this.cancle1.Text = "取消";
            this.cancle1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancle1);
            this.groupBox1.Controls.Add(this.stuXF);
            this.groupBox1.Controls.Add(this.stuCJ);
            this.groupBox1.Controls.Add(this.stuXM);
            this.groupBox1.Controls.Add(this.stuKCM);
            this.groupBox1.Controls.Add(this.stuXH);
            this.groupBox1.Controls.Add(this.stuZY);
            this.groupBox1.Controls.Add(this.delete1);
            this.groupBox1.Controls.Add(this.update1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(25, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生成绩录入";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1166, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.stuDGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ScoreForm";
            this.Text = "ScoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.stuDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stuDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button update1;
        private System.Windows.Forms.Button delete1;
        private System.Windows.Forms.ComboBox stuZY;
        private System.Windows.Forms.ComboBox stuXH;
        private System.Windows.Forms.ComboBox stuKCM;
        private System.Windows.Forms.TextBox stuXM;
        private System.Windows.Forms.TextBox stuCJ;
        private System.Windows.Forms.TextBox stuXF;
        private System.Windows.Forms.Button cancle1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}