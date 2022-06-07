namespace Do_An
{
    partial class UC_BanHang
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachMua = new System.Windows.Forms.DataGridView();
            this.dgv_SanPham = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Type = new System.Windows.Forms.ComboBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_IDSanPham = new System.Windows.Forms.TextBox();
            this.tb_TenSanPham = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_LapHD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_IDLoHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.num_SoLuongMua = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuongMua)).BeginInit();

            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(579, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 41);

            this.label3.TabIndex = 119;
            this.label3.Text = "Tạo hóa đơn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgv_DanhSachMua);
            this.groupBox1.Location = new System.Drawing.Point(749, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(549, 249);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách mua hàng";
            // 
            // dgv_DanhSachMua
            // 
            this.dgv_DanhSachMua.AllowUserToAddRows = false;
            this.dgv_DanhSachMua.AllowUserToDeleteRows = false;
            this.dgv_DanhSachMua.AllowUserToOrderColumns = true;
            this.dgv_DanhSachMua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachMua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachMua.Location = new System.Drawing.Point(7, 23);
            this.dgv_DanhSachMua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_DanhSachMua.MultiSelect = false;
            this.dgv_DanhSachMua.Name = "dgv_DanhSachMua";
            this.dgv_DanhSachMua.ReadOnly = true;
            this.dgv_DanhSachMua.RowHeadersWidth = 51;
            this.dgv_DanhSachMua.RowTemplate.Height = 25;
            this.dgv_DanhSachMua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachMua.Size = new System.Drawing.Size(535, 218);
            this.dgv_DanhSachMua.TabIndex = 0;
            this.dgv_DanhSachMua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachMua_CellClick);
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.AllowUserToAddRows = false;
            this.dgv_SanPham.AllowUserToDeleteRows = false;
            this.dgv_SanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanPham.Location = new System.Drawing.Point(25, 57);
            this.dgv_SanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_SanPham.MultiSelect = false;
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.ReadOnly = true;
            this.dgv_SanPham.RowHeadersWidth = 51;
            this.dgv_SanPham.RowTemplate.Height = 25;
            this.dgv_SanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SanPham.Size = new System.Drawing.Size(1247, 324);
            this.dgv_SanPham.TabIndex = 121;
            this.dgv_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPham_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 122;
            this.label1.Text = "Phân loại";
            // 
            // cbb_Type
            // 
            this.cbb_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Type.FormattingEnabled = true;
            this.cbb_Type.Items.AddRange(new object[] {
            "Tất cả",
            "Xe đạp",
            "Phụ kiện",
            "Phụ tùng xe"});
            this.cbb_Type.Location = new System.Drawing.Point(109, 8);
            this.cbb_Type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_Type.Name = "cbb_Type";
            this.cbb_Type.Size = new System.Drawing.Size(241, 28);
            this.cbb_Type.TabIndex = 123;
            this.cbb_Type.SelectedIndexChanged += new System.EventHandler(this.cbb_Type_SelectedIndexChanged);
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_Search.Location = new System.Drawing.Point(859, 10);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(307, 34);
            this.tb_Search.TabIndex = 124;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(1171, 10);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(99, 36);
            this.btn_Search.TabIndex = 134;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 135;
            this.label2.Text = "ID sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(14, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 136;
            this.label4.Text = "Tên sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(14, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 137;
            this.label5.Text = "Số lượng mua";
            // 
            // tb_IDSanPham
            // 
            this.tb_IDSanPham.Enabled = false;
            this.tb_IDSanPham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_IDSanPham.Location = new System.Drawing.Point(146, 82);
            this.tb_IDSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_IDSanPham.Name = "tb_IDSanPham";
            this.tb_IDSanPham.Size = new System.Drawing.Size(268, 34);
            this.tb_IDSanPham.TabIndex = 138;
            // 
            // tb_TenSanPham
            // 
            this.tb_TenSanPham.Enabled = false;
            this.tb_TenSanPham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_TenSanPham.Location = new System.Drawing.Point(146, 136);
            this.tb_TenSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_TenSanPham.Name = "tb_TenSanPham";
            this.tb_TenSanPham.Size = new System.Drawing.Size(268, 34);
            this.tb_TenSanPham.TabIndex = 139;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Add.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Location = new System.Drawing.Point(521, 26);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(147, 48);
            this.btn_Add.TabIndex = 141;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseCompatibleTextRendering = true;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Delete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Location = new System.Drawing.Point(521, 110);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(147, 48);
            this.btn_Delete.TabIndex = 142;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_LapHD
            // 
            this.btn_LapHD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_LapHD.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_LapHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_LapHD.FlatAppearance.BorderSize = 0;
            this.btn_LapHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LapHD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_LapHD.Location = new System.Drawing.Point(521, 188);
            this.btn_LapHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LapHD.Name = "btn_LapHD";
            this.btn_LapHD.Size = new System.Drawing.Size(147, 48);
            this.btn_LapHD.TabIndex = 143;
            this.btn_LapHD.Text = "Lập hoá đơn";
            this.btn_LapHD.UseVisualStyleBackColor = false;
            this.btn_LapHD.Click += new System.EventHandler(this.btn_LapHD_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_IDLoHang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.num_SoLuongMua);
            this.panel1.Controls.Add(this.btn_LapHD);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.tb_TenSanPham);
            this.panel1.Controls.Add(this.tb_IDSanPham);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 239);
            this.panel1.TabIndex = 144;
            // 
            // tb_IDLoHang
            // 
            this.tb_IDLoHang.Enabled = false;
            this.tb_IDLoHang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_IDLoHang.Location = new System.Drawing.Point(146, 26);
            this.tb_IDLoHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_IDLoHang.Name = "tb_IDLoHang";
            this.tb_IDLoHang.Size = new System.Drawing.Size(268, 34);
            this.tb_IDLoHang.TabIndex = 146;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(14, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 145;
            this.label6.Text = "ID lô hàng";
            // 
            // num_SoLuongMua
            // 
            this.num_SoLuongMua.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.num_SoLuongMua.Location = new System.Drawing.Point(146, 198);
            this.num_SoLuongMua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_SoLuongMua.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_SoLuongMua.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_SoLuongMua.Name = "num_SoLuongMua";
            this.num_SoLuongMua.Size = new System.Drawing.Size(268, 32);
            this.num_SoLuongMua.TabIndex = 144;
            this.num_SoLuongMua.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_Search);
            this.panel2.Controls.Add(this.tb_Search);
            this.panel2.Controls.Add(this.cbb_Type);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgv_SanPham);
            this.panel2.Location = new System.Drawing.Point(13, 302);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1285, 390);
            this.panel2.TabIndex = 145;
            // 
            // UC_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_BanHang";
            this.Size = new System.Drawing.Size(1315, 702);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuongMua)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private GroupBox groupBox1;
        private DataGridView dgv_DanhSachMua;
        private DataGridView dgv_SanPham;
        private Label label1;
        private ComboBox cbb_Type;
        private TextBox tb_Search;
        private Button btn_Search;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox tb_IDSanPham;
        private TextBox tb_TenSanPham;
        private Button btn_Add;
        private Button btn_Delete;
        private Button btn_LapHD;
        private Panel panel1;
        private Panel panel2;
        private NumericUpDown num_SoLuongMua;
        private TextBox tb_IDLoHang;
        private Label label6;
    }
}
