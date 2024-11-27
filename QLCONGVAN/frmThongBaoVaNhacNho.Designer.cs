namespace QLCONGVAN
{
    partial class frmThongBaoVaNhacNho
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
            this.picture9 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cBemail = new System.Windows.Forms.CheckBox();
            this.btnGui = new System.Windows.Forms.Button();
            this.loadNhanVien = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.rTBThongBao = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tBTimKiem = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // picture9
            // 
            this.picture9.Location = new System.Drawing.Point(56, 80);
            this.picture9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picture9.Name = "picture9";
            this.picture9.Size = new System.Drawing.Size(184, 214);
            this.picture9.TabIndex = 51;
            this.picture9.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(780, 314);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 46);
            this.btnThoat.TabIndex = 42;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cBemail
            // 
            this.cBemail.AutoSize = true;
            this.cBemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBemail.Location = new System.Drawing.Point(309, 314);
            this.cBemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBemail.Name = "cBemail";
            this.cBemail.Size = new System.Drawing.Size(185, 22);
            this.cBemail.TabIndex = 50;
            this.cBemail.Text = "Gửi thông báo về email ";
            this.cBemail.UseVisualStyleBackColor = true;
            // 
            // btnGui
            // 
            this.btnGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.Location = new System.Drawing.Point(579, 314);
            this.btnGui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(100, 46);
            this.btnGui.TabIndex = 41;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = true;
            // 
            // loadNhanVien
            // 
            this.loadNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadNhanVien.Location = new System.Drawing.Point(43, 400);
            this.loadNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadNhanVien.Name = "loadNhanVien";
            this.loadNhanVien.RowHeadersWidth = 51;
            this.loadNhanVien.Size = new System.Drawing.Size(955, 249);
            this.loadNhanVien.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(415, 11);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(268, 49);
            this.label15.TabIndex = 48;
            this.label15.Text = "GỬI THÔNG BÁO";
            // 
            // rTBThongBao
            // 
            this.rTBThongBao.Location = new System.Drawing.Point(309, 208);
            this.rTBThongBao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rTBThongBao.Name = "rTBThongBao";
            this.rTBThongBao.Size = new System.Drawing.Size(664, 85);
            this.rTBThongBao.TabIndex = 47;
            this.rTBThongBao.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nhập nội dung cần thông báo/ nhắc nhở:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(875, 105);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 42);
            this.btnTimKiem.TabIndex = 45;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // tBTimKiem
            // 
            this.tBTimKiem.Location = new System.Drawing.Point(309, 114);
            this.tBTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBTimKiem.Name = "tBTimKiem";
            this.tBTimKiem.Size = new System.Drawing.Size(509, 22);
            this.tBTimKiem.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(305, 80);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(263, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = "Tìm kiếm nhân viên cần nhắc nhở:";
            // 
            // frmThongBaoVaNhacNho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 683);
            this.Controls.Add(this.picture9);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cBemail);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.loadNhanVien);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rTBThongBao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.tBTimKiem);
            this.Controls.Add(this.label16);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThongBaoVaNhacNho";
            this.Text = "frmThongBaoVaNhacNho";
            ((System.ComponentModel.ISupportInitialize)(this.picture9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture9;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox cBemail;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.DataGridView loadNhanVien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox rTBThongBao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox tBTimKiem;
        private System.Windows.Forms.Label label16;
    }
}