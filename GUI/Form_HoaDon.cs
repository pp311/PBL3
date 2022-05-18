using Do_An.BLL;
using Do_An.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An
{
    public partial class Form_HoaDon : Form
    {
        public Action<string> loadTable { get; set; }
        public Form_HoaDon(int id = 0,int mode = 1)
        {
            InitializeComponent();
            tb_IDHoaDon.Enabled = false;
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
        }
        private void GUI(ChiTietHoaDonView data, int mode)
        {
            tb_IDHoaDon.Text= data.ID_HoaDon.ToString();
            tb_IDHoaDon.Enabled= false;
            tb_TenKhachHang.Text = data.TenKhachHang.ToString();
            tb_SoDienThoai.Text = data.SDT.ToString();
            dtp_NgayTao.Value = data.NgayTao;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_HoaDon_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 30), this.DisplayRectangle);

        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {

        }
 
    }
}
