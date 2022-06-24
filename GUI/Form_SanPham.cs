using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using Do_An.DTO;
using Do_An.BLL;


namespace Do_An
{
    public partial class Form_SanPham : Form
    {
        public Action loadTable { get; set; }
        //mode 1: cho phép edit, mode 0: không cho phép edit (khi nhấn "xem chi tiết")
        public int ID_SanPham = 0;
        public Form_SanPham(int id = 0, int mode = 1)
        {
            InitializeComponent();
            tb_IDSP.Enabled = false;
            DataTable dt = new DataTable();
            dt.Columns.Add("col0", typeof(String));
            dt.Columns.Add("col1", typeof(String));
            dgv_ThongSoKyThuat.DataSource = dt;
            ID_SanPham = id;
            if (ID_SanPham != 0)
            {
                ChiTietSanPhamView data = BLL_SanPham.Instance.GetChiTietSanPhamViewByIDSanPham(ID_SanPham);
                GUI(data, mode);
            }

        }
        private void GUI(ChiTietSanPhamView data, int mode)
        {
            tb_IDSP.Text = data.ID_SanPham.ToString();
            tb_IDSP.Enabled = false;
            tb_TenSP.Text = data.Ten;
            tb_XuatXu.Text = data.XuatXu != "" ? data.XuatXu.ToString() : "N/A";
            tb_NamSX.Text = data.NamSX.ToString();
            tb_TenHang.Text = data.TenHang != "" ? data.TenHang.ToString() : "N/A";
            cbb_PhanLoai.SelectedItem = data.PhanLoai;
            num_ThoiHanBaoHanh.Value = data.ThoiHanBaoHanh;
            num_GiaBan.Value = data.GiaBan;
            dgv_ThongSoKyThuat.DataSource = ReadCSVFormat(data.ThongSoKyThuat);
            if(mode == 0)
            {
                tb_TenSP.Enabled = false;
                tb_XuatXu.Enabled = false;
                tb_NamSX.Enabled = false;
                tb_TenHang.Enabled = false;
                cbb_PhanLoai.Enabled = false;
                num_ThoiHanBaoHanh.Enabled = false;
                num_GiaBan.Enabled = false;
                btn_XacNhan.Visible = false;
                btn_Huy.Text = "Tắt";
                btn_Huy.Location = new Point(678, 661);
                label7.Visible = false;
                num_TSKT.Visible = false;
                btn_TSKT.Visible = false;
            }

        }
        private DataTable ReadCSVFormat(string csv)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("col0", typeof(String));
            dt.Columns.Add("col1", typeof(String));
            if(csv != "")
            {
                string[] lines = csv.Split(
                    new string[] { Environment.NewLine },
                    StringSplitOptions.None
                );
                foreach(var line in lines)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = line.Substring(0, line.IndexOf(";"));
                    dr[1] = line.Substring(line.IndexOf(";") + 1, line.Length - line.IndexOf(";") - 2);
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
                string csv = "";
                for (int i = 0; i < dgv_ThongSoKyThuat.Rows.Count; i++)
                {
                    foreach (DataGridViewCell cell in dgv_ThongSoKyThuat.Rows[i].Cells)
                    {
                        if(cell.Value != null)
                            csv += cell.Value.ToString() + ';';
                    }
                    if(i < dgv_ThongSoKyThuat.Rows.Count - 2)
                        csv += Environment.NewLine;
                }
                ChiTietSanPhamView data = new ChiTietSanPhamView() {
                    ID_SanPham = tb_IDSP.Text != "" ? Convert.ToInt32(tb_IDSP.Text) : 0,
                    Ten = tb_TenSP.Text,
                    TenHang = tb_TenHang.Text,
                    PhanLoai = cbb_PhanLoai.SelectedItem.ToString(),
                    NamSX = tb_NamSX.Text != "" ? Convert.ToInt32(tb_NamSX.Text) : 0,
                    XuatXu = tb_XuatXu.Text,
                    GiaBan = Convert.ToInt32(num_GiaBan.Value),
                    ThongSoKyThuat = csv,
                    ThoiHanBaoHanh = Convert.ToInt32(num_ThoiHanBaoHanh.Value)
                };
                string msg = BLL_SanPham.Instance.ExcuteDB(data);
                if(msg != "")
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    MessageBox.Show("Lưu thông tin thành công");
                    loadTable();
                    this.Close();
                }
            }
            
        }
        private bool Validate()
        {
            bool check = true;
            int gia = (int)num_GiaBan.Value;
            int thbh = (int)num_ThoiHanBaoHanh.Value;
            string ten = tb_TenSP.Text;
            string namsx = tb_NamSX.Text;
            bool isValid = true;
            if (!namsx.All(c => char.IsNumber(c))) isValid = false;
            if (string.IsNullOrEmpty(ten)) isValid = false;
            if (cbb_PhanLoai.SelectedItem == null) isValid = false;
            if(gia <= 0 || thbh < 0) isValid = false;
            if (!isValid)
            {
                check = false;
                MessageBox.Show("Bạn đã nhập thiếu hoặc sai thông tin , vui lòng nhập lại !!\n\n(Tên sản phẩm và phân loại là bắt buộc)");
            }
            return check;
        }

        private void cbb_PhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ID_SanPham == 0)
            {
                if(cbb_PhanLoai.SelectedItem.ToString() == "Xe đạp")
                {
                    string csv = "Kích cỡ;N / A;\r\nMàu sắc; N / A;\r\nChất liệu khung; N / A;\r\n" +
                        "Phuộc; N / A;\r\nLốp xe; N / A;\r\nYên; N / A;\r\nBộ thắng; N / A;\r\n" +
                        "Tay thắng; N / A;\r\nBộ líp; N / A;\r\nSên xe; N / A;\r\nGiò dĩa; N / A;\r\n" +
                        "Trọng lượng; N / A;\r\nTay đề; N / A;\r\nGhi đông; N / A;";
                    dgv_ThongSoKyThuat.DataSource = ReadCSVFormat(csv);
                }
                else
                {
                    dgv_ThongSoKyThuat.DataSource = ReadCSVFormat("");
                }
            }
        }

        private void btn_TSKT_Click(object sender, EventArgs e)
        {
            int id = (int)num_TSKT.Value;
            string result = BLL_SanPham.Instance.GetThongSoKyThuatByIDSanPham(id);
            if (result == "") MessageBox.Show($"Thông số kỹ thuật của sản phẩm có ID {id} không tồn tại");
            else
            {
                dgv_ThongSoKyThuat.DataSource = ReadCSVFormat(result);
            }
        }
    }
}
