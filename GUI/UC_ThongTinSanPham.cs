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
    public partial class UC_ThongTinSanPham : UserControl
    {
        private static UC_ThongTinSanPham _instance;
        public static UC_ThongTinSanPham Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ThongTinSanPham();
                return _instance;
            }
        }
        public UC_ThongTinSanPham()
        {
            InitializeComponent();

            Show();
            cbb_Type.SelectedIndex = 0;

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

        private void button16_Click(object sender, EventArgs e)
        {
            Form_SanPham fsp = new Form_SanPham();
            fsp.loadTable = new Action(Show);
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
                MessageBox.Show("Vui lòng chọn đúng 1 sản phẩm để xem chi tiết");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_TableSanPham.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgv_TableSanPham.SelectedRows[0].Cells["ID_SanPham"].Value.ToString());
                Form_SanPham f = new Form_SanPham(id);
                f.loadTable = new Action(Show);
                f.Show();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng 1 sản phẩm để chỉnh sửa thông tin");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string msg;
            if (dgv_TableSanPham.SelectedRows.Count >= 1)
            {
                DialogResult dia = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dia == DialogResult.Yes)
                {
                    List<int> delList = new List<int>();
                    foreach (DataGridViewRow row in dgv_TableSanPham.SelectedRows)
                    {
                        delList.Add(Convert.ToInt32(row.Cells["ID_SanPham"].Value));
                    }
                    msg = BLL_SanPham.Instance.DeleteThongTinSanPham(delList);
                    MessageBox.Show(msg);
                    Show();
                }    
            }
            else
            {
                msg = "Vui lòng chọn ít nhất 1 sản phẩm để xoá!";
                MessageBox.Show(msg);
            }
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
