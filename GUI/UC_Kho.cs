using Do_An.BLL;
using Do_An.DTO;
using Do_An.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An
{
    public partial class UC_Kho : UserControl
    {
        private static UC_Kho _instance;
        public static UC_Kho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Kho();
                return _instance;
            }
        }
        public UC_Kho()
        {
            InitializeComponent();
            foreach (DataGridViewColumn column in dgv_TableSanPham.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            Show();

        }

        private void Show(string search = "")
        {
            PBLEntities db = new PBLEntities();
            var l = db.sanphams.Select(p => p).ToList();
            dgv_TableSanPham.DataSource = l;
            //dgv_TableSanPham.DataSource = BLL_SanPham.Instance.GetDataTableSanPham();
            dgv_TableSanPham.Columns["ID_SanPham"].HeaderText = "ID Sản phẩm";
            dgv_TableSanPham.Columns["Ten"].HeaderText = "Tên Sản phẩm";
            dgv_TableSanPham.Columns["PhanLoai"].HeaderText = "Phân loại";
            dgv_TableSanPham.Columns["GiaBan"].HeaderText = "Giá bán";
            dgv_TableSanPham.Columns["GiamGia"].HeaderText = "% giảm giá";
            //dgv_TableSanPham.Columns["SoLuong"].HeaderText = "Số lượng";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form_SanPham fsp = new Form_SanPham();
            fsp.loadTable = new Action<string>(Show);
            fsp.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (dgv_TableSanPham.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgv_TableSanPham.SelectedRows[0].Cells["ID_SanPham"].Value.ToString());
                Form_SanPham f = new Form_SanPham(id, 0);
                f.Show();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng 1 hàng để xem chi tiết");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_TableSanPham.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgv_TableSanPham.SelectedRows[0].Cells["ID_SanPham"].Value.ToString());
                Form_SanPham f = new Form_SanPham(id);
                f.loadTable = new Action<string>(Show);
                f.Show();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng 1 hàng để chỉnh sửa thông tin");
            }
        }
    }
}
