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
    public partial class UC_BaoHanh : UserControl
    {
        private UC_BaoHanh()
        {
            InitializeComponent();
            Show();
            LoadTableDangBaoHanh();
            EnableEdit(false);
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
        public void Show()
        {
            dgv_DanhSachBaoHanh.DataSource = BLL_BaoHanh.Instance.GetDanhSachBaoHanh();
            dgv_DanhSachBaoHanh.Columns["ID_BaoHanh"].HeaderText = "ID bảo hành";
            dgv_DanhSachBaoHanh.Columns["ID_HoaDon"].HeaderText = "ID bóa đơn";
            dgv_DanhSachBaoHanh.Columns["ID_LoHang"].HeaderText = "ID lô hàng";
            dgv_DanhSachBaoHanh.Columns["ID_SanPham"].HeaderText = "ID sản phẩm";
            dgv_DanhSachBaoHanh.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgv_DanhSachBaoHanh.Columns["HanBaoHanh"].HeaderText = "Hạn bảo hành";
            dgv_DanhSachBaoHanh.Columns["Serial"].HeaderText = "Serial";

        }
        private void LoadTableLichSuBaoHanh(int ID_BaoHanh)
        {
            dgv_LichSuBaoHanh.DataSource = BLL_BaoHanh.Instance.GetLichSuBaoHanh(ID_BaoHanh);
            dgv_LichSuBaoHanh.Columns["ID_BaoHanh"].HeaderText = "ID bảo hành";
            dgv_LichSuBaoHanh.Columns["ID_NhanVien"].HeaderText = "ID nhân viên";
            dgv_LichSuBaoHanh.Columns["TinhTrang"].HeaderText = "Tình trạng";
            dgv_LichSuBaoHanh.Columns["NgayBaoHanh"].HeaderText = "Ngày bảo hành";
            LoadTableDangBaoHanh();
        }   
        public void LoadTableDangBaoHanh()
        {
            dgv_DangBaoHanh.DataSource = BLL_BaoHanh.Instance.GetSanPhamDangBaoHanh();
            dgv_DangBaoHanh.Columns["ID_BaoHanh"].HeaderText = "ID bảo hành";
            dgv_DangBaoHanh.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgv_DangBaoHanh.Columns["ID_NhanVien"].HeaderText = "ID nhân viên";
            dgv_DangBaoHanh.Columns["TinhTrang"].HeaderText = "Tình trạng";
            dgv_DangBaoHanh.Columns["NgayBaoHanh"].HeaderText = "Ngày bảo hành";
            
        }
        private void dgv_DanhSachBaoHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgv_DanhSachBaoHanh.SelectedRows[0];
            lb_HanBaoHanh.Text = Convert.ToDateTime(dr.Cells["HanBaoHanh"].Value).ToString("dd/MM/yyyy");
            lb_IDBaoHanh.Text = dr.Cells["ID_BaoHanh"].Value.ToString();
            lb_Serial.Text = dr.Cells["Serial"].Value.ToString();
            lb_TenSP.Text = dr.Cells["TenSanPham"].Value.ToString();
            EnableEdit(false);
            int ID_BaoHanh = Convert.ToInt32(dr.Cells["ID_BaoHanh"].Value.ToString());
            LoadTableLichSuBaoHanh(ID_BaoHanh);
            ClearFormLichSuBaoHanh();
        }
        private void ClearFormLichSuBaoHanh()
        {
            lb_STT.Text = "0";
            tb_IDNhanVien.Text = "";
            tb_GhiChuBaoHanh.Text = "";
            cbb_TinhTrang.SelectedItem = null;
        }
        private void EnableEdit(bool b)
        {
            tb_GhiChuBaoHanh.Enabled = b;
            tb_IDNhanVien.Enabled = b;
            dtp_NgayBaoHanh.Enabled = b;
            cbb_TinhTrang.Enabled = b;
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if(!BLL_BaoHanh.Instance.CheckHanBaoHanh(Convert.ToInt32(lb_IDBaoHanh.Text)))
            {
                MessageBox.Show("Sản phẩm này đã hết hạn bảo hành");
            }
            else if(BLL_BaoHanh.Instance.CheckTinhTrangBaoHanh(Convert.ToInt32(lb_IDBaoHanh.Text)))
            {
                EnableEdit(true);
                ClearFormLichSuBaoHanh();
            }
            else
            {
                MessageBox.Show("Sản phẩm đang trong quá trình bảo hành, không thể tạo lịch bảo hành mới");
            }
        }
        private bool Validate()
        {
            string idnv = tb_IDNhanVien.Text;
            bool isValid = true;
            if (string.IsNullOrEmpty(idnv) || !idnv.All(c => char.IsNumber(c))) isValid = false;
            if (cbb_TinhTrang.SelectedItem == null) isValid = false;
            if (!isValid)
            {
                isValid = false;
                MessageBox.Show("Thông tin bạn nhập không hợp lệ, vui lòng nhập lại !!");
            }
            return isValid;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
                lichsubaohanh lsbh = new lichsubaohanh
                {
                    STT = Convert.ToInt32(lb_STT.Text),
                    ID_BaoHanh = Convert.ToInt32(lb_IDBaoHanh.Text),
                    ID_NhanVien = Convert.ToInt32(tb_IDNhanVien.Text),
                    NgayBaoHanh = dtp_NgayBaoHanh.Value,
                    TinhTrang = cbb_TinhTrang.SelectedItem.ToString(),
                    GhiChuBaoHanh = tb_GhiChuBaoHanh.Text
                };
                BLL_BaoHanh.Instance.SaveLichSuBaoHanh(lsbh);
                LoadTableLichSuBaoHanh(lsbh.ID_BaoHanh);
                MessageBox.Show("Lưu thông tin thành công");
            }
        }

        private void dgv_LichSuBaoHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgv_LichSuBaoHanh.SelectedRows[0];
            int stt = Convert.ToInt32(dr.Cells["STT"].Value.ToString());
            lichsubaohanh lsbh = BLL_BaoHanh.Instance.GetLichSuBaoHanhBySTT(stt);
            lb_STT.Text = dr.Cells["STT"].Value.ToString();
            tb_IDNhanVien.Text = lsbh.ID_NhanVien.ToString();
            tb_GhiChuBaoHanh.Text = lsbh.GhiChuBaoHanh;
            cbb_TinhTrang.SelectedItem = lsbh.TinhTrang;
            EnableEdit(true);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(dgv_LichSuBaoHanh.SelectedRows.Count == 1)
            {
                int stt = Convert.ToInt32(dgv_LichSuBaoHanh.SelectedRows[0].Cells["STT"].Value.ToString());
                BLL_BaoHanh.Instance.DeleteLichSuBaoHanh(stt);
                MessageBox.Show("Xóa thành công");
                LoadTableLichSuBaoHanh(Convert.ToInt32(lb_IDBaoHanh.Text));
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string keyWord = tb_Search.Text;
            dgv_DanhSachBaoHanh.DataSource = BLL_BaoHanh.Instance.GetDanhSachBaoHanhByKeyWord(keyWord);
        }

        private void dgv_DangBaoHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgv_DangBaoHanh.SelectedRows[0];
            int idbh = Convert.ToInt32(dr.Cells["ID_BaoHanh"].Value.ToString());
            thongtinbaohanh ttbh = BLL_BaoHanh.Instance.GetThongTinBaoHanh(idbh);
            lb_HanBaoHanh.Text = Convert.ToDateTime(ttbh.HanBaoHanh).ToString("dd/MM/yyyy");
            lb_IDBaoHanh.Text = ttbh.ID_BaoHanh.ToString();
            lb_Serial.Text = ttbh.Serial.ToString();
            int stt = Convert.ToInt32(dr.Cells["STT"].Value.ToString());
            lichsubaohanh lsbh = BLL_BaoHanh.Instance.GetLichSuBaoHanhBySTT(stt);
            lb_STT.Text = dr.Cells["STT"].Value.ToString();
            lb_TenSP.Text = dr.Cells["TenSanPham"].Value.ToString();
            tb_IDNhanVien.Text = lsbh.ID_NhanVien.ToString();
            tb_GhiChuBaoHanh.Text = lsbh.GhiChuBaoHanh;
            cbb_TinhTrang.SelectedItem = lsbh.TinhTrang;
            EnableEdit(true);
        }
    }
}
