using Do_An.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An
{
    public partial class UC_SanPham : UserControl
    {
        private static UC_SanPham _instance;
        public static UC_SanPham Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_SanPham();
                return _instance;
            }
        }
        public UC_SanPham()
        {
            InitializeComponent();
            Show();
            cbb_Type.SelectedIndex = 0;
        }

        private void btn_XemCT_Click(object sender, EventArgs e)
        {
            if (dgv_TableSanPham.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgv_TableSanPham.SelectedRows[0].Cells["ID_SanPham"].Value.ToString());
                Form_SanPham f = new Form_SanPham(id, 0);
                f.Show();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng 1 sản phẩm để xem chi tiết");
            }
        }

        public void Show()
        {
            dgv_TableSanPham.DataSource = BLL_SanPham.Instance.GetDataTableSanPham();
            dgv_TableSanPham.Columns["ID_SanPham"].HeaderText = "ID Sản phẩm";
            dgv_TableSanPham.Columns["Ten"].HeaderText = "Tên Sản phẩm";
            dgv_TableSanPham.Columns["PhanLoai"].HeaderText = "Phân loại";
            dgv_TableSanPham.Columns["GiaBan"].HeaderText = "Giá bán";
            dgv_TableSanPham.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
        }

        private void cbb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cbb_Type.SelectedItem.ToString();
            DataTable dt = BLL_SanPham.Instance.GetDataTableSanPhamByType(type);
            dgv_TableSanPham.DataSource = dt;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string type = cbb_Type.SelectedItem.ToString();
            string keyWord = tb_Search.Text;
            dgv_TableSanPham.DataSource = BLL_SanPham.Instance.GetDataTableSanPhamByKeyWord(type, keyWord);
        }
    }
}
