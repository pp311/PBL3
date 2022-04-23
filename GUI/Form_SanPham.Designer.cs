namespace Do_An
{
    partial class Form_SanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.num_Gia = new System.Windows.Forms.NumericUpDown();
            this.num_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.date_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.tb_TenSP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_PhanLoai = new System.Windows.Forms.ComboBox();
            this.tb_IDSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.dtlv_F_SP = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Gia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlv_F_SP)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(561, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập thông tin sản phẩm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.num_Gia);
            this.panel1.Controls.Add(this.num_SoLuong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.date_NgayNhap);
            this.panel1.Controls.Add(this.tb_TenSP);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbb_PhanLoai);
            this.panel1.Controls.Add(this.tb_IDSP);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(99, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 190);
            this.panel1.TabIndex = 37;
            // 
            // num_Gia
            // 
            this.num_Gia.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num_Gia.Location = new System.Drawing.Point(861, 136);
            this.num_Gia.Name = "num_Gia";
            this.num_Gia.Size = new System.Drawing.Size(381, 36);
            this.num_Gia.TabIndex = 110;
            // 
            // num_SoLuong
            // 
            this.num_SoLuong.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num_SoLuong.Location = new System.Drawing.Point(186, 139);
            this.num_SoLuong.Name = "num_SoLuong";
            this.num_SoLuong.Size = new System.Drawing.Size(381, 36);
            this.num_SoLuong.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "ID sản phẩm";
            // 
            // date_NgayNhap
            // 
            this.date_NgayNhap.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgayNhap.Location = new System.Drawing.Point(861, 73);
            this.date_NgayNhap.Name = "date_NgayNhap";
            this.date_NgayNhap.Size = new System.Drawing.Size(381, 36);
            this.date_NgayNhap.TabIndex = 108;
            // 
            // tb_TenSP
            // 
            this.tb_TenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_TenSP.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_TenSP.Location = new System.Drawing.Point(186, 77);
            this.tb_TenSP.Name = "tb_TenSP";
            this.tb_TenSP.Size = new System.Drawing.Size(381, 36);
            this.tb_TenSP.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(725, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 29);
            this.label8.TabIndex = 30;
            this.label8.Text = "Giá";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(34, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tên sản phẩm";
            // 
            // cbb_PhanLoai
            // 
            this.cbb_PhanLoai.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbb_PhanLoai.FormattingEnabled = true;
            this.cbb_PhanLoai.Location = new System.Drawing.Point(861, 11);
            this.cbb_PhanLoai.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbb_PhanLoai.Name = "cbb_PhanLoai";
            this.cbb_PhanLoai.Size = new System.Drawing.Size(381, 34);
            this.cbb_PhanLoai.TabIndex = 107;
            // 
            // tb_IDSP
            // 
            this.tb_IDSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_IDSP.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_IDSP.Location = new System.Drawing.Point(186, 11);
            this.tb_IDSP.Name = "tb_IDSP";
            this.tb_IDSP.Size = new System.Drawing.Size(381, 36);
            this.tb_IDSP.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(725, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ngày nhập";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 106;
            this.label2.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(725, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Phân loại";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Huy.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Huy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Huy.FlatAppearance.BorderSize = 0;
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Huy.Location = new System.Drawing.Point(812, 801);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(149, 71);
            this.btn_Huy.TabIndex = 104;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_XacNhan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_XacNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_XacNhan.FlatAppearance.BorderSize = 0;
            this.btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XacNhan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XacNhan.Location = new System.Drawing.Point(525, 801);
            this.btn_XacNhan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(149, 71);
            this.btn_XacNhan.TabIndex = 103;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // dtlv_F_SP
            // 
            this.dtlv_F_SP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtlv_F_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlv_F_SP.Location = new System.Drawing.Point(89, 307);
            this.dtlv_F_SP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtlv_F_SP.Name = "dtlv_F_SP";
            this.dtlv_F_SP.RowHeadersWidth = 51;
            this.dtlv_F_SP.RowTemplate.Height = 29;
            this.dtlv_F_SP.Size = new System.Drawing.Size(1300, 471);
            this.dtlv_F_SP.TabIndex = 131;
            // 
            // Form_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1489, 894);
            this.ControlBox = false;
            this.Controls.Add(this.dtlv_F_SP);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_SanPham";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_SanPham_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Gia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlv_F_SP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Panel panel1;
        private Label label2;
        private Button btn_Huy;
        private Button btn_XacNhan;
        private Label label4;
        private Label label6;
        private TextBox tb_IDSP;
        private Label label8;
        private TextBox tb_TenSP;
        private Label label7;
        private Label label5;
        private ComboBox cbb_PhanLoai;
        private DateTimePicker date_NgayNhap;
        private DataGridView dtlv_F_SP;
        private NumericUpDown num_Gia;
        private NumericUpDown num_SoLuong;
    }
}