﻿namespace QLCONGVAN
{
    partial class frmPhanQuyen
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
            this.label15 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.tBtimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ttBmaquyen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.LoadPhanQuyen = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txbMota = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txbVaitro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSTT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picture6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture6)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(384, 23);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(217, 49);
            this.label15.TabIndex = 86;
            this.label15.Text = "PHÂN QUYỀN";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(811, 87);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(120, 39);
            this.btnTimkiem.TabIndex = 85;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // tBtimKiem
            // 
            this.tBtimKiem.Location = new System.Drawing.Point(459, 97);
            this.tBtimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBtimKiem.Name = "tBtimKiem";
            this.tBtimKiem.Size = new System.Drawing.Size(309, 22);
            this.tBtimKiem.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 83;
            this.label6.Text = "Tìm kiếm quyền:";
            // 
            // ttBmaquyen
            // 
            this.ttBmaquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttBmaquyen.Location = new System.Drawing.Point(459, 185);
            this.ttBmaquyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ttBmaquyen.Name = "ttBmaquyen";
            this.ttBmaquyen.Size = new System.Drawing.Size(152, 24);
            this.ttBmaquyen.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 81;
            this.label5.Text = "Mã quyền:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(768, 356);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 37);
            this.btnThoat.TabIndex = 76;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // LoadPhanQuyen
            // 
            this.LoadPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoadPhanQuyen.Location = new System.Drawing.Point(47, 470);
            this.LoadPhanQuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadPhanQuyen.Name = "LoadPhanQuyen";
            this.LoadPhanQuyen.RowHeadersWidth = 51;
            this.LoadPhanQuyen.Size = new System.Drawing.Size(909, 234);
            this.LoadPhanQuyen.TabIndex = 79;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(617, 356);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 37);
            this.btnLuu.TabIndex = 74;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(449, 356);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 37);
            this.btnXoa.TabIndex = 71;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // txbMota
            // 
            this.txbMota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMota.Location = new System.Drawing.Point(459, 286);
            this.txbMota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMota.Name = "txbMota";
            this.txbMota.Size = new System.Drawing.Size(471, 24);
            this.txbMota.TabIndex = 78;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(104, 356);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 37);
            this.btnThem.TabIndex = 69;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(275, 356);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 37);
            this.btnCapNhat.TabIndex = 70;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // txbVaitro
            // 
            this.txbVaitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVaitro.Location = new System.Drawing.Point(459, 235);
            this.txbVaitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbVaitro.Name = "txbVaitro";
            this.txbVaitro.Size = new System.Drawing.Size(471, 24);
            this.txbVaitro.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 75;
            this.label4.Text = "Mô Tả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 73;
            this.label3.Text = "Vai Trò:";
            // 
            // txbSTT
            // 
            this.txbSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSTT.Location = new System.Drawing.Point(459, 138);
            this.txbSTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSTT.Name = "txbSTT";
            this.txbSTT.Size = new System.Drawing.Size(152, 24);
            this.txbSTT.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 68;
            this.label1.Text = "STT:";
            // 
            // picture6
            // 
            this.picture6.Location = new System.Drawing.Point(65, 97);
            this.picture6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picture6.Name = "picture6";
            this.picture6.Size = new System.Drawing.Size(188, 214);
            this.picture6.TabIndex = 80;
            this.picture6.TabStop = false;
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.tBtimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ttBmaquyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picture6);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.LoadPhanQuyen);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txbMota);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txbVaitro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSTT);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPhanQuyen";
            this.Text = "frmPhanQuyen";
            ((System.ComponentModel.ISupportInitialize)(this.LoadPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox tBtimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ttBmaquyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picture6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView LoadPhanQuyen;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txbMota;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txbVaitro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSTT;
        private System.Windows.Forms.Label label1;
    }
}