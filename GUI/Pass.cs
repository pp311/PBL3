using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An.BLL;
using Do_An.DTO;

namespace Do_An
{
    public partial class Pass : Form
    {

        public delegate void MyDel(string txt);

        public MyDel d { get; set; }
        private int idtaikhoan;
        private string matkhaucu123;
        public Pass(int idtk, string mk)
        {
            InitializeComponent();
            this.idtaikhoan = idtk;
            this.matkhaucu123 = mk;
           // GUI();

        }


        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Validate()
        {
            string matkhaucu = tb_Mk1.Text;
            string matkhaumoi1 = tb_Mk2.Text;
            string matkhaumoi2 = tb_Mk3.Text;
            bool isValid = true;
            if (string.IsNullOrEmpty(matkhaucu)) isValid = false;
            if (string.IsNullOrEmpty(matkhaumoi1)) isValid = false;
            if (string.IsNullOrEmpty(matkhaumoi2)) isValid = false;
            if (BLL_TaiKhoan.EncodePass(tb_Mk1.Text) != matkhaucu123) isValid = false;
            if (tb_Mk2.Text != tb_Mk3.Text) isValid = false;
            if (matkhaumoi1.Length < 4) isValid = false;

            if (!isValid)
            {
                isValid = false;
                MessageBox.Show("Bạn đã nhập thiếu hoặc sai thông tin , vui lòng nhập lại !!");
            }
            return isValid;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
          

            if(Validate())
            {
                TaiKhoan tk = new TaiKhoan();
               // tk.MatKhau = tb_Mk2.Text;
                tk.MatKhau = BLL_TaiKhoan.EncodePass(tb_Mk2.Text);

                tk.ID_TaiKhoan = idtaikhoan;


                BLL_TaiKhoan.Instance.UpdatePass(tk);
                MessageBox.Show("Bạn đã thay đổi mật khẩu nhân viên này thành công !! ");  
                this.Dispose();
            }
 

        }
        public void GUI()
        {
          //  tb_Mk1.Text = matkhaucu123;
         //   tb_Mk1.Enabled = false;

        }
    }
}
