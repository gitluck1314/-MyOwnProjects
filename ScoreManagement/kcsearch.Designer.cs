namespace ScoreManagement
{
    partial class KCSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KCDGV = new System.Windows.Forms.DataGridView();
            this.kch = new System.Windows.Forms.ComboBox();
            this.kcm = new System.Windows.Forms.TextBox();
            this.kxm = new System.Windows.Forms.Label();
            this.kbSeach = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KCDGV);
            this.groupBox1.Controls.Add(this.kch);
            this.groupBox1.Controls.Add(this.kcm);
            this.groupBox1.Controls.Add(this.kxm);
            this.groupBox1.Controls.Add(this.kbSeach);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(27, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(725, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "课程信息";
            // 
            // KCDGV
            // 
            this.KCDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KCDGV.Location = new System.Drawing.Point(89, 132);
            this.KCDGV.Name = "KCDGV";
            this.KCDGV.RowTemplate.Height = 23;
            this.KCDGV.Size = new System.Drawing.Size(545, 252);
            this.KCDGV.TabIndex = 44;
            // 
            // kch
            // 
            this.kch.FormattingEnabled = true;
            this.kch.Location = new System.Drawing.Point(378, 61);
            this.kch.Margin = new System.Windows.Forms.Padding(4);
            this.kch.Name = "kch";
            this.kch.Size = new System.Drawing.Size(130, 24);
            this.kch.TabIndex = 43;
            // 
            // kcm
            // 
            this.kcm.Location = new System.Drawing.Point(160, 61);
            this.kcm.Margin = new System.Windows.Forms.Padding(4);
            this.kcm.Name = "kcm";
            this.kcm.Size = new System.Drawing.Size(130, 26);
            this.kcm.TabIndex = 40;
            // 
            // kxm
            // 
            this.kxm.AutoSize = true;
            this.kxm.Location = new System.Drawing.Point(80, 64);
            this.kxm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kxm.Name = "kxm";
            this.kxm.Size = new System.Drawing.Size(72, 16);
            this.kxm.TabIndex = 37;
            this.kxm.Text = "课程名称";
            // 
            // kbSeach
            // 
            this.kbSeach.Location = new System.Drawing.Point(534, 61);
            this.kbSeach.Margin = new System.Windows.Forms.Padding(4);
            this.kbSeach.Name = "kbSeach";
            this.kbSeach.Size = new System.Drawing.Size(100, 26);
            this.kbSeach.TabIndex = 36;
            this.kbSeach.Text = "查询";
            this.kbSeach.UseVisualStyleBackColor = true;
            this.kbSeach.Click += new System.EventHandler(this.kbSeach_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "课程号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(322, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "课程查询";
            // 
            // KCSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KCSearch";
            this.Text = "课程查询";
            this.Load += new System.EventHandler(this.KCSearch_Loade);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KCDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox kch;
        private System.Windows.Forms.TextBox kcm;
        private System.Windows.Forms.Label kxm;
        private System.Windows.Forms.Button kbSeach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView KCDGV;
        private System.Windows.Forms.Label label1;
    }
}