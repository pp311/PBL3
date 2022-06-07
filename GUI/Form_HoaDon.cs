
﻿using Do_An.BLL;
using Do_An.DTO;
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

namespace Do_An
{
    public partial class Form_HoaDon : Form
    {
        public Action loadTable { get; set; }
        public DataTable dt;
        decimal TongTien;
        //mode 1: add, mode 0: view
        public Form_HoaDon(int mode, int ID_HoaDon, DataTable danhSachMuaHang = null)
        {
            InitializeComponent();
            tb_IDHoaDon.Enabled = false;
            if (ID_HoaDon != 0)
            {
                dt = BLL_HoaDon.Instance.GetDataTableChiTietHoaDonByIDHoaDon(ID_HoaDon);
                tb_IDHoaDon.Text = ID_HoaDon.ToString();
                hoadon hd = BLL_HoaDon.Instance.GetThongTinHoaDonByIDHoaDon(ID_HoaDon);
                tb_TenKhachHang.Text = hd.TenKhachHang;
                tb_SoDienThoai.Text = hd.SoDienThoai;
            }
            else
            {
                dt = danhSachMuaHang;
            }
            dgv_Table.DataSource = dt;
            dgv_Table.Columns["ID_LoHang"].HeaderText = "ID lô hàng";
            dgv_Table.Columns["ID_SanPham"].HeaderText = "ID sản phẩm";
            dgv_Table.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgv_Table.Columns["SoLuongMua"].HeaderText = "Số lượng mua";
            dgv_Table.Columns["SoLuongMua"].DefaultCellStyle.Format = "N0";
            dgv_Table.Columns["GiamGia"].HeaderText = "% Giảm giá";
            dgv_Table.Columns["DonGia"].HeaderText = "Đơn giá";
            dgv_Table.Columns["DonGia"].DefaultCellStyle.Format = "N0";

            GUI(mode);
        }
        private void GUI(int mode)
        {
            TongTien = 0;
            
            if(mode == 0)
            {
                btn_XacNhan.Visible = false;
                btn_Huy.Text = "Tắt";
                btn_Huy.Location = new Point(553, 719);
                tb_SoDienThoai.Enabled = false;
                tb_TenKhachHang.Enabled = false;
                dtp_NgayTao.Enabled = false;
            }
            foreach (DataRow dr in dt.Rows)
            {
                TongTien += Convert.ToInt32(dr["DonGia"].ToString()) * Convert.ToInt32(dr["SoLuongMua"].ToString());
            }
            lb_TongTien.Text = TongTien.ToString("N0") + " VND";
            
           
        }

        private bool Validate()
        {

            string tenKhachHang = tb_TenKhachHang.Text;
            string soDienThoai = tb_SoDienThoai.Text;
            bool isValid = true;
            if (!tenKhachHang.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) isValid = false;
            if (!soDienThoai.All(c => char.IsNumber(c))) isValid = false;
            if (!isValid)
            {
                isValid = false;
                MessageBox.Show("Thông tin bạn nhập không hợp lệ, vui lòng nhập lại !!");
            }
            return isValid;

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_HoaDon_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 10), this.DisplayRectangle);

        }


        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
                hoadon data = new hoadon
                {
                    ID_NhanVien = CurrentUser.ID_NhanVien,
                    NgayTao = dtp_NgayTao.Value,
                    TenKhachHang = tb_TenKhachHang.Text,
                    SoDienThoai = tb_SoDienThoai.Text,
                    TongTien = (int)TongTien,
                };
                BLL_BanHang.Instance.AddHoaDon(dt, data);
                MessageBox.Show("Tạo hóa đơn thành công");
                loadTable();
                this.Close();
            }
        }

    }
}
