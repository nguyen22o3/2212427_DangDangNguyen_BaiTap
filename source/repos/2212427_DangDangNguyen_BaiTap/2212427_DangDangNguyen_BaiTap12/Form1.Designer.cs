namespace _2212427_DangDangNguyen_Bai12
{
    partial class Form1
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
            this.frmTab = new System.Windows.Forms.TabControl();
            this.tabPageSV = new System.Windows.Forms.TabPage();
            this.tabPageGV = new System.Windows.Forms.TabPage();
            this.tabPageMH = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.frmTab.SuspendLayout();
            this.tabPageSV.SuspendLayout();
            this.tabPageGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmTab
            // 
            this.frmTab.Controls.Add(this.tabPageSV);
            this.frmTab.Controls.Add(this.tabPageGV);
            this.frmTab.Controls.Add(this.tabPageMH);
            this.frmTab.Location = new System.Drawing.Point(124, 43);
            this.frmTab.Name = "frmTab";
            this.frmTab.SelectedIndex = 0;
            this.frmTab.Size = new System.Drawing.Size(336, 231);
            this.frmTab.TabIndex = 0;
            // 
            // tabPageSV
            // 
            this.tabPageSV.Controls.Add(this.textBox4);
            this.tabPageSV.Controls.Add(this.textBox1);
            this.tabPageSV.Controls.Add(this.label2);
            this.tabPageSV.Controls.Add(this.label1);
            this.tabPageSV.Location = new System.Drawing.Point(4, 25);
            this.tabPageSV.Name = "tabPageSV";
            this.tabPageSV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSV.Size = new System.Drawing.Size(328, 202);
            this.tabPageSV.TabIndex = 0;
            this.tabPageSV.Text = "Sinh viên";
            this.tabPageSV.UseVisualStyleBackColor = true;
            this.tabPageSV.Click += new System.EventHandler(this.tabPageSV_Click);
            // 
            // tabPageGV
            // 
            this.tabPageGV.Controls.Add(this.textBox2);
            this.tabPageGV.Controls.Add(this.label3);
            this.tabPageGV.Location = new System.Drawing.Point(4, 25);
            this.tabPageGV.Name = "tabPageGV";
            this.tabPageGV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGV.Size = new System.Drawing.Size(328, 202);
            this.tabPageGV.TabIndex = 1;
            this.tabPageGV.Text = "Giáo viên";
            this.tabPageGV.UseVisualStyleBackColor = true;
            this.tabPageGV.Click += new System.EventHandler(this.tabPageGV_Click);
            // 
            // tabPageMH
            // 
            this.tabPageMH.Location = new System.Drawing.Point(4, 25);
            this.tabPageMH.Name = "tabPageMH";
            this.tabPageMH.Size = new System.Drawing.Size(328, 202);
            this.tabPageMH.TabIndex = 2;
            this.tabPageMH.Text = "Môn học";
            this.tabPageMH.UseVisualStyleBackColor = true;
            this.tabPageMH.Click += new System.EventHandler(this.tabPageMH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(132, 129);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên giáo viên";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 22);
            this.textBox2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmTab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.frmTab.ResumeLayout(false);
            this.tabPageSV.ResumeLayout(false);
            this.tabPageSV.PerformLayout();
            this.tabPageGV.ResumeLayout(false);
            this.tabPageGV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl frmTab;
        private System.Windows.Forms.TabPage tabPageSV;
        private System.Windows.Forms.TabPage tabPageGV;
        private System.Windows.Forms.TabPage tabPageMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}

