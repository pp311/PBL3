﻿using Do_An.DTO;
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
    public partial class F_NhanVienBH : Form
    {
        System.Windows.Forms.Timer t = null;
        public F_NhanVienBH()
        {
            InitializeComponent();
            StartTimer();
            lb_Name.Text = CurrentUser.Name;
            lb_ID.Text = CurrentUser.ID_NhanVien.ToString();
        }
        public void ChangeName()
        {
            lb_Name.Text = CurrentUser.Name;
        }
        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }
         
        void t_Tick(object sender, EventArgs e)
            {
            lb_Clock.Text = DateTime.Now.ToString();
            }

        

        

        private void btn_HoaDonBH_Click(object sender, EventArgs e)
        {
            if (!pnl_MainBH.Controls.Contains(UC_HoaDon.Instance))
            {
                pnl_MainBH.Controls.Add(UC_HoaDon.Instance);
                UC_HoaDon.Instance.Dock = DockStyle.Fill;
                UC_HoaDon.Instance.BringToFront();
            }
            else
            {
                UC_HoaDon.Instance.BringToFront();
                UC_HoaDon.Instance.Show();
            }
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
            {
                UC_BanHang.Instance.BringToFront();
                UC_BanHang.Instance.Show();
            }
        }

        private void btn_SanPhamBH_Click(object sender, EventArgs e)
        {
            if (!pnl_MainBH.Controls.Contains(UC_SanPham.Instance))
            {
                pnl_MainBH.Controls.Add(UC_SanPham.Instance);
                UC_SanPham.Instance.Dock = DockStyle.Fill;
                UC_SanPham.Instance.BringToFront();
            }
            else
            {
                UC_SanPham.Instance.BringToFront();
                UC_SanPham.Instance.Show();
            }
        }

        private void btn_CaNhanBH_Click(object sender, EventArgs e)
        {
            if (!pnl_MainBH.Controls.Contains(UC_CaNhan.Instance))
            {
                UC_CaNhan.Instance.changeName += ChangeName;
                pnl_MainBH.Controls.Add(UC_CaNhan.Instance);
                UC_CaNhan.Instance.Dock = DockStyle.Fill;
                UC_CaNhan.Instance.BringToFront();
            }
            else
            {
                UC_CaNhan.Instance.BringToFront();
                UC_CaNhan.Instance.GUI();

            }

        }

        private void picture_setting_Click(object sender, EventArgs e)
        {
            //this.Close();
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát chương trình?",
         "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
