namespace QLCONGVAN
{
    partial class frmDangNhap
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
            this.MatKhau = new System.Windows.Forms.TextBox();
            this.DangNhap = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picture1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // MatKhau
            // 
            this.MatKhau.Location = new System.Drawing.Point(308, 149);
            this.MatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.PasswordChar = '*';
            this.MatKhau.Size = new System.Drawing.Size(171, 20);
            this.MatKhau.TabIndex = 36;
            // 
            // DangNhap
            // 
            this.DangNhap.Location = new System.Drawing.Point(284, 105);
            this.DangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(171, 20);
            this.DangNhap.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(208, 21);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 39);
            this.label15.TabIndex = 33;
            this.label15.Text = "ĐĂNG NHẬP";
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnDangnhap.Location = new System.Drawing.Point(314, 193);
            this.btnDangnhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(137, 31);
            this.btnDangnhap.TabIndex = 32;
            this.btnDangnhap.Text = "Đăng Nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(187, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(152, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tên Đăng Nhập:";
            // 
            // picture1
            // 
            this.picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture1.Image = global::QLCONGVAN.Properties.Resources.đăng_nhập;
            this.picture1.Location = new System.Drawing.Point(26, 72);
            this.picture1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(110, 158);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1.TabIndex = 34;
            this.picture1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(557, 322);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.DangNhap);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MatKhau;
        private System.Windows.Forms.TextBox DangNhap;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}