namespace Do_An
{
    partial class UC_ThongTinSanPham
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
            this.dgv_TableSanPham = new System.Windows.Forms.DataGridView();
            this.btn_Detail = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cbb_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TableSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(429, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 41);
            this.label3.TabIndex = 97;
            this.label3.Text = "Quản lí thông tin sản phẩm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_TableSanPham
            // 
            this.dgv_TableSanPham.AllowUserToAddRows = false;
            this.dgv_TableSanPham.AllowUserToDeleteRows = false;
            this.dgv_TableSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TableSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TableSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TableSanPham.Location = new System.Drawing.Point(32, 266);
            this.dgv_TableSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TableSanPham.Name = "dgv_TableSanPham";
            this.dgv_TableSanPham.ReadOnly = true;
            this.dgv_TableSanPham.RowHeadersWidth = 51;
            this.dgv_TableSanPham.RowTemplate.Height = 29;
            this.dgv_TableSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TableSanPham.Size = new System.Drawing.Size(1051, 420);
            this.dgv_TableSanPham.TabIndex = 101;
            // 
            // btn_Detail
            // 
            this.btn_Detail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Detail.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Detail.FlatAppearance.BorderSize = 0;
            this.btn_Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Detail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Detail.Location = new System.Drawing.Point(1123, 508);
            this.btn_Detail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(149, 54);
            this.btn_Detail.TabIndex = 105;
            this.btn_Detail.Text = "Xem chi tiết";
            this.btn_Detail.UseVisualStyleBackColor = false;
            this.btn_Detail.Click += new System.EventHandler(this.button20_Click);
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
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(149, 57);
            this.btn_Delete.TabIndex = 104;
            this.btn_Delete.Text = "Xóa thông tin sản phẩm";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Edit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.Location = new System.Drawing.Point(1123, 345);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(149, 57);
            this.btn_Edit.TabIndex = 103;
            this.btn_Edit.Text = "Chỉnh sửa thông tin SP";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Add.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Location = new System.Drawing.Point(1123, 266);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(149, 57);
            this.btn_Add.TabIndex = 102;
            this.btn_Add.Text = "Thêm thông tin SP";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.button16_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.tb_Search.Location = new System.Drawing.Point(755, 183);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(229, 34);
            this.tb_Search.TabIndex = 118;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(987, 183);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(93, 34);
            this.btn_Search.TabIndex = 119;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cbb_Type
            // 
            this.cbb_Type.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.cbb_Type.FormattingEnabled = true;
            this.cbb_Type.Items.AddRange(new object[] {
            "Tất cả",
            "Xe đạp",
            "Phụ kiện",
            "Phụ tùng xe"});
            this.cbb_Type.Location = new System.Drawing.Point(160, 186);
            this.cbb_Type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_Type.Name = "cbb_Type";
            this.cbb_Type.Size = new System.Drawing.Size(191, 34);
            this.cbb_Type.TabIndex = 141;
            this.cbb_Type.SelectedIndexChanged += new System.EventHandler(this.cbb_Type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(59, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 140;
            this.label1.Text = "Phân loại";
            // 
            // UC_ThongTinSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbb_Type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.btn_Detail);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_TableSanPham);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_ThongTinSanPham";
            this.Size = new System.Drawing.Size(1315, 702);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TableSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private DataGridView dgv_TableSanPham;
        private Button btn_Detail;
        private Button btn_Delete;
        private Button btn_Edit;
        private Button btn_Add;
        private TextBox tb_Search;
        private Button btn_Search;
        private ComboBox cbb_Type;
        private Label label1;
    }
}
