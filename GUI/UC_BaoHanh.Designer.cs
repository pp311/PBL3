namespace Do_An
{
    partial class UC_BaoHanh
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dgv_LichSuBaoHanh = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_IDBaoHanh = new System.Windows.Forms.Label();
            this.lb_Serial = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_IDNhanVien = new System.Windows.Forms.TextBox();
            this.lb_STT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_NgayBaoHanh = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_GhiChuBaoHanh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_HanBaoHanh = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_DanhSachBaoHanh = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_DangBaoHanh = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_TenSP = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichSuBaoHanh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachBaoHanh)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DangBaoHanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(509, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 41);
            this.label3.TabIndex = 128;
            this.label3.Text = "Thông tin bảo hành";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 134;
            this.label1.Text = "Mã bảo hành/Serial";
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddNew.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_AddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AddNew.FlatAppearance.BorderSize = 0;
            this.btn_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNew.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_AddNew.Location = new System.Drawing.Point(620, 21);
            this.btn_AddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(139, 57);
            this.btn_AddNew.TabIndex = 132;
            this.btn_AddNew.Text = "Tạo mới ";
            this.btn_AddNew.UseVisualStyleBackColor = false;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.button16.Location = new System.Drawing.Point(437, 64);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(83, 37);
            this.button16.TabIndex = 131;
            this.button16.Text = "Tra cứu";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Segoe UI", 12.8F);
            this.tb_Search.Location = new System.Drawing.Point(213, 64);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(214, 36);
            this.tb_Search.TabIndex = 135;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Save.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Location = new System.Drawing.Point(355, 305);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(120, 38);
            this.btn_Save.TabIndex = 136;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.dgv_LichSuBaoHanh);
            this.groupBox1.Controls.Add(this.btn_AddNew);
            this.groupBox1.Location = new System.Drawing.Point(528, 412);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(767, 268);
            this.groupBox1.TabIndex = 137;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch sử bảo hành";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Location = new System.Drawing.Point(620, 102);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(139, 57);
            this.btn_Delete.TabIndex = 133;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dgv_LichSuBaoHanh
            // 
            this.dgv_LichSuBaoHanh.AllowUserToAddRows = false;
            this.dgv_LichSuBaoHanh.AllowUserToDeleteRows = false;
            this.dgv_LichSuBaoHanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LichSuBaoHanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LichSuBaoHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LichSuBaoHanh.Location = new System.Drawing.Point(19, 21);
            this.dgv_LichSuBaoHanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_LichSuBaoHanh.Name = "dgv_LichSuBaoHanh";
            this.dgv_LichSuBaoHanh.ReadOnly = true;
            this.dgv_LichSuBaoHanh.RowHeadersWidth = 51;
            this.dgv_LichSuBaoHanh.RowTemplate.Height = 29;
            this.dgv_LichSuBaoHanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LichSuBaoHanh.Size = new System.Drawing.Size(588, 229);
            this.dgv_LichSuBaoHanh.TabIndex = 130;
            this.dgv_LichSuBaoHanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LichSuBaoHanh_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lb_TenSP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lb_IDBaoHanh);
            this.groupBox2.Controls.Add(this.lb_Serial);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_IDNhanVien);
            this.groupBox2.Controls.Add(this.lb_STT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtp_NgayBaoHanh);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tb_GhiChuBaoHanh);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbb_TinhTrang);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.lb_HanBaoHanh);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(528, 55);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Size = new System.Drawing.Size(767, 353);
            this.groupBox2.TabIndex = 138;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bảo hành sản phẩm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(287, 16);
            this.label15.TabIndex = 161;
            this.label15.Text = "________________________________________";
            // 
            // lb_IDBaoHanh
            // 
            this.lb_IDBaoHanh.AutoSize = true;
            this.lb_IDBaoHanh.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.lb_IDBaoHanh.Location = new System.Drawing.Point(168, 22);
            this.lb_IDBaoHanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_IDBaoHanh.Name = "lb_IDBaoHanh";
            this.lb_IDBaoHanh.Size = new System.Drawing.Size(96, 27);
            this.lb_IDBaoHanh.TabIndex = 160;
            this.lb_IDBaoHanh.Text = "Không có";
            // 
            // lb_Serial
            // 
            this.lb_Serial.AutoSize = true;
            this.lb_Serial.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.lb_Serial.Location = new System.Drawing.Point(168, 54);
            this.lb_Serial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Serial.Name = "lb_Serial";
            this.lb_Serial.Size = new System.Drawing.Size(96, 27);
            this.lb_Serial.TabIndex = 159;
            this.lb_Serial.Text = "Không có";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(25, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 27);
            this.label9.TabIndex = 158;
            this.label9.Text = "Số serial:";
            // 
            // tb_IDNhanVien
            // 
            this.tb_IDNhanVien.Location = new System.Drawing.Point(176, 236);
            this.tb_IDNhanVien.Name = "tb_IDNhanVien";
            this.tb_IDNhanVien.Size = new System.Drawing.Size(172, 22);
            this.tb_IDNhanVien.TabIndex = 157;
            // 
            // lb_STT
            // 
            this.lb_STT.AutoSize = true;
            this.lb_STT.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.lb_STT.Location = new System.Drawing.Point(171, 162);
            this.lb_STT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_STT.Name = "lb_STT";
            this.lb_STT.Size = new System.Drawing.Size(23, 27);
            this.lb_STT.TabIndex = 155;
            this.lb_STT.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(25, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 27);
            this.label5.TabIndex = 154;
            this.label5.Text = "STT:";
            // 
            // dtp_NgayBaoHanh
            // 
            this.dtp_NgayBaoHanh.Location = new System.Drawing.Point(176, 203);
            this.dtp_NgayBaoHanh.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgayBaoHanh.Name = "dtp_NgayBaoHanh";
            this.dtp_NgayBaoHanh.Size = new System.Drawing.Size(172, 22);
            this.dtp_NgayBaoHanh.TabIndex = 153;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(363, 22);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 27);
            this.label14.TabIndex = 150;
            this.label14.Text = "Ghi chú bảo hành:";
            // 
            // tb_GhiChuBaoHanh
            // 
            this.tb_GhiChuBaoHanh.Location = new System.Drawing.Point(363, 55);
            this.tb_GhiChuBaoHanh.Margin = new System.Windows.Forms.Padding(4);
            this.tb_GhiChuBaoHanh.Multiline = true;
            this.tb_GhiChuBaoHanh.Name = "tb_GhiChuBaoHanh";
            this.tb_GhiChuBaoHanh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_GhiChuBaoHanh.Size = new System.Drawing.Size(396, 230);
            this.tb_GhiChuBaoHanh.TabIndex = 149;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(23, 232);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 27);
            this.label12.TabIndex = 147;
            this.label12.Text = "ID nhân viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(23, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 27);
            this.label8.TabIndex = 145;
            this.label8.Text = "Ngày bảo hành:";
            // 
            // cbb_TinhTrang
            // 
            this.cbb_TinhTrang.FormattingEnabled = true;
            this.cbb_TinhTrang.Items.AddRange(new object[] {
            "Yêu cầu bảo hành",
            "Đang thực hiện bảo hành",
            "Đang gửi đi NSX",
            "Đã hoàn thành",
            "Đã bàn giao cho khách"});
            this.cbb_TinhTrang.Location = new System.Drawing.Point(176, 269);
            this.cbb_TinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_TinhTrang.Name = "cbb_TinhTrang";
            this.cbb_TinhTrang.Size = new System.Drawing.Size(172, 24);
            this.cbb_TinhTrang.TabIndex = 144;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(23, 265);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 27);
            this.label11.TabIndex = 143;
            this.label11.Text = "Tình trạng:";
            // 
            // lb_HanBaoHanh
            // 
            this.lb_HanBaoHanh.AutoSize = true;
            this.lb_HanBaoHanh.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.lb_HanBaoHanh.Location = new System.Drawing.Point(168, 90);
            this.lb_HanBaoHanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_HanBaoHanh.Name = "lb_HanBaoHanh";
            this.lb_HanBaoHanh.Size = new System.Drawing.Size(118, 27);
            this.lb_HanBaoHanh.TabIndex = 142;
            this.lb_HanBaoHanh.Text = "00/00/0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(23, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 27);
            this.label6.TabIndex = 138;
            this.label6.Text = "Hạn bảo hành:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 27);
            this.label2.TabIndex = 135;
            this.label2.Text = "Mã bảo hành:";
            // 
            // dgv_DanhSachBaoHanh
            // 
            this.dgv_DanhSachBaoHanh.AllowUserToAddRows = false;
            this.dgv_DanhSachBaoHanh.AllowUserToDeleteRows = false;
            this.dgv_DanhSachBaoHanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachBaoHanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachBaoHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachBaoHanh.Location = new System.Drawing.Point(20, 108);
            this.dgv_DanhSachBaoHanh.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DanhSachBaoHanh.Name = "dgv_DanhSachBaoHanh";
            this.dgv_DanhSachBaoHanh.ReadOnly = true;
            this.dgv_DanhSachBaoHanh.RowHeadersWidth = 51;
            this.dgv_DanhSachBaoHanh.RowTemplate.Height = 25;
            this.dgv_DanhSachBaoHanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachBaoHanh.Size = new System.Drawing.Size(500, 296);
            this.dgv_DanhSachBaoHanh.TabIndex = 139;
            this.dgv_DanhSachBaoHanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachBaoHanh_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgv_DangBaoHanh);
            this.groupBox3.Location = new System.Drawing.Point(20, 412);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(500, 268);
            this.groupBox3.TabIndex = 140;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đang trong quá trình bảo hành";
            // 
            // dgv_DangBaoHanh
            // 
            this.dgv_DangBaoHanh.AllowUserToAddRows = false;
            this.dgv_DangBaoHanh.AllowUserToDeleteRows = false;
            this.dgv_DangBaoHanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DangBaoHanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DangBaoHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DangBaoHanh.Location = new System.Drawing.Point(19, 22);
            this.dgv_DangBaoHanh.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DangBaoHanh.Name = "dgv_DangBaoHanh";
            this.dgv_DangBaoHanh.ReadOnly = true;
            this.dgv_DangBaoHanh.RowHeadersWidth = 51;
            this.dgv_DangBaoHanh.RowTemplate.Height = 25;
            this.dgv_DangBaoHanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DangBaoHanh.Size = new System.Drawing.Size(464, 228);
            this.dgv_DangBaoHanh.TabIndex = 140;
            this.dgv_DangBaoHanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DangBaoHanh_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(25, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 162;
            this.label4.Text = "Tên SP:";
            // 
            // lb_TenSP
            // 
            this.lb_TenSP.AutoEllipsis = true;
            this.lb_TenSP.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.lb_TenSP.Location = new System.Drawing.Point(171, 119);
            this.lb_TenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TenSP.Name = "lb_TenSP";
            this.lb_TenSP.Size = new System.Drawing.Size(177, 27);
            this.lb_TenSP.TabIndex = 163;
            this.lb_TenSP.Text = "Không có";
            // 
            // UC_BaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgv_DanhSachBaoHanh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button16);
            this.Location = new System.Drawing.Point(32, 333);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "UC_BaoHanh";
            this.Size = new System.Drawing.Size(1316, 702);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichSuBaoHanh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachBaoHanh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DangBaoHanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label1;
        private Button btn_AddNew;
        private Button button16;
        private TextBox tb_Search;
        private Button btn_Save;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lb_HanBaoHanh;
        private Label label6;
        private Label label2;
        private DataGridView dgv_DanhSachBaoHanh;
        private Label label11;
        private ComboBox cbb_TinhTrang;
        private ContextMenuStrip contextMenuStrip1;
        private DateTimePicker dtp_NgayBaoHanh;
        private Label label14;
        private TextBox tb_GhiChuBaoHanh;
        private Label label12;
        private Label label8;
        private GroupBox groupBox3;
        private DataGridView dgv_DangBaoHanh;
        private Label lb_STT;
        private Label label5;
        private DataGridView dgv_LichSuBaoHanh;
        private Label lb_Serial;
        private Label label9;
        private TextBox tb_IDNhanVien;
        private Button btn_Delete;
        private Label label15;
        private Label lb_IDBaoHanh;
        private Label lb_TenSP;
        private Label label4;
    }
}
