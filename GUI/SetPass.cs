using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An.DAL;
using Do_An.BLL;
using Do_An.DTO;

namespace Do_An
{
    public partial class SetPass : Form
    {
        public delegate void MyDel(string txt);
        public MyDel d { get; set; }
        private string tentaikhoan;
        private int tos;

        private string tennhanvien;
        private string diachi;
        private string vitri;
        private string sodienthoai;

        private DateTime ngaysinh;
        private string gioitinh;
        //  private int idtk;
        public Action<string> load { get; set; }


        // truyen taikhoan qua , them matkhau 
        /*    public delegate void MyDel(string txt);*/

        //    public Form1( string ttk)

       
        public SetPass( string ttk, string tnv, string dc, string sdt, string vt, DateTime ns, string gt,int tos)


        {
            InitializeComponent();
            this.tentaikhoan = ttk;
            //
            this.tos = tos;

            this.tennhanvien = tnv;
            this.diachi = dc;
            this.sodienthoai = sdt;
            this.vitri = vt;
            this.ngaysinh = ns;
            this.gioitinh = gt;

        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (Validate())
            {
                
                if(tos!=-1)
                {
                    // cap nhat mk 
                    TaiKhoan tk = new TaiKhoan();
                    // tk.MatKhau = tb_Mk2.Text;

                    tk.MatKhau = BLL_TaiKhoan.EncodePass(tb_Mk2.Text);  
                    tk.ID_TaiKhoan = tos;

                    BLL_TaiKhoan.Instance.UpdatePass(tk);
                    MessageBox.Show("Bạn đã thay đổi mật khẩu nhân viên này thành công !! ");
                    this.Dispose();

                }
                else
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
                
                MessageBox.Show("Bạn đã thêm nhân viên này thành công !!! ");
                load("");
                this.Dispose();
                
                }
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
            if (tb_Mk1.Text.Length < 4) isValid = false;

            if (!isValid)
            {
                MessageBox.Show("Bạn đã nhập thiếu hoặc sai thông tin , vui lòng nhập lại !!");
                check = false;
            }
            return check;
        }




    }
}
