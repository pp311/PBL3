namespace Do_An
{
    partial class UC_Kho
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.num_GiamGia = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.num_Gia = new System.Windows.Forms.NumericUpDown();
            this.num_SoLuongNhap = new System.Windows.Forms.NumericUpDown();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_IDSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgv_Table = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SuaSP = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_NhapSP = new System.Windows.Forms.Button();
            this.btn_XemCT = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_GiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Gia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuongNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.num_GiamGia);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.num_Gia);
            this.panel2.Controls.Add(this.num_SoLuongNhap);
            this.panel2.Controls.Add(this.dtp_NgayNhap);
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.tb_IDSP);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(32, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1202, 185);
            this.panel2.TabIndex = 129;
            // 
            // num_GiamGia
            // 
            this.num_GiamGia.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.num_GiamGia.Location = new System.Drawing.Point(185, 113);
            this.num_GiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_GiamGia.Name = "num_GiamGia";
            this.num_GiamGia.Size = new System.Drawing.Size(290, 36);
            this.num_GiamGia.TabIndex = 141;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 140;
            this.label1.Text = "% giảm giá";
            // 
            // num_Gia
            // 
            this.num_Gia.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.num_Gia.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Gia.Location = new System.Drawing.Point(843, 63);
            this.num_Gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_Gia.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.num_Gia.Name = "num_Gia";
            this.num_Gia.Size = new System.Drawing.Size(287, 36);
            this.num_Gia.TabIndex = 139;
            this.num_Gia.ThousandsSeparator = true;
            // 
            // num_SoLuongNhap
            // 
            this.num_SoLuongNhap.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.num_SoLuongNhap.Location = new System.Drawing.Point(185, 63);
            this.num_SoLuongNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_SoLuongNhap.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.num_SoLuongNhap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_SoLuongNhap.Name = "num_SoLuongNhap";
            this.num_SoLuongNhap.Size = new System.Drawing.Size(290, 36);
            this.num_SoLuongNhap.TabIndex = 138;
            this.num_SoLuongNhap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayNhap.Location = new System.Drawing.Point(843, 20);
            this.dtp_NgayNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(287, 36);
            this.dtp_NgayNhap.TabIndex = 137;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Save.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Location = new System.Drawing.Point(553, 151);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(149, 32);
            this.btn_Save.TabIndex = 132;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_IDSP
            // 
            this.tb_IDSP.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.tb_IDSP.Location = new System.Drawing.Point(185, 20);
            this.tb_IDSP.Margin = new System.Windows.Forms.Padding(2);
            this.tb_IDSP.Name = "tb_IDSP";
            this.tb_IDSP.Size = new System.Drawing.Size(290, 34);
            this.tb_IDSP.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(731, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 27);
            this.label5.TabIndex = 80;
            this.label5.Text = "Giá nhập";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(731, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 27);
            this.label14.TabIndex = 114;
            this.label14.Text = "Ngày nhập";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(42, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 27);
            this.label15.TabIndex = 113;
            this.label15.Text = "ID sản phẩm";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(42, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 27);
            this.label13.TabIndex = 116;
            this.label13.Text = "Số lượng nhập";
            // 
            // dgv_Table
            // 
            this.dgv_Table.AllowUserToAddRows = false;
            this.dgv_Table.AllowUserToDeleteRows = false;
            this.dgv_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Table.Location = new System.Drawing.Point(32, 266);
            this.dgv_Table.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Table.Name = "dgv_Table";
            this.dgv_Table.ReadOnly = true;
            this.dgv_Table.RowHeadersWidth = 51;
            this.dgv_Table.RowTemplate.Height = 29;
            this.dgv_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Table.Size = new System.Drawing.Size(1050, 420);
            this.dgv_Table.TabIndex = 130;
            this.dgv_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Table_CellClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(534, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 41);
            this.label3.TabIndex = 128;
            this.label3.Text = "Quản lí kho hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SuaSP
            // 
            this.btn_SuaSP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_SuaSP.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_SuaSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_SuaSP.FlatAppearance.BorderSize = 0;
            this.btn_SuaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuaSP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_SuaSP.Location = new System.Drawing.Point(1123, 345);
            this.btn_SuaSP.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SuaSP.Name = "btn_SuaSP";
            this.btn_SuaSP.Size = new System.Drawing.Size(149, 57);
            this.btn_SuaSP.TabIndex = 132;
            this.btn_SuaSP.Text = "Sửa thông tin nhập hàng";
            this.btn_SuaSP.UseVisualStyleBackColor = false;
            this.btn_SuaSP.Click += new System.EventHandler(this.btn_SuaSP_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Delete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Location = new System.Drawing.Point(1123, 426);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(149, 57);
            this.btn_Delete.TabIndex = 133;
            this.btn_Delete.Text = "Xoá thông tin nhập hàng";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_NhapSP
            // 
            this.btn_NhapSP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_NhapSP.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_NhapSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_NhapSP.FlatAppearance.BorderSize = 0;
            this.btn_NhapSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapSP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_NhapSP.Location = new System.Drawing.Point(1123, 266);
            this.btn_NhapSP.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NhapSP.Name = "btn_NhapSP";
            this.btn_NhapSP.Size = new System.Drawing.Size(149, 57);
            this.btn_NhapSP.TabIndex = 131;
            this.btn_NhapSP.Text = "Nhập sản phẩm";
            this.btn_NhapSP.UseVisualStyleBackColor = false;
            this.btn_NhapSP.Click += new System.EventHandler(this.btn_NhapSP_Click);
            // 
            // btn_XemCT
            // 
            this.btn_XemCT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_XemCT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_XemCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_XemCT.FlatAppearance.BorderSize = 0;
            this.btn_XemCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XemCT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_XemCT.Location = new System.Drawing.Point(1123, 508);
            this.btn_XemCT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XemCT.Name = "btn_XemCT";
            this.btn_XemCT.Size = new System.Drawing.Size(149, 57);
            this.btn_XemCT.TabIndex = 136;
            this.btn_XemCT.Text = "Xem thông tin sản phẩm";
            this.btn_XemCT.UseVisualStyleBackColor = false;
            this.btn_XemCT.Click += new System.EventHandler(this.btn_XemCT_Click);
            // 
            // UC_Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_XemCT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_Table);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SuaSP);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_NhapSP);
            this.Name = "UC_Kho";
            this.Size = new System.Drawing.Size(1315, 702);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_GiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Gia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuongNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private TextBox tb_IDSP;
        private Label label5;
        private Label label14;
        private Label label15;
        private Label label13;
        private DataGridView dgv_Table;
        private Label label3;
        private Button btn_SuaSP;
        private Button btn_Delete;
        private Button btn_NhapSP;
        private Button btn_XemCT;
        private Button btn_Save;
        private DateTimePicker dtp_NgayNhap;
        private NumericUpDown num_SoLuongNhap;
        private NumericUpDown num_Gia;
        private NumericUpDown num_GiamGia;
        private Label label1;
    }
}
