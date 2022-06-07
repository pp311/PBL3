
﻿using Do_An.BLL;
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
    public partial class UC_BanHang : UserControl
    {
        DataTable danhSachMuaHang;
        public UC_BanHang()
        {
            InitializeComponent();
            Show();
            cbb_Type.SelectedIndex = 0;
        }
        private static UC_BanHang _instance;
        public static UC_BanHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_BanHang();
                return _instance;
            }
        }

        private void btn_LapHD_Click(object sender, EventArgs e)
        {
            if(dgv_DanhSachMua.Rows.Count > 0)
            {
                Form_HoaDon fhd = new Form_HoaDon(1, 0, danhSachMuaHang);
                fhd.loadTable = new Action(Show);
                fhd.Show();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 sản phẩm");
            }
        }
        public void Show()
        {
            danhSachMuaHang = new DataTable();
            danhSachMuaHang.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName = "ID_LoHang", DataType = typeof(int)},
                new DataColumn {ColumnName = "ID_SanPham", DataType = typeof(int)},
                new DataColumn {ColumnName = "TenSanPham", DataType = typeof(string)},
                new DataColumn {ColumnName = "SoLuongMua", DataType = typeof(int)},
                new DataColumn {ColumnName = "GiamGia", DataType = typeof(int)},
                new DataColumn {ColumnName = "DonGia", DataType = typeof(int)},
            });
            dgv_DanhSachMua.DataSource = danhSachMuaHang;
            dgv_DanhSachMua.Columns["ID_LoHang"].HeaderText = "ID lô hàng";
            dgv_DanhSachMua.Columns["ID_SanPham"].HeaderText = "ID sản phẩm";
            dgv_DanhSachMua.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgv_DanhSachMua.Columns["SoLuongMua"].HeaderText = "Số lượng mua";
            dgv_DanhSachMua.Columns["SoLuongMua"].DefaultCellStyle.Format = "N0";
            dgv_DanhSachMua.Columns["GiamGia"].HeaderText = "% giảm giá";
            dgv_DanhSachMua.Columns["DonGia"].HeaderText = "Đơn giá";
            dgv_DanhSachMua.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dgv_SanPham.DataSource = BLL_BanHang.Instance.GetDataTableBanHang();
            dgv_SanPham.Columns["ID_LoHang"].HeaderText = "ID lô hàng";
            dgv_SanPham.Columns["ID_SanPham"].HeaderText = "ID sản phẩm";
            dgv_SanPham.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgv_SanPham.Columns["PhanLoai"].HeaderText = "Phân loại";
            dgv_SanPham.Columns["NgayNhap"].HeaderText = "Ngày nhập";
            dgv_SanPham.Columns["SoLuongNhap"].HeaderText = "Số lượng nhập";
            dgv_SanPham.Columns["SoLuongNhap"].DefaultCellStyle.Format = "N0";
            dgv_SanPham.Columns["SoLuong"].HeaderText = "Số lượng còn";
            dgv_SanPham.Columns["GiamGia"].HeaderText = "% giảm giá";
            dgv_SanPham.Columns["GiaBanGoc"].HeaderText = "Giá bán gốc";
            dgv_SanPham.Columns["GiaBanGoc"].DefaultCellStyle.Format = "N0";
            dgv_SanPham.Columns["GiaKhuyenMai"].HeaderText = "Giá khuyến mãi";
            dgv_SanPham.Columns["GiaKhuyenMai"].DefaultCellStyle.Format = "N0";
        }



        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgv_SanPham.SelectedRows[0];
            tb_IDLoHang.Text = dr.Cells["ID_LoHang"].Value.ToString();
            tb_IDSanPham.Text = dr.Cells["ID_SanPham"].Value.ToString();
            tb_TenSanPham.Text = dr.Cells["TenSanPham"].Value.ToString();
            num_SoLuongMua.Maximum = Convert.ToInt32(dr.Cells["SoLuong"].Value.ToString());
            num_SoLuongMua.Value = num_SoLuongMua.Maximum > 0 ? num_SoLuongMua.Minimum : 0;
        }
        private void dgv_DanhSachMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgv_DanhSachMua.SelectedRows[0];
            tb_IDLoHang.Text = dr.Cells["ID_LoHang"].Value.ToString();
            tb_IDSanPham.Text = dr.Cells["ID_SanPham"].Value.ToString();
            tb_TenSanPham.Text = dr.Cells["TenSanPham"].Value.ToString();
            foreach (DataGridViewRow d in dgv_SanPham.Rows)
            {
                if (dr.Cells["ID_LoHang"].Value.ToString() == d.Cells["ID_LoHang"].Value.ToString())
                {
                    num_SoLuongMua.Maximum = Convert.ToInt32(d.Cells["SoLuong"].Value.ToString());
                }
            }
            num_SoLuongMua.Value = Convert.ToInt32(dr.Cells["SoLuongMua"].Value.ToString());
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if( num_SoLuongMua.Value <= num_SoLuongMua.Maximum && num_SoLuongMua.Value > 0)
            {
                DataGridViewRow dr = dgv_SanPham.SelectedRows[0];
                foreach(DataRow d in danhSachMuaHang.Rows)
                {
                    if(Convert.ToInt32(tb_IDLoHang.Text) == Convert.ToInt32(d["ID_LoHang"].ToString()))
                    {
                        d["SoLuongMua"] = (int)num_SoLuongMua.Value;
                        return;
                    }
                }
                danhSachMuaHang.Rows.Add(
                    Convert.ToInt32(dr.Cells["ID_LoHang"].Value.ToString()),
                    Convert.ToInt32(dr.Cells["ID_SanPham"].Value.ToString()),
                    dr.Cells["TenSanPham"].Value.ToString(),
                    (int)num_SoLuongMua.Value,
                    Convert.ToInt32(dr.Cells["GiamGia"].Value.ToString()),
                    Convert.ToInt32(dr.Cells["GiaKhuyenMai"].Value.ToString())
                    );

            }
            else
            {
                MessageBox.Show("Cần nhập số lượng mua hợp lệ");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(dgv_DanhSachMua.SelectedRows.Count == 1 )
            {
                DataGridViewRow dr = dgv_DanhSachMua.SelectedRows[0];
                string idlh = dr.Cells["ID_LoHang"].Value.ToString();
                foreach(DataRow d in danhSachMuaHang.Rows)
                {
                    if(d["ID_LoHang"].ToString() == idlh)
                    {
                        danhSachMuaHang.Rows.Remove(d);
                        danhSachMuaHang.AcceptChanges();
                        break;
                    }
                }
                dgv_DanhSachMua.DataSource = danhSachMuaHang;
            }
        }

        private void cbb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cbb_Type.SelectedItem.ToString();
            DataTable dt = BLL_BanHang.Instance.GetDataTableBanHangByType(type);
            dgv_SanPham.DataSource = dt;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string type = cbb_Type.SelectedItem.ToString();
            string keyWord = tb_Search.Text;
            dgv_SanPham.DataSource = BLL_BanHang.Instance.GetDataTableBanHangByKeyWord(type, keyWord);
        }
    }
}
