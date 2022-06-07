using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An.BLL;
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

        private void btn_TK_Click(object sender, EventArgs e)
        {
            DateTime d1 = Convert.ToDateTime(datetime1.Value);
            DateTime d2 = Convert.ToDateTime(datetime2.Value);
         
            if (d1<=d2)
            {
               // MessageBox.Show("đúng");

                // số hàng đã nhập 1
                  label1.Text = (BLL_ThongKe.Instance.SoSPDaNhap(d1, d2)).ToString();
               
                // số hàng đã bán được 2
                label2.Text = (BLL_ThongKe.Instance.SoSPBanDuoc(d1, d2)).ToString();


                // tổng chi 13
               label13.Text = (BLL_ThongKe.Instance.TongChi(d1, d2)).ToString("N0") + " VND";
                // tổng doanh thu 14
                label14.Text = (BLL_ThongKe.Instance.TongDoanhThu(d1, d2)).ToString("N0") + " VND";
                // lợi nhuận 7
                label7.Text = (BLL_ThongKe.Instance.TongLoiNhuan(d1, d2)).ToString("N0") + " VND";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thời gian thống kê hợp lệ !!!! ");
            }
          
        }
    }
}
