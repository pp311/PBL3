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
    public partial class UC_NhanVien : UserControl
    {
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

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Validate();
     
    }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            EnableEdit(true);
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
        private void Validate()
        {
            string tenNhanVien = tb_TenNhanVien.Text;
            string soDienThoai = tb_SoDienThoai.Text;
            string diaChi = tb_DiaChi.Text;
            string taiKhoan = tb_TaiKhoan.Text;
            bool isValid = true;
            if (string.IsNullOrEmpty(tenNhanVien) || !tenNhanVien.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) isValid = false;
            if (string.IsNullOrEmpty(soDienThoai) || !soDienThoai.All(c => char.IsNumber(c))) isValid = false;
            if (string.IsNullOrEmpty(diaChi) || !diaChi.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))) isValid = false;
            if(!rb_Nam.Checked && !rb_Nu.Checked) isValid = false;
            //if(cbb_ViTri.SelectedItem == null) isValid = false;
            if(string.IsNullOrEmpty(taiKhoan)) isValid = false;
            if (!isValid) MessageBox.Show("Bạn đã nhập thiếu hoặc sai thông tin , vui lòng nhập lại !!");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            EnableEdit(true);
        }
    }
}
