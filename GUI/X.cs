using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An.DAL;
namespace Do_An
{
    public partial class X : Form
    {
        public delegate void MyDel(string txt);
        public MyDel d { get; set; }
        F_QuanLy f2 { get; set; }
      
        public X(F_QuanLy f1)
        {
            InitializeComponent();
            //   this.d = d;
            this.f2 = f1;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 
        // đăng xuất

        private void button16_Click(object sender, EventArgs e)
        {

        //    f2.Dispose();
          //  f2.Close();
            f2.Hide();
            F_DangNhap f = new F_DangNhap();
            f.Show();
            this.Close();
         
        



        }

        private void btn_ThoatCT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
