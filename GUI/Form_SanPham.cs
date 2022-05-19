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
<<<<<<< HEAD
        public Action loadTable { get; set; }
=======
        public Action<string> loadTable { get; set; }
>>>>>>> 33903dd8391e673206b1354cd8dda36707fc3556
        //mode 1: cho phép edit, mode 0: không cho phép edit (khi nhấn "xem chi tiết")
        public Form_SanPham(int id = 0, int mode = 1)
        {
            InitializeComponent();
            tb_IDSP.Enabled = false;
            DataTable dt = new DataTable();
            dt.Columns.Add("col0", typeof(String));
            dt.Columns.Add("col1", typeof(String));
            dgv_ThongSoKyThuat.DataSource = dt;

            if (id != 0)
            {
                ChiTietSanPhamView data = BLL_SanPham.Instance.GetChiTietSanPhamViewByIDSanPham(id);
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
                    NamSX = Convert.ToInt32(tb_NamSX.Text),
                    XuatXu = tb_XuatXu.Text,
                    GiaBan = Convert.ToInt32(num_GiaBan.Value),
                    ThongSoKyThuat = csv,
                    ThoiHanBaoHanh = Convert.ToInt32(num_ThoiHanBaoHanh.Value)
                };
                BLL_SanPham.Instance.ExcuteDB(data);
<<<<<<< HEAD
                loadTable();
=======
                loadTable("");
>>>>>>> 33903dd8391e673206b1354cd8dda36707fc3556
                this.Close();
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
            if (string.IsNullOrEmpty(ten) || !ten.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))) isValid = false;
            if (cbb_PhanLoai.SelectedItem == null) isValid = false;
            if(gia <= 0 || thbh < 0) isValid = false;
            if (!isValid)
            {
                check = false;
                MessageBox.Show("Bạn đã nhập thiếu hoặc sai thông tin , vui lòng nhập lại !!\n\n(Tên sản phẩm và phân loại là bắt buộc)");
            }
            return check;
        }


    }
}
