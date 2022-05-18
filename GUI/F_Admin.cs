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
    public partial class F_Admin : Form
    {
        public F_Admin()
        {
            InitializeComponent();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            if (!pnl_Main.Controls.Contains(UC_NhanVien.Instance))
            {
                pnl_Main.Controls.Add(UC_NhanVien.Instance);
                UC_NhanVien.Instance.Dock = DockStyle.Fill;
                UC_NhanVien.Instance.BringToFront();
            }
            else
                UC_NhanVien.Instance.BringToFront();
        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {
            if (!pnl_Main.Controls.Contains(UC_ThongTinSanPham.Instance))
            {
                pnl_Main.Controls.Add(UC_ThongTinSanPham.Instance);
                UC_ThongTinSanPham.Instance.Dock = DockStyle.Fill;
                UC_ThongTinSanPham.Instance.BringToFront();
            }
            else
                UC_ThongTinSanPham.Instance.BringToFront();
        }

        private void btn_CaNhan_Click(object sender, EventArgs e)
        {
            if (!pnl_Main.Controls.Contains(UC_CaNhan.Instance))
            {
                pnl_Main.Controls.Add(UC_CaNhan.Instance);
                UC_CaNhan.Instance.Dock = DockStyle.Fill;
                UC_CaNhan.Instance.BringToFront();
            }
            else
                UC_CaNhan.Instance.BringToFront();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            if (!pnl_Main.Controls.Contains(UC_HoaDon.Instance))
            {
                pnl_Main.Controls.Add(UC_HoaDon.Instance);
                UC_HoaDon.Instance.Dock = DockStyle.Fill;
                UC_HoaDon.Instance.BringToFront();
            }
            else
                UC_HoaDon.Instance.BringToFront();
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            if (!pnl_Main.Controls.Contains(UC_Kho.Instance))
              {
                  pnl_Main.Controls.Add(UC_Kho.Instance);
                  UC_Kho.Instance.Dock = DockStyle.Fill;
                  UC_Kho.Instance.BringToFront();
              }
              else
                UC_Kho.Instance.BringToFront();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            if (!pnl_Main.Controls.Contains(UC_ThongKe.Instance))
            {
                pnl_Main.Controls.Add(UC_ThongKe.Instance);
                UC_ThongKe.Instance.Dock = DockStyle.Fill;
                UC_ThongKe.Instance.BringToFront();
            }
            else
                UC_ThongKe.Instance.BringToFront();
        }

        private void pictureĐX_Click(object sender, EventArgs e)
        {

        }
    }
}
