using Do_An.BLL;
using Do_An.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An.GUI
{
    public partial class Form_AddSanPhamBaoHanh : Form
    {
        int ID_HoaDon;
        public Form_AddSanPhamBaoHanh(int id)
        {
            InitializeComponent();
            ID_HoaDon = id;
            var l = BLL_HoaDon.Instance.GetDataTableAddThongTinBaoHanh(ID_HoaDon);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_BaoHanh", typeof(int));
            dt.Columns.Add("ID_LoHang", typeof(int));
            dt.Columns.Add("ID_SanPham", typeof(int));
            dt.Columns.Add("TenSanPham", typeof(String));
            dt.Columns.Add("Serial", typeof(String));
            dgv_Table.DataSource = l;
            foreach (DataGridViewRow r in dgv_Table.Rows)
            {
                dt.Rows.Add(
                    Convert.ToInt32(r.Cells["ID_BaoHanh"].Value.ToString()),
                    Convert.ToInt32(r.Cells["ID_LoHang"].Value.ToString()),
                    Convert.ToInt32(r.Cells["ID_SanPham"].Value.ToString()),
                    r.Cells["TenSanPham"].Value.ToString(),
                    r.Cells["Serial"].Value.ToString()
                );
            }
            dgv_Table.DataSource = null;
            dgv_Table.DataSource = dt;
            dgv_Table.Refresh();
            dgv_Table.Columns["ID_BaoHanh"].HeaderText = "ID bảo hành";
            dgv_Table.Columns["ID_LoHang"].HeaderText = "ID lô hàng";
            dgv_Table.Columns["ID_SanPham"].HeaderText = "ID sản phẩm";
            dgv_Table.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgv_Table.Columns["Serial"].HeaderText = "Serial";
            hoadon info = BLL_HoaDon.Instance.GetThongTinHoaDonByIDHoaDon(ID_HoaDon);
            lb_NgayTao.Text = info.NgayTao.ToString("dd/MM/yyyy");
            lb_TenNhanVien.Text = BLL_NhanVien.Instance.GetTenNhanVien(info.ID_NhanVien);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool allValid = true;
            List<thongtinbaohanh> data = new List<thongtinbaohanh>();
            foreach (DataGridViewRow r in dgv_Table.Rows)
            {
                if (r.Cells["Serial"].Value.ToString() != "")
                {
                    thongtinbaohanh ttbh = new thongtinbaohanh
                    {
                        ID_BaoHanh = Convert.ToInt32(r.Cells["ID_BaoHanh"].Value.ToString()),
                        ID_HoaDon = ID_HoaDon,
                        ID_SanPham = Convert.ToInt32(r.Cells["ID_SanPham"].Value.ToString()),
                        ID_LoHang = Convert.ToInt32(r.Cells["ID_LoHang"].Value.ToString()),
                        Serial = r.Cells["Serial"].Value.ToString()
                    };
                    data.Add(ttbh);
                }
                else allValid = false;
            }
            if(allValid)
            {
                var (isSuccess, msg) = BLL_HoaDon.Instance.SaveThongTinBaoHanh(data);
                MessageBox.Show(msg);
                if (isSuccess)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ mã serial của tất cả sản phẩm");
            }
        }
    }
}
