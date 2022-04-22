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
    public partial class UC_ThongKe : UserControl
    {
        private static UC_ThongKe _instance;
        public static UC_ThongKe Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ThongKe();
                return _instance;
            }
        }
        public UC_ThongKe()
        {
            InitializeComponent();
        }
    }
}
