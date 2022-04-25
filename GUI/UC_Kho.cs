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
    public partial class UC_Kho : UserControl
    {
        private static UC_Kho _instance;
        public static UC_Kho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Kho();
                return _instance;
            }
        }
        public UC_Kho()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form_SanPham fsp = new Form_SanPham();
            fsp.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form_SanPham f = new Form_SanPham();
            f.Show();
        }
    }
}
