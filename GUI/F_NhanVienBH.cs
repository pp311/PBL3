﻿using System;
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
    public partial class F_NhanVienBH : Form
    {
        public F_NhanVienBH()
        {
            InitializeComponent();
        }

<<<<<<< HEAD

=======
        private void btn_CaNhanNVBH_Click(object sender, EventArgs e)
        {
            if (!pnl_MainBH.Controls.Contains(UC_CaNhan.Instance))
            {
                pnl_MainBH.Controls.Add(UC_CaNhan.Instance);
                UC_CaNhan.Instance.Dock = DockStyle.Fill;
                UC_CaNhan.Instance.BringToFront();
            }
            else
                UC_CaNhan.Instance.BringToFront();
        }

        
>>>>>>> ef15ea6996451a355c787f5226c98cf3e8d01f6e

        private void btn_HoaDonBH_Click(object sender, EventArgs e)
        {
            if (!pnl_MainBH.Controls.Contains(UC_HoaDon.Instance))
            {
                pnl_MainBH.Controls.Add(UC_HoaDon.Instance);
                UC_HoaDon.Instance.Dock = DockStyle.Fill;
                UC_HoaDon.Instance.BringToFront();
            }
            else
                UC_HoaDon.Instance.BringToFront();
        }

        private void btn_BanHangBH_Click(object sender, EventArgs e)
        {
            if (!pnl_MainBH.Controls.Contains(UC_BanHang.Instance))
            {
                pnl_MainBH.Controls.Add(UC_BanHang.Instance);
                UC_BanHang.Instance.Dock = DockStyle.Fill;
                UC_BanHang.Instance.BringToFront();
            }
            else
                UC_BanHang.Instance.BringToFront();
        }
<<<<<<< HEAD

        private void btn_SanPhamBH_Click(object sender, EventArgs e)
        {
            if (!pnl_MainBH.Controls.Contains(UC_SanPham.Instance))
            {
                pnl_MainBH.Controls.Add(UC_SanPham.Instance);
                UC_SanPham.Instance.Dock = DockStyle.Fill;
                UC_SanPham.Instance.BringToFront();
            }
            else
                UC_SanPham.Instance.BringToFront();
        }

        private void btn_CaNhanBH_Click(object sender, EventArgs e)
        {
            if (!pnl_MainBH.Controls.Contains(UC_CaNhan.Instance))
            {
                pnl_MainBH.Controls.Add(UC_CaNhan.Instance);
                UC_CaNhan.Instance.Dock = DockStyle.Fill;
                UC_CaNhan.Instance.BringToFront();
            }
            else
                UC_CaNhan.Instance.BringToFront();
        }

        private void picture_setting_Click(object sender, EventArgs e)
        {
           //
        }
=======
>>>>>>> ef15ea6996451a355c787f5226c98cf3e8d01f6e
    }
}
