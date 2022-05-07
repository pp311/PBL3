using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using Do_An.DTO_AD;
using Do_An.BLL_AD;
using Do_An.DTO;
=======
using Do_An.DAL_ST;
using Do_An.DTO_AD;
using Do_An.BLL_AD;
>>>>>>> 39bd742a88e038cf788aeeb430f6043d93765d80
namespace Do_An
{
    public partial class UC_CaNhan : UserControl
    {

        public UC_CaNhan()
        {
            InitializeComponent();
<<<<<<< HEAD
            GUI();
=======
           GUI();
>>>>>>> 39bd742a88e038cf788aeeb430f6043d93765d80
        }

        private static UC_CaNhan _instance;
        public static UC_CaNhan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_CaNhan();
                return _instance;
            }
        }
<<<<<<< HEAD
        public void GUI()
        {
            CurrentUser cr = new CurrentUser();
            int id = CurrentUser.ID_NhanVien;
            NhanVien nv = BLL_NhanVien.Instance.BLL_GetNhanVienByID(id);
            

            tb_HoTen.Text = nv.TenNhanVien;
            tb_SoDienThoai.Text = nv.SoDienThoai;
            tb_DiaChi.Text = nv.DiaChi;
            cbb_ViTri.Text= nv.ViTri;
=======

        private void btn_DMK_Click(object sender, EventArgs e)
        {
            
        }
        public void GUI()
        {
            foreach (DataRow i in Login_DAL.Instance.GetThongTinCaNhan().Rows)
            {

       

            }
        }
     
        public void GUI_Edit(NhanVien nv, TaiKhoan tk)
        {
            tb_HoTen.Text = Convert.ToString(nv.TenNhanVien);
     /*       tb_IdNhanVien.Text = Convert.ToString(nv.ID_NhanVien);
            tb_SoDienThoai.Text = nv.SĐT;
            tb_DiaChi.Text = nv.DiaChi;
            tb_TenNhanVien.Text = nv.TenNhanVien;
            cbb_ViTri.SelectedItem = nv.ViTri;
>>>>>>> 39bd742a88e038cf788aeeb430f6043d93765d80
            dtp_NgaySinh.Value = nv.NgaySinh;
            if (nv.GioiTinh == "Nam")
            {
                rb_Nam.Checked = true;
            }
            else
            {
                rb_Nu.Checked = true;
            }
<<<<<<< HEAD
        }
        public void show(string txt)
        {

        }
        private void btn_DMK_Click(object sender, EventArgs e)
        {
            CurrentUser cr = new CurrentUser();
            int id = CurrentUser.ID_NhanVien;
            NhanVien nv = BLL_NhanVien.Instance.BLL_GetNhanVienByID(id);
            TaiKhoan tk = BLL_TaiKhoan.Instance.BLL_GetTaiKhoanByIDNV(nv);
            int idtk = tk.ID_TaiKhoan;
            string mktk = tk.MatKhau;
            // truyền idtk với mk tk 
            Pass p1 = new Pass(idtk, mktk);
            p1.d = new Pass.MyDel(show);

            p1.Show();
        }
   
 
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
                int idnv = CurrentUser.ID_NhanVien;
                NhanVien nv = BLL_NhanVien.Instance.BLL_GetNhanVienByID(idnv);
                nv.TenNhanVien = tb_HoTen.Text;
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
                MessageBox.Show("Bạn đã sửa thông tin nhân viên này thành công !!! ");
            }

        }
        private bool Validate()
        {

=======
            //b_TaiKhoan.Text=nv.
            tb_TaiKhoan.Text = tk.TenTaiKhoan;
*/

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Validate();
        }
        private void Validate()
        {
>>>>>>> 39bd742a88e038cf788aeeb430f6043d93765d80
            string hoTen = tb_HoTen.Text;
            string soDienThoai = tb_SoDienThoai.Text;
            string diaChi = tb_DiaChi.Text;
            bool isValid = true;
            if (string.IsNullOrEmpty(hoTen) || !hoTen.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) isValid = false;
            if (string.IsNullOrEmpty(soDienThoai) || !soDienThoai.All(c => char.IsNumber(c))) isValid = false;
            if (string.IsNullOrEmpty(diaChi) || !diaChi.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))) isValid = false;
            if (!rb_Nam.Checked && !rb_Nu.Checked) isValid = false;
            //if(cbb_ViTri.SelectedItem == null) isValid = false;

<<<<<<< HEAD
            if (!isValid)
            {
                isValid = false;
                MessageBox.Show("Bạn đã nhập thiếu hoặc sai thông tin , vui lòng nhập lại !!");
            }
            return isValid;
        }

        private void UC_CaNhan_Load(object sender, EventArgs e)
        {
           GUI();
          
=======
            if (!isValid) MessageBox.Show("Bạn đã nhập thiếu hoặc sai thông tin , vui lòng nhập lại !!");
>>>>>>> 39bd742a88e038cf788aeeb430f6043d93765d80
        }
    }
}
