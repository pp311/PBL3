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
    public partial class F_DangNhap : Form
    {
        public F_DangNhap()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            F_QuanLy f_admin = new F_QuanLy();
            f_admin.Closed += (s, args) => this.Close();
            f_admin.Show();
        }
    }
}
