using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An.DAL_ST;
using Do_An.DTO_AD;
using Do_An.BLL_AD;
namespace Do_An
{
    public partial class UC_CaNhan : UserControl
    {
        public UC_CaNhan()
        {
            InitializeComponent();
           GUI();
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
            dtp_NgaySinh.Value = nv.NgaySinh;
            if (nv.GioiTinh == "Nam")
            {
                rb_Nam.Checked = true;
            }
            else
            {
                rb_Nu.Checked = true;
            }
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
            string hoTen = tb_HoTen.Text;
            string soDienThoai = tb_SoDienThoai.Text;
            string diaChi = tb_DiaChi.Text;
            bool isValid = true;
            if (string.IsNullOrEmpty(hoTen) || !hoTen.All(c => char.IsLetter(c))) isValid = false;
            if (string.IsNullOrEmpty(soDienThoai) || !soDienThoai.All(c => char.IsNumber(c))) isValid = false;
            if (string.IsNullOrEmpty(diaChi) || !diaChi.All(c => char.IsLetterOrDigit(c))) isValid = false;
            if (!rb_Nam.Checked && !rb_Nu.Checked) isValid = false;
            //if(cbb_ViTri.SelectedItem == null) isValid = false;

            if (!isValid) MessageBox.Show("Bạn đã nhập thiếu hoặc sai thông tin , vui lòng nhập lại !!");
        }
    }
}
