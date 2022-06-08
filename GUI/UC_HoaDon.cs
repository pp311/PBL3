
﻿using Do_An.BLL;
using Do_An.DTO;
using Do_An.GUI;
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
    public partial class UC_HoaDon : UserControl
    {

        public Action<string> loadTable { get; set; }
        private static UC_HoaDon _Instance;

        public static UC_HoaDon Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new UC_HoaDon();
                return _Instance;
            }
        }
        public UC_HoaDon()
        {
            InitializeComponent();
            tb_IdNhanVien.Enabled = false;
            EnableEdit(false);
            
            Show();
        }
        public void ResetGUI()
        {
            tb_IdNhanVien.Text = "";
            dtp_NgayTao.Value = DateTime.Now;
            tb_KhachHang.Text = "";
            tb_SoDienThoai.Text = "";
        }
        private HoaDon GetHoaDon()
        {
            HoaDon hd = new HoaDon();
            hd.NgayTao = Convert.ToDateTime(dtp_NgayTao);
            hd.TenKhachHang = tb_KhachHang.Text;
            hd.SoDienThoai = tb_SoDienThoai.Text;
            return hd;
        }
        public void Show()
        {

            dataGridView1.DataSource = BLL_HoaDon.Instance.GetAllHoaDon();
            dataGridView1.Columns["ID_HoaDon"].HeaderText = "ID Hóa đơn";
            dataGridView1.Columns[1].HeaderText = "ID Nhân viên";
            dataGridView1.Columns[2].HeaderText = "Ngày Tạo";
            dataGridView1.Columns[3].HeaderText = "Tên Khách Hàng";
            dataGridView1.Columns[4].HeaderText = "Số điện thoại";
            dataGridView1.Columns[5].HeaderText = "Tổng Tiền";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "N0";
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(tb_IdNhanVien.Text) != CurrentUser.ID_NhanVien && CurrentUser.ViTri != "Quản lý")
            {
                MessageBox.Show("Lỗi phân quyền: Không thể chỉnh sửa hóa đơn do nhân viên khác tạo nếu không phải là quản lý");
            }
            else if (Validate())
            {
                int IDHoaDon = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_HoaDon"].Value);
                HoaDon hd = BLL_HoaDon.Instance.GetHoaDonByID(IDHoaDon);
                hd.ID_HoaDon = IDHoaDon;
                hd.ID_NhanVien = Convert.ToInt32(tb_IdNhanVien.Text);
                hd.NgayTao = Convert.ToDateTime(dtp_NgayTao.Value);
                hd.TenKhachHang = tb_KhachHang.Text;
                hd.SoDienThoai = tb_SoDienThoai.Text;
                BLL_HoaDon.Instance.UpdateHoaDon(hd);
                dataGridView1.DataSource = BLL_HoaDon.Instance.GetAllHoaDon();
                MessageBox.Show("Bạn đã sửa thông tin hóa đơn thành công");

            }
                
        }
        private bool Validate()

        {
            string tenKhachHang = tb_KhachHang.Text;
            string soDienThoai = tb_SoDienThoai.Text;
            bool isValid = true;
            if (string.IsNullOrEmpty(tenKhachHang) || !tenKhachHang.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) isValid = false;
            if(string.IsNullOrEmpty(soDienThoai) || !soDienThoai.All(c => char.IsNumber(c))) isValid = false;

            if (!isValid)
            {
                isValid = false;
                MessageBox.Show("Bạn đã nhập thiếu hoặc sai thông tin , vui lòng nhập lại !!");
            }
            return isValid;

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                EnableEdit(true);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng 1 hàng để chỉnh sửa");
            } 
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_HoaDon"].Value.ToString());
                Form_HoaDon f = new Form_HoaDon(0, id );
                f.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng 1 hàng để xem chi tiết");
            }
        }
        private void EnableEdit(bool b)
        {
            tb_IdNhanVien.Enabled = b;
            dtp_NgayTao.Enabled = b;
            tb_KhachHang.Enabled = b;
            tb_SoDienThoai.Enabled = b;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            String IDNhanVien = dr.Cells["ID_NhanVien"].Value.ToString();
            //DateTime Ngaytao = Convert.ToDateTime(dr.Cells["NgayTao"]);
            int Tongtien = Convert.ToInt32(dr.Cells["TongTien"].Value.ToString());
            String TenKH = dr.Cells["TenKhachHang"].ToString();
            String SDT = dr.Cells["SoDienThoai"].ToString();
            tb_IdNhanVien.Text = IDNhanVien;
            //dtp_NgayTao.Value = Ngaytao;

            tb_KhachHang.Text = dr.Cells["TenKhachHang"].Value.ToString();
            tb_SoDienThoai.Text = dr.Cells["SoDienThoai"].Value.ToString();
            EnableEdit(false);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dia = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dia == DialogResult.Yes)
                {
                    List<string> list = new List<string>();
                    foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                    {
                        string id_nv = i.Cells["ID_NhanVien"].Value.ToString();
                        if (id_nv == CurrentUser.ID_NhanVien.ToString() || CurrentUser.ViTri == "Quản lý")
                        {
                            list.Add(i.Cells["ID_HoaDon"].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Lỗi phân quyền: Không thể xóa hóa đơn do nhân viên khác tạo nếu không phải là quản lý");
                            return;
                        }
                    }
                    string msg = BLL_HoaDon.Instance.DelHoaDon(list);
                    if (msg != "") MessageBox.Show(msg);
                    dataGridView1.DataSource = BLL_HoaDon.Instance.GetAllHoaDon();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 hóa đơn để xoá!");
            }

        }

        private void btn_AddThongTinBaoHanh_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                int idhd = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_HoaDon"].Value.ToString());
                Form_AddSanPhamBaoHanh f = new Form_AddSanPhamBaoHanh(idhd);
                f.Show();
            } 
        }
    }
}
