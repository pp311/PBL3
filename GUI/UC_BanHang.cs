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
    public partial class UC_BanHang : UserControl
    {
        public UC_BanHang()
        {
            InitializeComponent();
        }
        private static UC_BanHang _instance;
        public static UC_BanHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_BanHang();
                return _instance;
            }
        }

     
    }
}
