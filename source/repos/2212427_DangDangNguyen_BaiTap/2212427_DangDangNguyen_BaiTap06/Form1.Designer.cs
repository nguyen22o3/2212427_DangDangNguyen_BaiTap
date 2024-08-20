namespace _2212427_DangDangNguyen_BaiTap06
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
            this.cboNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblChon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboNgoaiNgu
            // 
            this.cboNgoaiNgu.FormattingEnabled = true;
            this.cboNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật"});
            this.cboNgoaiNgu.Location = new System.Drawing.Point(162, 37);
            this.cboNgoaiNgu.Name = "cboNgoaiNgu";
            this.cboNgoaiNgu.Size = new System.Drawing.Size(121, 24);
            this.cboNgoaiNgu.TabIndex = 0;
            this.cboNgoaiNgu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblChon
            // 
            this.lblChon.AutoSize = true;
            this.lblChon.Location = new System.Drawing.Point(36, 45);
            this.lblChon.Name = "lblChon";
            this.lblChon.Size = new System.Drawing.Size(100, 16);
            this.lblChon.TabIndex = 1;
            this.lblChon.Text = "Chọn ngoại ngữ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 103);
            this.Controls.Add(this.lblChon);
            this.Controls.Add(this.cboNgoaiNgu);
            this.Name = "Form1";
            this.Text = "Demo ComBoBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNgoaiNgu;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblChon;
    }
}

