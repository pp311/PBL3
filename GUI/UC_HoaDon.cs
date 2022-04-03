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
    public partial class UC_HoaDon : UserControl
    {
        public UC_HoaDon()
        {
            InitializeComponent();
        }
        private static UC_HoaDon _instance;
        public static UC_HoaDon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_HoaDon();
                return _instance;
            }
        }
    }
}
