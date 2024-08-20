namespace _2212427_DangDangNguyen_BaiTap08
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
            this.lbDanhSach = new System.Windows.Forms.ListBox();
            this.lblDanhSachChon = new System.Windows.Forms.CheckedListBox();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.FormattingEnabled = true;
            this.lbDanhSach.ItemHeight = 16;
            this.lbDanhSach.Items.AddRange(new object[] {
            "Pham Vu Ngoc Ha",
            "Hoang Van Hung",
            "Le Thi Van",
            "Nguyen Thi Thu",
            "Le Van Quoc ",
            "Le Van Phuoc",
            "Truong Van Dung"});
            this.lbDanhSach.Location = new System.Drawing.Point(80, 103);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhSach.Size = new System.Drawing.Size(145, 260);
            this.lbDanhSach.TabIndex = 0;
            // 
            // lblDanhSachChon
            // 
            this.lblDanhSachChon.FormattingEnabled = true;
            this.lblDanhSachChon.Location = new System.Drawing.Point(528, 104);
            this.lblDanhSachChon.MultiColumn = true;
            this.lblDanhSachChon.Name = "lblDanhSachChon";
            this.lblDanhSachChon.Size = new System.Drawing.Size(242, 259);
            this.lblDanhSachChon.TabIndex = 1;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(339, 153);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 2;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntRemove
            // 
            this.bntRemove.Location = new System.Drawing.Point(339, 277);
            this.bntRemove.Name = "bntRemove";
            this.bntRemove.Size = new System.Drawing.Size(75, 23);
            this.bntRemove.TabIndex = 3;
            this.bntRemove.Text = "Remove";
            this.bntRemove.UseVisualStyleBackColor = true;
            this.bntRemove.Click += new System.EventHandler(this.bntRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(77, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách sinh viên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(525, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách sinh viên tham gia bóng đá";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntRemove);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.lblDanhSachChon);
            this.Controls.Add(this.lbDanhSach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDanhSach;
        private System.Windows.Forms.CheckedListBox lblDanhSachChon;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

