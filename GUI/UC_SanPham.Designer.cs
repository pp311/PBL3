namespace Do_An
{
    partial class UC_SanPham
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_XemCT = new System.Windows.Forms.Button();
            this.dgv_TableSanPham = new System.Windows.Forms.DataGridView();
            this.cbb_Type = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TableSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(490, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 41);
            this.label3.TabIndex = 129;
            this.label3.Text = "Danh sách sản phẩm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(997, 193);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(93, 33);
            this.btn_Search.TabIndex = 138;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.tb_Search.Location = new System.Drawing.Point(762, 193);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(229, 33);
            this.tb_Search.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(48, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 27);
            this.label2.TabIndex = 135;
            this.label2.Text = "Phân loại";
            // 
            // btn_XemCT
            // 
            this.btn_XemCT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_XemCT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_XemCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_XemCT.FlatAppearance.BorderSize = 0;
            this.btn_XemCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XemCT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_XemCT.Location = new System.Drawing.Point(1134, 282);
            this.btn_XemCT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XemCT.Name = "btn_XemCT";
            this.btn_XemCT.Size = new System.Drawing.Size(149, 54);
            this.btn_XemCT.TabIndex = 134;
            this.btn_XemCT.Text = "Xem chi tiết";
            this.btn_XemCT.UseVisualStyleBackColor = false;
            this.btn_XemCT.Click += new System.EventHandler(this.btn_XemCT_Click);
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
            this.dgv_TableSanPham.Location = new System.Drawing.Point(29, 276);
            this.dgv_TableSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_TableSanPham.Name = "dgv_TableSanPham";
            this.dgv_TableSanPham.ReadOnly = true;
            this.dgv_TableSanPham.RowHeadersWidth = 51;
            this.dgv_TableSanPham.RowTemplate.Height = 29;
            this.dgv_TableSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TableSanPham.Size = new System.Drawing.Size(1061, 404);
            this.dgv_TableSanPham.TabIndex = 130;
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
            this.cbb_Type.Location = new System.Drawing.Point(150, 190);
            this.cbb_Type.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_Type.Name = "cbb_Type";
            this.cbb_Type.Size = new System.Drawing.Size(191, 34);
            this.cbb_Type.TabIndex = 139;
            this.cbb_Type.SelectedIndexChanged += new System.EventHandler(this.cbb_Type_SelectedIndexChanged);
            // 
            // UC_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbb_Type);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_XemCT);
            this.Controls.Add(this.dgv_TableSanPham);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_SanPham";
            this.Size = new System.Drawing.Size(1315, 702);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TableSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Button btn_Search;
        private TextBox tb_Search;
        private Label label2;
        private Button btn_XemCT;
        private DataGridView dgv_TableSanPham;
        private ComboBox cbb_Type;
    }
}
