namespace QLCONGVAN
{
    partial class frmDoiMatKhau
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
            this.tBNhaplaimk = new System.Windows.Forms.TextBox();
            this.tBMKmoi = new System.Windows.Forms.TextBox();
            this.tBmkHientai = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDongy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBNhaplaimk
            // 
            this.tBNhaplaimk.Location = new System.Drawing.Point(226, 237);
            this.tBNhaplaimk.Name = "tBNhaplaimk";
            this.tBNhaplaimk.Size = new System.Drawing.Size(220, 20);
            this.tBNhaplaimk.TabIndex = 39;
            // 
            // tBMKmoi
            // 
            this.tBMKmoi.Location = new System.Drawing.Point(226, 183);
            this.tBMKmoi.Name = "tBMKmoi";
            this.tBMKmoi.Size = new System.Drawing.Size(220, 20);
            this.tBMKmoi.TabIndex = 38;
            // 
            // tBmkHientai
            // 
            this.tBmkHientai.Location = new System.Drawing.Point(226, 128);
            this.tBmkHientai.Name = "tBmkHientai";
            this.tBmkHientai.Size = new System.Drawing.Size(220, 20);
            this.tBmkHientai.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(176, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(191, 39);
            this.label15.TabIndex = 36;
            this.label15.Text = "ĐỔI MẬT KHẨU";
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(301, 297);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 32);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnDongy
            // 
            this.btnDongy.AutoSize = true;
            this.btnDongy.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDongy.Location = new System.Drawing.Point(142, 297);
            this.btnDongy.Name = "btnDongy";
            this.btnDongy.Size = new System.Drawing.Size(103, 32);
            this.btnDongy.TabIndex = 34;
            this.btnDongy.Text = "Đồng ý";
            this.btnDongy.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(30, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(64, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(37, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mật khẩu hiện tại:";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 383);
            this.Controls.Add(this.tBNhaplaimk);
            this.Controls.Add(this.tBMKmoi);
            this.Controls.Add(this.tBmkHientai);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDongy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoiMatKhau";
            this.Text = "frmDoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBNhaplaimk;
        private System.Windows.Forms.TextBox tBMKmoi;
        private System.Windows.Forms.TextBox tBmkHientai;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDongy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}