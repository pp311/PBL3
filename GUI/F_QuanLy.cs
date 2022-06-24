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
    public partial class F_QuanLy : Form
    {
        System.Windows.Forms.Timer t = null;

        public F_QuanLy()
        {
            InitializeComponent();
            StartTimer();
            lb_Name.Text = CurrentUser.Name;
            lb_ID.Text = CurrentUser.ID_NhanVien.ToString();
            pnl_Main.Controls.Add(UC_ThongTinSanPham.Instance);
            UC_ThongTinSanPham.Instance.Dock = DockStyle.Fill;
            UC_ThongTinSanPham.Instance.BringToFront();
        }
        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        public void ChangeName()
        {
            lb_Name.Text = CurrentUser.Name;
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
                UC_NhanVien.Instance.changeName += ChangeName;
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
                UC_Kho.Instance.LoadTable();
            }
        }

        private void btn_CaNhan_Click(object sender, EventArgs e)
        {
            if (!pnl_Main.Controls.Contains(UC_CaNhan.Instance))
            {
                UC_CaNhan.Instance.changeName += ChangeName;
                pnl_Main.Controls.Add(UC_CaNhan.Instance);
                UC_CaNhan.Instance.Dock = DockStyle.Fill;
                UC_CaNhan.Instance.BringToFront();
            }
            else
            {
                UC_CaNhan.Instance.BringToFront();
                UC_CaNhan.Instance.GUI();

            }


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
            {
                UC_HoaDon.Instance.BringToFront();
                UC_HoaDon.Instance.Show();
            }
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            
                UC_ThongTinSanPham.Instance.BringToFront();
                UC_ThongTinSanPham.Instance.Show();
            

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

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            if (!pnl_Main.Controls.Contains(UC_BanHang.Instance))
            {
                pnl_Main.Controls.Add(UC_BanHang.Instance);
                UC_BanHang.Instance.Dock = DockStyle.Fill;
                UC_BanHang.Instance.BringToFront();
            }
            else
            {
                UC_BanHang.Instance.BringToFront();
                UC_BanHang.Instance.Show();
            }
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát chương trình?",
                       "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }

        }

    }
}
