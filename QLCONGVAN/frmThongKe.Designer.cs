namespace QLCONGVAN
{
    partial class frmThongKe
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
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatexcel = new System.Windows.Forms.Button();
            this.LoadThongKe = new System.Windows.Forms.DataGridView();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cBTieuchi = new System.Windows.Forms.ComboBox();
            this.dTPDenngay = new System.Windows.Forms.DateTimePicker();
            this.dTPTungay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picture10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture10)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tiêu chí:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(536, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 39);
            this.label15.TabIndex = 39;
            this.label15.Text = "THỐNG KÊ";
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(731, 491);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 32);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXuatexcel
            // 
            this.btnXuatexcel.AutoSize = true;
            this.btnXuatexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatexcel.Location = new System.Drawing.Point(543, 491);
            this.btnXuatexcel.Name = "btnXuatexcel";
            this.btnXuatexcel.Size = new System.Drawing.Size(124, 32);
            this.btnXuatexcel.TabIndex = 37;
            this.btnXuatexcel.Text = "Xuất EXCEL";
            this.btnXuatexcel.UseVisualStyleBackColor = true;
            // 
            // LoadThongKe
            // 
            this.LoadThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoadThongKe.Location = new System.Drawing.Point(286, 71);
            this.LoadThongKe.Name = "LoadThongKe";
            this.LoadThongKe.Size = new System.Drawing.Size(857, 400);
            this.LoadThongKe.TabIndex = 36;
            // 
            // btnLoc
            // 
            this.btnLoc.AutoSize = true;
            this.btnLoc.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoc.Location = new System.Drawing.Point(88, 490);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 32);
            this.btnLoc.TabIndex = 35;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // cBTieuchi
            // 
            this.cBTieuchi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cBTieuchi.FormattingEnabled = true;
            this.cBTieuchi.Items.AddRange(new object[] {
            "tất cả công văn",
            "",
            "công văn đã hoàn thành",
            "",
            "công văn đang xử lý"});
            this.cBTieuchi.Location = new System.Drawing.Point(38, 444);
            this.cBTieuchi.Name = "cBTieuchi";
            this.cBTieuchi.Size = new System.Drawing.Size(194, 27);
            this.cBTieuchi.TabIndex = 34;
            // 
            // dTPDenngay
            // 
            this.dTPDenngay.Location = new System.Drawing.Point(38, 371);
            this.dTPDenngay.Name = "dTPDenngay";
            this.dTPDenngay.Size = new System.Drawing.Size(194, 20);
            this.dTPDenngay.TabIndex = 33;
            // 
            // dTPTungay
            // 
            this.dTPTungay.Location = new System.Drawing.Point(38, 304);
            this.dTPTungay.Name = "dTPTungay";
            this.dTPTungay.Size = new System.Drawing.Size(194, 20);
            this.dTPTungay.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(35, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(35, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Từ ngày:";
            // 
            // picture10
            // 
            this.picture10.Location = new System.Drawing.Point(38, 71);
            this.picture10.Name = "picture10";
            this.picture10.Size = new System.Drawing.Size(194, 185);
            this.picture10.TabIndex = 40;
            this.picture10.TabStop = false;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 574);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picture10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatexcel);
            this.Controls.Add(this.LoadThongKe);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.cBTieuchi);
            this.Controls.Add(this.dTPDenngay);
            this.Controls.Add(this.dTPTungay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.LoadThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picture10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuatexcel;
        private System.Windows.Forms.DataGridView LoadThongKe;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cBTieuchi;
        private System.Windows.Forms.DateTimePicker dTPDenngay;
        private System.Windows.Forms.DateTimePicker dTPTungay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}