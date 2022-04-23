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
using Do_An.DAL_ST;

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
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HK4MB89\SQLEXPRESS;Initial Catalog=PBL;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = tB_taikhoan.Text;
                string mk = tB_matkhau.Text;
                string sql1 = "select Vitri from nhanvien inner join taikhoan on nhanvien.ID_TaiKhoan = taikhoan.ID_TaiKhoan where taikhoan.TenTaiKhoan = '" + tk + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                string s = (string)cmd1.ExecuteScalar();

                string sql = "select * from taikhoan where TenTaiKhoan = '" + tk + "' and MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dtr = cmd.ExecuteReader();

                
                if (dtr.Read() == true)
                {
                    if (s == "Quản lý")
                    {
                        F_QuanLy f_admin = new F_QuanLy();
                        f_admin.Closed += (s, args) => this.Close();
                        f_admin.Show();
                    }
                    if (s == "Nhân viên bán hàng")
                    {
                        F_NhanVienBH f_NhanVienBH = new F_NhanVienBH();
                        f_NhanVienBH.Closed +=(s, args) => this.Close();
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
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
