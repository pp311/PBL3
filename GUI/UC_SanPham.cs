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
    public partial class UC_SanPham : UserControl
    {
        private static UC_SanPham _instance;
        public static UC_SanPham Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_SanPham();
                return _instance;
            }
        }
        public UC_SanPham()
        {
            InitializeComponent();
        }
    }
}
