﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An.DTO_AD;
using Do_An.BLL_AD;

namespace Do_An
{
    public partial class UC_NhanVien : UserControl
    {
        public Action<string> loadTable { get; set; }
        private static UC_NhanVien _instance;
        public static UC_NhanVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_NhanVien();
                return _instance;
            }
        }
        public UC_NhanVien()
        {
            InitializeComponent();
            tb_IdNhanVien.Enabled = false;
            EnableEdit(false);
            cbb_ViTri.Items.Add("Quản lý");
            cbb_ViTri.Items.Add("Nhân viên bán hàng");
            cbb_ViTri.Items.Add("Nhân viên sửa chữa");
            show("");
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        public void ResetGUI()
        {
            tb_IdNhanVien.Text = "";
            tb_TenNhanVien.Text = "";
            tb_DiaChi.Text = "";
           // dtp_NgaySinh.Value = DateTime.Now;
            rb_Nam.Checked = false;
            rb_Nu.Checked = false;
            cbb_ViTri.Text = "";
            tb_SoDienThoai.Text = "";
            tb_TaiKhoan.Text = "";

        }
        private NhanVien GetNhanVien() // laays nhan vien da nhap ra 
        {
            NhanVien nv = new NhanVien();
            nv.TenNhanVien = tb_TenNhanVien.Text;
            nv.DiaChi = tb_DiaChi.Text;
            nv.SoDienThoai = tb_SoDienThoai.Text;
            nv.ViTri = cbb_ViTri.Text;
            nv.NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Value);
            if (rb_Nam.Checked == true)
            {
                nv.GioiTinh = "Nam";
            }
            else
            {
                nv.GioiTinh = "Nữ";
            }
            nv.TaiKhoan = tb_TaiKhoan.Text;

            return nv;
        }

        private TaiKhoan GetTaiKhoan()
        {
            TaiKhoan tk = new TaiKhoan();
            tk.TenTaiKhoan = tb_TaiKhoan.Text;
            return tk;

        }
        public void show(string txt)
        {

            dtlv_nv.DataSource = BLL_NhanVien.Instance.GetAllNhanVien();
            dtlv_nv.Columns[0].HeaderText = "ID_NhanVien";
            dtlv_nv.Columns[1].HeaderText = "ID_TaiKhoan";
            dtlv_nv.Columns[2].HeaderText = "TenNhanVien";
            dtlv_nv.Columns[3].HeaderText = "NgaySinh";
            dtlv_nv.Columns[4].HeaderText = "GioiTinh";
            dtlv_nv.Columns[5].HeaderText = "ViTri";
            dtlv_nv.Columns[6].HeaderText = "SoDienThoai";
            dtlv_nv.Columns[7].HeaderText = "DiaChi";
            dtlv_nv.Columns[8].HeaderText = "TaiKhoan";
            //dataGridView1.Columns[0].HeaderText = "ID_NhanVien";
        }
        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_IdNhanVien.Text == "")
            {
                if (Validate())
                {
                    string s = tb_TaiKhoan.Text;
                    NhanVien nv = new NhanVien();
                    nv.TenNhanVien = tb_TenNhanVien.Text;
                    nv.DiaChi = tb_DiaChi.Text;
                    nv.SoDienThoai = tb_SoDienThoai.Text;
                    nv.ViTri = cbb_ViTri.Text;
                    nv.NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Value);
                    if (rb_Nam.Checked == true)
                    {
                        nv.GioiTinh = "Nam";
                    }
                    else
                    {
                        nv.GioiTinh = "Nữ";
                    }
                   
                    SetPass f1 = new SetPass(s, nv.TenNhanVien, nv.DiaChi, nv.SoDienThoai, nv.ViTri, nv.NgaySinh, nv.GioiTinh);
                
                    f1.Show();
                    f1.load = new Action<string>(show);
                    ResetGUI();
                    EnableEdit(false);
                }

            }
            else
            {

                // chỉnh sửa thông tin nhân viên 
                int idnv = Convert.ToInt32(dtlv_nv.SelectedRows[0].Cells["ID_Nhanvien"].Value);
                NhanVien nv = BLL_NhanVien.Instance.BLL_GetNhanVienByID(idnv);
                //   NhanVien nv = BLL_NhanVien.Instance.
                nv.ID_NhanVien = idnv;
                nv.TenNhanVien = tb_TenNhanVien.Text;
                nv.DiaChi = tb_DiaChi.Text;
                nv.SoDienThoai = tb_SoDienThoai.Text;
                nv.ViTri = cbb_ViTri.Text;
                nv.NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Value);
                if (rb_Nam.Checked == true)
                {
                    nv.GioiTinh = "Nam";
                }
                else
                {
                    nv.GioiTinh = "Nữ";
                }
                BLL_NhanVien.Instance.Update(nv);
                //  BLL_NhanVien.Instance.Update(GetNhanVien1());
                dtlv_nv.DataSource = BLL_NhanVien.Instance.GetAllNhanVien();
                // show("");
                MessageBox.Show("Bạn đã sửa thông tin nhân viên này thành công !!! ");
            }
            }
        
  
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            EnableEdit(true);
            tb_TaiKhoan.Enabled = false;
            if (dtlv_nv.SelectedRows.Count == 1)
            {
                //  int idnv = conv
                // TaiKhoan tk = BLL_NhanVien.Instance.
                int idnv = Convert.ToInt32(dtlv_nv.SelectedRows[0].Cells["ID_Nhanvien"].Value);
                int idtk = Convert.ToInt32(dtlv_nv.SelectedRows[0].Cells["ID_TaiKhoan"].Value);
                NhanVien nv = BLL_NhanVien.Instance.BLL_GetNhanVienByID(idnv);
                TaiKhoan tk = BLL_TaiKhoan.Instance.BLL_GetTaiKhoanByID(idtk);
                GUI_Edit(nv, tk);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để chỉnh sửa thông tin !!! ");

            } 
                
           
        }
        public void GUI_Edit(NhanVien nv, TaiKhoan tk) // hieenj thong tin len bang 
        {
            tb_IdNhanVien.Text = Convert.ToString(nv.ID_NhanVien);
            tb_SoDienThoai.Text = nv.SoDienThoai;
            tb_DiaChi.Text = nv.DiaChi;
            tb_TenNhanVien.Text = nv.TenNhanVien;
            cbb_ViTri.SelectedItem = nv.ViTri;
            dtp_NgaySinh.Value = nv.NgaySinh;
            if (nv.GioiTinh == "Nam")
            {
                rb_Nam.Checked = true;
            }
            else
            {
                rb_Nu.Checked = true;
            }
            tb_TaiKhoan.Text = tk.TenTaiKhoan;
        }
       
        private void EnableEdit(bool b)
        {
            tb_TenNhanVien.Enabled = b;
            tb_SoDienThoai.Enabled = b;
            tb_DiaChi.Enabled = b;
            rb_Nam.Enabled = b;
            rb_Nu.Enabled = b;
            cbb_ViTri.Enabled = b;
            dtp_NgaySinh.Enabled = b;
            tb_TaiKhoan.Enabled = b;
        }
        private bool Validate()
        {

            string tenNhanVien = tb_TenNhanVien.Text;
            string soDienThoai = tb_SoDienThoai.Text;
            string diaChi = tb_DiaChi.Text;
            string taiKhoan = tb_TaiKhoan.Text;
            bool isValid = true;
            if (string.IsNullOrEmpty(tenNhanVien) || !tenNhanVien.All(c => char.IsLetter(c))) isValid = false;
            if (string.IsNullOrEmpty(soDienThoai) || !soDienThoai.All(c => char.IsNumber(c))) isValid = false;
            if (string.IsNullOrEmpty(diaChi) || !diaChi.All(c => char.IsLetterOrDigit(c))) isValid = false;
            if(!rb_Nam.Checked && !rb_Nu.Checked) isValid = false;
            //if(cbb_ViTri.SelectedItem == null) isValid = false;
            if (string.IsNullOrEmpty(taiKhoan)) isValid = false;
            if (string.IsNullOrEmpty(diaChi)) isValid = false;
            if (tenNhanVien=="") isValid = false;
            if (!isValid)
            {
                isValid = false;
                MessageBox.Show("Bạn đã nhập thiếu hoặc sai thông tin , vui lòng nhập lại !!");
            }
            return isValid;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            EnableEdit(true);
            ResetGUI();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không ?", "xác nhận xóa", MessageBoxButtons.YesNo);

            if (dia == DialogResult.Yes)
            {
                if (dtlv_nv.SelectedRows.Count > 0)
                {
                    List<string> list = new List<string>();
                    foreach (DataGridViewRow i in dtlv_nv.SelectedRows)
                    {
                        list.Add(i.Cells["ID_NhanVien"].Value.ToString());

                    }
                    BLL_NhanVien.Instance.DelNhanVien(list);
                    dtlv_nv.DataSource = BLL_NhanVien.Instance.GetAllNhanVien();
                }
            }
            EnableEdit(false);
        }

        private void btn_ResetPassword_Click(object sender, EventArgs e)
        {
            if (dtlv_nv.SelectedRows.Count == 1)
            {
                int idtk = Convert.ToInt32(dtlv_nv.SelectedRows[0].Cells["ID_TaiKhoan"].Value);
                TaiKhoan tk = BLL_TaiKhoan.Instance.BLL_GetTaiKhoanByID(idtk);
                string mktk = tk.MatKhau;
                // truyền idtk với mk tk 
                Pass p1 = new Pass(idtk, mktk);
                p1.d = new Pass.MyDel(show);
                p1.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để đổi mật khẩu !!! ");
            }
        }

        private void dtlv_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_SoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_Nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_Nu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtp_NgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbb_ViTri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_TenNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_IdNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            BLL_NhanVien.Instance.GetAllNhanVien();
        }
    }
}
