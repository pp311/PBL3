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
    public partial class F_QuanLy : Form
    {
        System.Windows.Forms.Timer t = null;
        public F_QuanLy()
        {
            InitializeComponent();
            StartTimer();


        }

        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_Clock.Text = DateTime.Now.ToString();
        }

        void t_Tick(object sender, EventArgs e)
        {
            lb_Clock.Text = DateTime.Now.ToString();
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
            {
                UC_NhanVien.Instance.BringToFront();
                UC_NhanVien.Instance.show("");
            }    
        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {
            if (!pnl_Main.Controls.Contains(UC_Kho.Instance))
            {
                pnl_Main.Controls.Add(UC_Kho.Instance);
                UC_Kho.Instance.Dock = DockStyle.Fill;
                UC_Kho.Instance.BringToFront();
            }
            else
            {
                UC_Kho.Instance.BringToFront();
                UC_Kho.Instance.Show();
            }
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
            if (!pnl_Main.Controls.Contains(UC_NhapHang.Instance))
            {
                pnl_Main.Controls.Add(UC_NhapHang.Instance);
                UC_NhapHang.Instance.Dock = DockStyle.Fill;
                UC_NhapHang.Instance.BringToFront();
            }
            else
            {
                UC_NhapHang.Instance.BringToFront();
                UC_NhapHang.Instance.LoadTable();
            }

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_Clock_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
