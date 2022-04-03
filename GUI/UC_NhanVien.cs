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
    public partial class UC_NhanVien : UserControl
    {
        private static UC_NhanVien _instance;
        public static UC_NhanVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_NhanVien();
                return _instance;
            }
        }
        public UC_NhanVien()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

     
    }
}
