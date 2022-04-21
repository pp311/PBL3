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
    public partial class UC_CaNhan : UserControl
    {
        public UC_CaNhan()
        {
            InitializeComponent();
        }

        private static UC_CaNhan _instance;
        public static UC_CaNhan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_CaNhan();
                return _instance;
            }
        }

        private void btn_DMK_Click(object sender, EventArgs e)
        {
            Pass p = new Pass();
            p.Show();
        }
    }
}
