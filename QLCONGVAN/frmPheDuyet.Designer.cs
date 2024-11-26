namespace QLCONGVAN
{
    partial class frmPheDuyet
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.LoadCongVan = new System.Windows.Forms.DataGridView();
            this.btnPheDuyet = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBTimKiem = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.picture7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadCongVan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(530, 156);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 35);
            this.btnThoat.TabIndex = 44;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // LoadCongVan
            // 
            this.LoadCongVan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoadCongVan.Location = new System.Drawing.Point(41, 233);
            this.LoadCongVan.Name = "LoadCongVan";
            this.LoadCongVan.Size = new System.Drawing.Size(592, 239);
            this.LoadCongVan.TabIndex = 46;
            // 
            // btnPheDuyet
            // 
            this.btnPheDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPheDuyet.Location = new System.Drawing.Point(379, 154);
            this.btnPheDuyet.Name = "btnPheDuyet";
            this.btnPheDuyet.Size = new System.Drawing.Size(75, 35);
            this.btnPheDuyet.TabIndex = 43;
            this.btnPheDuyet.Text = "Phê duyệt";
            this.btnPheDuyet.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(220, 156);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 33);
            this.btnTimKiem.TabIndex = 42;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 35);
            this.label1.TabIndex = 45;
            this.label1.Text = "PHÊ DUYỆT CÔNG VĂN";
            // 
            // tBTimKiem
            // 
            this.tBTimKiem.Location = new System.Drawing.Point(220, 105);
            this.tBTimKiem.Name = "tBTimKiem";
            this.tBTimKiem.Size = new System.Drawing.Size(385, 20);
            this.tBTimKiem.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(217, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 16);
            this.label16.TabIndex = 40;
            this.label16.Text = "Tìm kiếm số công văn:";
            // 
            // picture7
            // 
            this.picture7.Location = new System.Drawing.Point(66, 58);
            this.picture7.Name = "picture7";
            this.picture7.Size = new System.Drawing.Size(123, 144);
            this.picture7.TabIndex = 47;
            this.picture7.TabStop = false;
            // 
            // frmPheDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 521);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.picture7);
            this.Controls.Add(this.LoadCongVan);
            this.Controls.Add(this.btnPheDuyet);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBTimKiem);
            this.Controls.Add(this.label16);
            this.Name = "frmPheDuyet";
            this.Text = "frmPheDuyet";
            ((System.ComponentModel.ISupportInitialize)(this.LoadCongVan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox picture7;
        private System.Windows.Forms.DataGridView LoadCongVan;
        private System.Windows.Forms.Button btnPheDuyet;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBTimKiem;
        private System.Windows.Forms.Label label16;
    }
}