namespace _2212427_DangDangNguyen_Bai08
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
            this.rbNữ = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbNữ
            // 
            this.rbNữ.AutoSize = true;
            this.rbNữ.Location = new System.Drawing.Point(6, 60);
            this.rbNữ.Name = "rbNữ";
            this.rbNữ.Size = new System.Drawing.Size(45, 20);
            this.rbNữ.TabIndex = 0;
            this.rbNữ.TabStop = true;
            this.rbNữ.Text = "Nữ";
            this.rbNữ.UseVisualStyleBackColor = true;
            this.rbNữ.CheckedChanged += new System.EventHandler(this.rbNu_CheckedChanged);
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(6, 34);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(57, 20);
            this.rbNam.TabIndex = 1;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.rbNữ);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 135);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Demo RadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbNữ;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

