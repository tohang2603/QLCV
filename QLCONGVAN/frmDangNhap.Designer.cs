﻿namespace QLCONGVAN
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
            this.tBMatKhau = new System.Windows.Forms.TextBox();
            this.TbDangNhap = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picture1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBMatKhau
            // 
            this.tBMatKhau.Location = new System.Drawing.Point(378, 180);
            this.tBMatKhau.Name = "tBMatKhau";
            this.tBMatKhau.PasswordChar = '*';
            this.tBMatKhau.Size = new System.Drawing.Size(227, 20);
            this.tBMatKhau.TabIndex = 36;
            // 
            // TbDangNhap
            // 
            this.TbDangNhap.Location = new System.Drawing.Point(378, 129);
            this.TbDangNhap.Name = "TbDangNhap";
            this.TbDangNhap.Size = new System.Drawing.Size(227, 20);
            this.TbDangNhap.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(277, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 39);
            this.label15.TabIndex = 33;
            this.label15.Text = "ĐĂNG NHẬP";
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btnDangnhap.Location = new System.Drawing.Point(419, 238);
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
            this.label2.Location = new System.Drawing.Point(249, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(203, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tên Đăng Nhập:";
            // 
            // picture1
            // 
            this.picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture1.Image = global::QLCONGVAN.Properties.Resources.đăng_nhập;
            this.picture1.Location = new System.Drawing.Point(35, 88);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(145, 193);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1.TabIndex = 34;
            this.picture1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(681, 338);
            this.Controls.Add(this.tBMatKhau);
            this.Controls.Add(this.TbDangNhap);
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

        private System.Windows.Forms.TextBox tBMatKhau;
        private System.Windows.Forms.TextBox TbDangNhap;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}