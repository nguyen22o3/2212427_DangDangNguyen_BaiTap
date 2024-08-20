namespace _2212427_DangDangNguyen_BaiTap10
{
    partial class ckbMauNen
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
            this.bntButton = new System.Windows.Forms.Button();
            this.bntButtonFlat = new System.Windows.Forms.Button();
            this.ckbMauChu = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.rbFlat = new System.Windows.Forms.RadioButton();
            this.rbPopup = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // bntButton
            // 
            this.bntButton.ForeColor = System.Drawing.Color.Red;
            this.bntButton.Location = new System.Drawing.Point(89, 93);
            this.bntButton.Name = "bntButton";
            this.bntButton.Size = new System.Drawing.Size(116, 23);
            this.bntButton.TabIndex = 0;
            this.bntButton.Text = "Button";
            this.bntButton.UseVisualStyleBackColor = true;
            this.bntButton.Click += new System.EventHandler(this.bntButton_Click);
            // 
            // bntButtonFlat
            // 
            this.bntButtonFlat.Location = new System.Drawing.Point(89, 234);
            this.bntButtonFlat.Name = "bntButtonFlat";
            this.bntButtonFlat.Size = new System.Drawing.Size(116, 23);
            this.bntButtonFlat.TabIndex = 1;
            this.bntButtonFlat.Text = "Button Flat";
            this.bntButtonFlat.UseVisualStyleBackColor = true;
            // 
            // ckbMauChu
            // 
            this.ckbMauChu.AutoSize = true;
            this.ckbMauChu.Location = new System.Drawing.Point(332, 40);
            this.ckbMauChu.Name = "ckbMauChu";
            this.ckbMauChu.Size = new System.Drawing.Size(135, 20);
            this.ckbMauChu.TabIndex = 2;
            this.ckbMauChu.Text = "Thay đổi màu chữ";
            this.ckbMauChu.UseVisualStyleBackColor = true;
            this.ckbMauChu.CheckedChanged += new System.EventHandler(this.ckbMauChu_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(330, 96);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(136, 20);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Thay đổi màu nền";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // rbFlat
            // 
            this.rbFlat.AutoSize = true;
            this.rbFlat.Location = new System.Drawing.Point(332, 183);
            this.rbFlat.Name = "rbFlat";
            this.rbFlat.Size = new System.Drawing.Size(79, 20);
            this.rbFlat.TabIndex = 4;
            this.rbFlat.TabStop = true;
            this.rbFlat.Text = "Kiểu Flat";
            this.rbFlat.UseVisualStyleBackColor = true;
            this.rbFlat.CheckedChanged += new System.EventHandler(this.rbFlat_CheckedChanged);
            // 
            // rbPopup
            // 
            this.rbPopup.AutoSize = true;
            this.rbPopup.Location = new System.Drawing.Point(332, 237);
            this.rbPopup.Name = "rbPopup";
            this.rbPopup.Size = new System.Drawing.Size(97, 20);
            this.rbPopup.TabIndex = 5;
            this.rbPopup.TabStop = true;
            this.rbPopup.Text = "Kiểu Popup";
            this.rbPopup.UseVisualStyleBackColor = true;
            this.rbPopup.CheckedChanged += new System.EventHandler(this.rbPopup_CheckedChanged);
            // 
            // ckbMauNen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbPopup);
            this.Controls.Add(this.rbFlat);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.ckbMauChu);
            this.Controls.Add(this.bntButtonFlat);
            this.Controls.Add(this.bntButton);
            this.Name = "ckbMauNen";
            this.Text = "Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntButton;
        private System.Windows.Forms.Button bntButtonFlat;
        private System.Windows.Forms.CheckBox ckbMauChu;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton rbFlat;
        private System.Windows.Forms.RadioButton rbPopup;
    }
}

