using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An.BLL_AD;

namespace Do_An
{
    public partial class Pass : Form
    {
        public delegate void MyDel(int ID_TaiKhoan);
        public MyDel d { get; set; }


        public int id_taikhoan { get; set; }
        // truyeen mk 

        public Pass(int id)
        {
            InitializeComponent();
            id = id_taikhoan; 

        }

        
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_Luu_Click(object sender, EventArgs e)
        {
          /*  int ID_NhanVien = Convert.ToInt32(dtlv_nv.SelectedRows[0].Cells["ID_Nhanvien"].Value);
            // truyeeen id tai khoan de taoj taikhoan
            int ID_TaiKhoan = BLL_NhanVien.Instance.BLL_GetNhanVienByID(ID_NhanVien);
            BLL_TaiKhoan.Instance.BLL_GetTaiKhoanByID();*/
        }
    }
}
