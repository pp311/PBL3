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
    public partial class F_NhanVienSC : Form
    {
        public F_NhanVienSC()
        {
            InitializeComponent();
        }

        private void btn_BanHangBH_Click(object sender, EventArgs e)
        {
            if (!pnl_MainSC.Controls.Contains(UC_BanHang.Instance))
            {
                pnl_MainSC.Controls.Add(UC_BanHang.Instance);
                UC_BanHang.Instance.Dock = DockStyle.Fill;
                UC_BanHang.Instance.BringToFront();
            }
            else
                UC_BanHang.Instance.BringToFront();
        }

        private void btn_HoaDonBH_Click(object sender, EventArgs e)
        {
            if (!pnl_MainSC.Controls.Contains(UC_HoaDon.Instance))
            {
                pnl_MainSC.Controls.Add(UC_HoaDon.Instance);
                UC_HoaDon.Instance.Dock = DockStyle.Fill;
                UC_HoaDon.Instance.BringToFront();
            }
            else
                UC_HoaDon.Instance.BringToFront();
        }

        private void btn_BaoHanhSC_Click(object sender, EventArgs e)
        {
            if (!pnl_MainSC.Controls.Contains(UC_BaoHanh.Instance))
            {
                pnl_MainSC.Controls.Add(UC_BaoHanh.Instance);
                UC_BaoHanh.Instance.Dock = DockStyle.Fill;
                UC_BaoHanh.Instance.BringToFront();
            }
            else
                UC_BaoHanh.Instance.BringToFront();
        }

        private void btn_CaNhanSC_Click(object sender, EventArgs e)
        {
            if (!pnl_MainSC.Controls.Contains(UC_CaNhan.Instance))
            {
                pnl_MainSC.Controls.Add(UC_CaNhan.Instance);
                UC_CaNhan.Instance.Dock = DockStyle.Fill;
                UC_CaNhan.Instance.BringToFront();
            }
            else
                UC_CaNhan.Instance.BringToFront();
        }

        private void btn_SanPhamSC_Click(object sender, EventArgs e)
        {
            if (!pnl_MainSC.Controls.Contains(UC_SanPham.Instance))
            {
                pnl_MainSC.Controls.Add(UC_SanPham.Instance);
                UC_SanPham.Instance.Dock = DockStyle.Fill;
                UC_SanPham.Instance.BringToFront();
            }
            else
                UC_SanPham.Instance.BringToFront();
        }
    }
}
