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
    public partial class UC_BaoHanh : UserControl
    {
        public UC_BaoHanh()
        {
            InitializeComponent();
        }
        private static UC_BaoHanh _instance;
        public static UC_BaoHanh Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_BaoHanh();
                return _instance;
            }
        }
    }
}
