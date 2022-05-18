using Do_An.BLL;
using Do_An.EF;
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
    public partial class UC_Kho : UserControl
    {
        //1 = add, 0 = update
        public static int mode = 1; 
        private static UC_Kho _instance;
        public static UC_Kho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Kho();
                return _instance;
            }
        }
        public UC_Kho()
        {
            InitializeComponent();
            
            EnableEdit(false);
            LoadTable();

        }

        private void btn_NhapSP_Click(object sender, EventArgs e)
        {
            EnableEdit(true);
            mode = 1;
        }

        public void LoadTable()
        {
            dgv_Table.DataSource = BLL_Kho.Instance.GetDataTableKho();
            dgv_Table.Columns["ID_LoHang"].HeaderText = "ID lô hàng";
            dgv_Table.Columns["ID_SanPham"].HeaderText = "ID sản phẩm";
            dgv_Table.Columns["NgayNhap"].HeaderText = "Ngày nhập";
            dgv_Table.Columns["SoLuongNhap"].HeaderText = "Số lượng nhập";
            dgv_Table.Columns["GiaMua"].HeaderText = "Giá nhập";
            dgv_Table.Columns["GiamGia"].HeaderText = "% giảm giá";
            dgv_Table.Columns["SoLuong"].HeaderText = "Số lượng còn";
        }


        private bool Validate()
        {
            bool check = true;
            bool isValid = true;
            int gia = (int)num_Gia.Value;
            int sl = (int)num_SoLuongNhap.Value;
            int giamgia = (int)num_GiamGia.Value;
            string id = tb_IDSP.Text;
            if (!id.All(c => char.IsNumber(c) || string.IsNullOrEmpty(id))) isValid = false;
            if(gia < 0 || sl <=0 || giamgia < 0) isValid = false;
            if(!isValid)
            {
                MessageBox.Show("Bạn đã nhập sai hoặc thiếu thông tin. Vui lòng nhập lại");
            }
            return check;
        }

        private void btn_SuaSP_Click(object sender, EventArgs e)
        {

            if (dgv_Table.SelectedRows.Count == 1)
            {
                EnableEdit(true);
                mode = 0;
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng 1 hàng để chỉnh sửa");
            }
        }
        private void EnableEdit(bool b)
        {
            tb_IDSP.Enabled = b;
            num_SoLuongNhap.Enabled = b;
            dtp_NgayNhap.Enabled=b;
            num_Gia.Enabled = b;
        }

        private void btn_XemCT_Click(object sender, EventArgs e)
        {
            if (dgv_Table.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(dgv_Table.SelectedRows[0].Cells["ID_SanPham"].Value.ToString());
                Form_SanPham f = new Form_SanPham(ID, 0);
                f.Show();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                int IDSP = Convert.ToInt32(tb_IDSP.Text);
                DateTime NgayNhap = dtp_NgayNhap.Value;
                int SoLuong = (int)num_SoLuongNhap.Value;
                int Gia = (int)num_Gia.Value;
                int GiamGia = (int)num_Gia.Value;
                int IDLoHang = 0;
                if (dgv_Table.SelectedRows.Count == 1 && mode == 0)
                {
                    IDLoHang = Convert.ToInt32(dgv_Table.SelectedRows[0].Cells["ID_LoHang"].Value.ToString());
                }
                kho data = new kho
                {
                    ID_LoHang = IDLoHang,
                    ID_SanPham = IDSP,
                    NgayNhap = NgayNhap,
                    SoLuongNhap = SoLuong,
                    GiaMua = Gia,
                    GiamGia = GiamGia,
                };
                string msg = BLL_Kho.Instance.ExcuteKho(data);
                MessageBox.Show(msg);
                LoadTable();

            }
        }

        private void dgv_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgv_Table.SelectedRows[0];
            string IDSP = dr.Cells["ID_SanPham"].Value.ToString();
            DateTime NgayNhap = Convert.ToDateTime(dr.Cells["NgayNhap"].Value.ToString());
            decimal SoLuong = Convert.ToDecimal(dr.Cells["SoLuongNhap"].Value.ToString());
            int GiaMua = Convert.ToInt32(dr.Cells["GiaMua"].Value.ToString());
            int GiamGia = Convert.ToInt32(dr.Cells["GiamGia"].Value.ToString());
            tb_IDSP.Text = IDSP;
            dtp_NgayNhap.Value = NgayNhap;
            num_SoLuongNhap.Value = SoLuong;
            num_Gia.Value = GiaMua;
            num_GiamGia.Value = GiamGia;
            EnableEdit(false);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string msg;
            if (dgv_Table.SelectedRows.Count >= 1)
            {
                List<int> delList = new List<int>();
                foreach (DataGridViewRow row in dgv_Table.SelectedRows)
                {
                    delList.Add(Convert.ToInt32(row.Cells["ID_LoHang"].Value));
                }
                msg = BLL_Kho.Instance.DeleteThongTinNhapHang(delList);
            }
            else
            {
                msg = "Vui lòng chọn ít nhất 1 hàng để xoá!";
            }
            MessageBox.Show(msg);
            LoadTable();
        }
    }
}
