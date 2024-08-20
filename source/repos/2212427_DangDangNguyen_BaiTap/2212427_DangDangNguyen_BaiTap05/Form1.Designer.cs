namespace _2212427_DangDangNguyen_BaiTap05
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.bntOK = new System.Windows.Forms.Button();
            this.bntClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 31);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(36, 16);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 90);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 182);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(129, 25);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(161, 22);
            this.txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(129, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(161, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(15, 201);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(436, 208);
            this.txtDescription.TabIndex = 5;
            // 
            // bntOK
            // 
            this.bntOK.Location = new System.Drawing.Point(47, 415);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(96, 23);
            this.bntOK.TabIndex = 6;
            this.bntOK.Text = "OK";
            this.bntOK.UseVisualStyleBackColor = true;
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(316, 415);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(96, 23);
            this.bntClose.TabIndex = 7;
            this.bntClose.Text = "Close";
            this.bntClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.bntOK);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Button bntClose;
    }
}

