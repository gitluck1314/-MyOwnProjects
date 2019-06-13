namespace ScoreManagement
{
    partial class SearchForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stuXM = new System.Windows.Forms.TextBox();
            this.stuXH = new System.Windows.Forms.TextBox();
            this.stuZY = new System.Windows.Forms.ComboBox();
            this.StuDGV = new System.Windows.Forms.DataGridView();
            this.search_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(300, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生信息查询";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stuXM);
            this.groupBox1.Controls.Add(this.stuXH);
            this.groupBox1.Controls.Add(this.stuZY);
            this.groupBox1.Controls.Add(this.StuDGV);
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(758, 407);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入查询信息";
            // 
            // stuXM
            // 
            this.stuXM.Location = new System.Drawing.Point(288, 46);
            this.stuXM.Margin = new System.Windows.Forms.Padding(4);
            this.stuXM.Name = "stuXM";
            this.stuXM.Size = new System.Drawing.Size(120, 26);
            this.stuXM.TabIndex = 13;
            // 
            // stuXH
            // 
            this.stuXH.Location = new System.Drawing.Point(89, 47);
            this.stuXH.Margin = new System.Windows.Forms.Padding(4);
            this.stuXH.Name = "stuXH";
            this.stuXH.Size = new System.Drawing.Size(120, 26);
            this.stuXH.TabIndex = 12;
            // 
            // stuZY
            // 
            this.stuZY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuZY.FormattingEnabled = true;
            this.stuZY.Items.AddRange(new object[] {
            "所有专业",
            "软件工程",
            "通信"});
            this.stuZY.Location = new System.Drawing.Point(486, 48);
            this.stuZY.Margin = new System.Windows.Forms.Padding(4);
            this.stuZY.Name = "stuZY";
            this.stuZY.Size = new System.Drawing.Size(120, 24);
            this.stuZY.TabIndex = 11;
            // 
            // StuDGV
            // 
            this.StuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuDGV.Location = new System.Drawing.Point(32, 104);
            this.StuDGV.Margin = new System.Windows.Forms.Padding(4);
            this.StuDGV.Name = "StuDGV";
            this.StuDGV.RowTemplate.Height = 23;
            this.StuDGV.Size = new System.Drawing.Size(698, 278);
            this.StuDGV.TabIndex = 10;
            this.StuDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StuDGV_CellContentClick);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(640, 48);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(80, 23);
            this.search_btn.TabIndex = 9;
            this.search_btn.Text = "查询";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "专业：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "学号：";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchForm";
            this.Text = "学生成绩管理系统";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox stuXM;
        private System.Windows.Forms.TextBox stuXH;
        private System.Windows.Forms.ComboBox stuZY;
        private System.Windows.Forms.DataGridView StuDGV;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}