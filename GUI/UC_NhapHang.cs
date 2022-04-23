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
    public partial class UC_NhapHang : UserControl
    {
        private static UC_NhapHang _instance;
        public static UC_NhapHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_NhapHang();
                return _instance;
            }
        }
        public UC_NhapHang()
        {
            InitializeComponent();
            tb_IDSP.Enabled=false;
            EnableEdit(false);

        }

        private void btn_NhapSP_Click(object sender, EventArgs e)
        {
            Form_SanPham fsp = new Form_SanPham();
            fsp.Show();
        }

        private void btn_Lưu_Click(object sender, EventArgs e)
        {
           Validate();

        }
        private void Validate()
        {
            int soluongnhap =Convert.ToInt32(num_SoLuongNhap.Value);
            //string tensanpham = tb
            if(soluongnhap <=0)
            {
                MessageBox.Show("Bạn đã nhập thiếu hoặc sai thông tin , vui lòng nhập lại !!");
            }    
        }

        private void btn_SuaSP_Click(object sender, EventArgs e)
        {
            EnableEdit(true);
        }
        private void EnableEdit(bool b)
        {
            num_SoLuongNhap.Enabled = b;
            dtp_NgayNhap.Enabled=b;
            num_Gia.Enabled = b;
        }
    }
}
