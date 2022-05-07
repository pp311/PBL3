using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An.DAL_AD;
using Do_An.BLL_AD;
using Do_An.DTO_AD;
namespace Do_An
{
    public partial class SetPass : Form
    {
        public delegate void MyDel(string txt);
        public MyDel d { get; set; }
        private string tentaikhoan;
        private string idnhanvien;
<<<<<<< HEAD
=======
        //
>>>>>>> 39bd742a88e038cf788aeeb430f6043d93765d80
        private string tennhanvien;
        private string diachi;
        private string vitri;
        private string sodienthoai;

        private DateTime ngaysinh;
        private string gioitinh;
        //  private int idtk;
        public Action<string> load { get; set; }
<<<<<<< HEAD
=======

        // truyen taikhoan qua , them matkhau 
        /*    public delegate void MyDel(string txt);*/

        //    public Form1( string ttk)
>>>>>>> 39bd742a88e038cf788aeeb430f6043d93765d80
        public SetPass(string ttk,string tnv,string dc,string sdt,string vt,DateTime ns,string gt)

        {
            InitializeComponent();
              this.tentaikhoan= ttk;
            //
            this.tennhanvien = tnv;
            this.diachi= dc;
            this.sodienthoai = sdt;
            this.vitri = vt;
            this.ngaysinh = ns;
            this.gioitinh = gt;
<<<<<<< HEAD
        }  
       private void btn_Huy_Click(object sender, EventArgs e)
=======
        }
    
        private void btn_Huy_Click(object sender, EventArgs e)
>>>>>>> 39bd742a88e038cf788aeeb430f6043d93765d80
        {
            this.Dispose();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (Validate())
            {
                TaiKhoan tk = new TaiKhoan();
                tk.MatKhau = tb_Mk1.Text;
                tk.TenTaiKhoan = tentaikhoan;
                // tk.ID_TaiKhoan = idtk;


                NhanVien nv = new NhanVien();
                nv.TenNhanVien = tennhanvien;
                nv.DiaChi = diachi;
                nv.GioiTinh = gioitinh;
                nv.SoDienThoai = sodienthoai;
                nv.ViTri = vitri;
                nv.NgaySinh = ngaysinh;

                BLL_NhanVien.Instance.AddNhanVien(nv, tk);
<<<<<<< HEAD
                MessageBox.Show("Bạn đã thêm nhân viên này thành công !!! ");
                load("");
=======
>>>>>>> 39bd742a88e038cf788aeeb430f6043d93765d80
                this.Dispose();


            }
        }

        private bool Validate()
        {
            string matkhau1 = tb_Mk1.Text;
            string matkhau2 = tb_Mk2.Text;
            bool check = true;
            bool isValid = true;
            if (string.IsNullOrEmpty(matkhau1) || !matkhau1.All(c => char.IsLetterOrDigit(c))) isValid = false;
            if (string.IsNullOrEmpty(matkhau2) || !matkhau2.All(c => char.IsLetterOrDigit(c))) isValid = false;
            if (tb_Mk1.Text != tb_Mk2.Text) isValid = false;

            if (!isValid)
            {
                MessageBox.Show("Bạn đã nhập thiếu hoặc sai thông tin , vui lòng nhập lại !!");
                check = false;
            }
            return check;
        }




    }
}
