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
<<<<<<< HEAD
=======
using Do_An.DAL_ST;
>>>>>>> 39bd742a88e038cf788aeeb430f6043d93765d80
using Do_An.DTO_AD;
using Do_An.BLL_AD;
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

       

        private void button1_Click(object sender, EventArgs e)
        {
           

            string tk = tb_TaiKhoan.Text;
            string mk = tb_MatKhau.Text;
            bool isLoginSuccess = BLL_DangNhap.Instance.DangNhap(tk, mk);
            if (isLoginSuccess)
            {
                string s = CurrentUser.ViTri;
                if (s == "Quản lý")
                {
                    F_QuanLy f_admin = new F_QuanLy();
                    f_admin.Closed += (s, args) => this.Close();
                    f_admin.Show();
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
                else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
   

        }

        private void F_DangNhap_Load(object sender, EventArgs e)
        {
            tb_TaiKhoan.Focus();
        }
    }
}
