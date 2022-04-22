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
        public UC_HoaDon()
        {
            InitializeComponent();
            tb_IdHoaDon.Enabled = false;
            dtp_NgayTao.Enabled = false;
            num_TongTien.Enabled = false;
            tb_KhachHang.Enabled = false;
            tb_SoDienThoai.Enabled = false;
        }
        private static UC_HoaDon _instance;
        public static UC_HoaDon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_HoaDon();
                return _instance;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Validate();
        }
        private void Validate()
        {
            string tenKhachHang = tb_KhachHang.Text;
            string soDienThoai = tb_SoDienThoai.Text;
            bool isValid = true;
            if (string.IsNullOrEmpty(tenKhachHang) || !tenKhachHang.All(c => char.IsLetter(c))) isValid = false;
            if(string.IsNullOrEmpty(soDienThoai) || !soDienThoai.All(c => char.IsNumber(c))) isValid = false;
            if (!isValid) MessageBox.Show("Bạn đã nhập thiếu hoặc sai thông tin , vui lòng nhập lại !!");
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            dtp_NgayTao.Enabled = true;
            tb_KhachHang.Enabled = true;
            tb_SoDienThoai.Enabled = true;
        }
    }
}
