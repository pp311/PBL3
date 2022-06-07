using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



using Do_An.BLL;
using Do_An.DTO;

namespace Do_An
{
    public partial class F_DangNhap : Form
    {
        public F_DangNhap()
        {
            InitializeComponent();
        }

       public void reSet()
        {
            tb_MatKhau.Text = "";
            tb_TaiKhoan.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            string tk = tb_TaiKhoan.Text;
            string mk = BLL_TaiKhoan.EncodePass(tb_MatKhau.Text);
            // string mk = tb_MatKhau.Text;
            bool isLoginSuccess = BLL_DangNhap.Instance.DangNhap(tk, mk);
            if (isLoginSuccess)
            {
                string s = CurrentUser.ViTri;
                if (s == "Quản lý")
                {
                    F_QuanLy f_admin = new F_QuanLy();
                    f_admin.Closed += (s, args) => this.Close();
                    this.Hide();
                    f_admin.Show();
                  //  f_admin.ShowDialog();
                    //this.Close();
                    
                   
                }
                if (s == "Nhân viên bán hàng")
                {
                    F_NhanVienBH f_NhanVienBH = new F_NhanVienBH();
                    f_NhanVienBH.Closed += (s, args) => this.Close();
                    f_NhanVienBH.Show();
                }
                if (s == "Nhân viên sửa chữa")
                {
                    F_NhanVienSC f_NhanVienSC = new F_NhanVienSC();
                    f_NhanVienSC.Closed += (s, args) => this.Close();
                    f_NhanVienSC.Show();

                }
            }
            else
            {
                if (tk == "" || mk == "") MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                else MessageBox.Show("Cần nhập đúng tên đăng nhập và mật khẩu");
            }
   

        }

        private void F_DangNhap_Load(object sender, EventArgs e)
        {
            tb_TaiKhoan.Focus();
        }
    }
}
