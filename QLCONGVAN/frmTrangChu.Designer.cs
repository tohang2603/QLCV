namespace QLCONGVAN
{
    partial class frmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.congvanden = new System.Windows.Forms.PictureBox();
            this.congvandi = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pheduyet = new System.Windows.Forms.PictureBox();
            this.phanquyen = new System.Windows.Forms.PictureBox();
            this.quanlitaikhoan = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phongban = new System.Windows.Forms.PictureBox();
            this.coquan = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.thongke = new System.Windows.Forms.PictureBox();
            this.thongbao = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.congvanden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congvandi)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pheduyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanquyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlitaikhoan)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coquan)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongbao)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1170, 108);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.congvanden);
            this.tabPage1.Controls.Add(this.congvandi);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1162, 82);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lí công văn";
            // 
            // congvanden
            // 
            this.congvanden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.congvanden.Image = ((System.Drawing.Image)(resources.GetObject("congvanden.Image")));
            this.congvanden.Location = new System.Drawing.Point(61, 7);
            this.congvanden.Name = "congvanden";
            this.congvanden.Size = new System.Drawing.Size(44, 45);
            this.congvanden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.congvanden.TabIndex = 4;
            this.congvanden.TabStop = false;
            this.congvanden.Click += new System.EventHandler(this.congvanden_Click_1);
            // 
            // congvandi
            // 
            this.congvandi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.congvandi.Image = global::QLCONGVAN.Properties.Resources.CV_Den;
            this.congvandi.Location = new System.Drawing.Point(201, 7);
            this.congvandi.Name = "congvandi";
            this.congvandi.Size = new System.Drawing.Size(45, 46);
            this.congvandi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.congvandi.TabIndex = 3;
            this.congvandi.TabStop = false;
            this.congvandi.Click += new System.EventHandler(this.congvandi_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh mục công văn đi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh mục công văn đến";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.pheduyet);
            this.tabPage2.Controls.Add(this.phanquyen);
            this.tabPage2.Controls.Add(this.quanlitaikhoan);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 82);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Người dùng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phê duyệt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phân quyền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quản lí tài khoản";
            // 
            // pheduyet
            // 
            this.pheduyet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pheduyet.Image = global::QLCONGVAN.Properties.Resources.pheduyet1;
            this.pheduyet.Location = new System.Drawing.Point(275, 7);
            this.pheduyet.Name = "pheduyet";
            this.pheduyet.Size = new System.Drawing.Size(50, 46);
            this.pheduyet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pheduyet.TabIndex = 2;
            this.pheduyet.TabStop = false;
            this.pheduyet.Click += new System.EventHandler(this.pheduyet_Click);
            // 
            // phanquyen
            // 
            this.phanquyen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phanquyen.Image = global::QLCONGVAN.Properties.Resources.phanquyen;
            this.phanquyen.Location = new System.Drawing.Point(164, 7);
            this.phanquyen.Name = "phanquyen";
            this.phanquyen.Size = new System.Drawing.Size(50, 45);
            this.phanquyen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phanquyen.TabIndex = 1;
            this.phanquyen.TabStop = false;
            this.phanquyen.Click += new System.EventHandler(this.phanquyen_Click);
            // 
            // quanlitaikhoan
            // 
            this.quanlitaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.quanlitaikhoan.Image = global::QLCONGVAN.Properties.Resources.nguoidung;
            this.quanlitaikhoan.Location = new System.Drawing.Point(50, 7);
            this.quanlitaikhoan.Name = "quanlitaikhoan";
            this.quanlitaikhoan.Size = new System.Drawing.Size(49, 46);
            this.quanlitaikhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.quanlitaikhoan.TabIndex = 0;
            this.quanlitaikhoan.TabStop = false;
            this.quanlitaikhoan.Click += new System.EventHandler(this.quanlitaikhoan_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.phongban);
            this.tabPage3.Controls.Add(this.coquan);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(976, 82);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Các bộ phận";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phòng Ban";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cơ Quan";
            // 
            // phongban
            // 
            this.phongban.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phongban.Image = global::QLCONGVAN.Properties.Resources.phongban;
            this.phongban.Location = new System.Drawing.Point(127, 11);
            this.phongban.Name = "phongban";
            this.phongban.Size = new System.Drawing.Size(42, 46);
            this.phongban.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phongban.TabIndex = 4;
            this.phongban.TabStop = false;
            this.phongban.Click += new System.EventHandler(this.phongban_Click);
            // 
            // coquan
            // 
            this.coquan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.coquan.Image = global::QLCONGVAN.Properties.Resources.cơquan2;
            this.coquan.Location = new System.Drawing.Point(44, 11);
            this.coquan.Name = "coquan";
            this.coquan.Size = new System.Drawing.Size(46, 46);
            this.coquan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coquan.TabIndex = 3;
            this.coquan.TabStop = false;
            this.coquan.Click += new System.EventHandler(this.coquan_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.thongke);
            this.tabPage4.Controls.Add(this.thongbao);
            this.tabPage4.ForeColor = System.Drawing.Color.Black;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(976, 82);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Các chức năng khác";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Thông kê";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Thông báo";
            // 
            // thongke
            // 
            this.thongke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thongke.Image = global::QLCONGVAN.Properties.Resources.thongke;
            this.thongke.Location = new System.Drawing.Point(125, 12);
            this.thongke.Name = "thongke";
            this.thongke.Size = new System.Drawing.Size(46, 43);
            this.thongke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thongke.TabIndex = 4;
            this.thongke.TabStop = false;
            this.thongke.Click += new System.EventHandler(this.thongke_Click);
            // 
            // thongbao
            // 
            this.thongbao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thongbao.Image = global::QLCONGVAN.Properties.Resources.thongbao;
            this.thongbao.Location = new System.Drawing.Point(34, 12);
            this.thongbao.Name = "thongbao";
            this.thongbao.Size = new System.Drawing.Size(44, 43);
            this.thongbao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thongbao.TabIndex = 3;
            this.thongbao.TabStop = false;
            this.thongbao.Click += new System.EventHandler(this.thongbao_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(121, 623);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(482, 50);
            this.label10.TabIndex = 2;
            this.label10.Text = "HỆ THỐNG QUẢN LÍ CÔNG VĂN";
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCONGVAN.Properties.Resources.hinhnen34;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1173, 749);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "frmTrangChu";
            this.Text = "frmTrangChu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.congvanden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congvandi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pheduyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanquyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlitaikhoan)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coquan)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongbao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox congvanden;
        private System.Windows.Forms.PictureBox congvandi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pheduyet;
        private System.Windows.Forms.PictureBox phanquyen;
        private System.Windows.Forms.PictureBox quanlitaikhoan;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox phongban;
        private System.Windows.Forms.PictureBox coquan;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox thongke;
        private System.Windows.Forms.PictureBox thongbao;
        private System.Windows.Forms.Label label10;
    }
}