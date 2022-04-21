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
    public partial class UC_NhapHang : UserControl
    {
        private static UC_NhapHang _instance;
        public static UC_NhapHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_NhapHang();
                return _instance;
            }
        }
        public UC_NhapHang()
        {
            InitializeComponent();
        }

        private void btn_NhapSP_Click(object sender, EventArgs e)
        {
            Form_SanPham fsp = new Form_SanPham();
            fsp.Show();
        }
    }
}
