using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Do_An
{
    public partial class Form_SanPham : Form
    {
        public Form_SanPham()
        {
            InitializeComponent();
            tb_IDSP.Enabled = false;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {

            Validate();
            
        }
        private void Validate()
        {
            string ten = tb_TenSP.Text;
            //string phanloai = cbb_PhanLoai.Text;
            int soluong = Convert.ToInt32(num_SoLuong.Value);
            bool isValid = true;
            if (soluong <= 0) isValid = false;
            if (string.IsNullOrEmpty(ten) || !ten.All(c => char.IsLetter(c))) isValid = false;
            //if (string.IsNullOrEmpty(phanloai) || !phanloai.All(c => char.IsLetter(c))) isValid = false
            if (cbb_PhanLoai.SelectedItem == null) isValid = false;
            if (!isValid) MessageBox.Show("Bạn đã nhập thiếu hoặc sai thông tin , vui lòng nhập lại !!");

        }

        private void Form_SanPham_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 30), this.DisplayRectangle);
        }
    }
}
