using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An.DTO;
using Do_An.BLL;
using Do_An.EF;

namespace Do_An
{
    public partial class UC_NhanVien : UserControl
    {
        public Action changeName { get; set; }
        public Action<string> loadTable { get; set; }
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
            tb_IdNhanVien.Enabled = false;
            EnableEdit(false);
            cbb_ViTri.Items.Add("Quản lý");
            cbb_ViTri.Items.Add("Nhân viên bán hàng");
            cbb_ViTri.Items.Add("Nhân viên sửa chữa");
            show("");
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        public void ResetGUI()
        {
            tb_IdNhanVien.Text = "";
            tb_TenNhanVien.Text = "";
            tb_DiaChi.Text = "";
           // dtp_NgaySinh.Value = DateTime.Now;
            rb_Nam.Checked = false;
            rb_Nu.Checked = false;
            cbb_ViTri.Text = "";
            tb_SoDienThoai.Text = "";
            tb_TaiKhoan.Text = "";

        }
        private NhanVien GetNhanVien() // laays nhan vien da nhap ra 
        {
            NhanVien nv = new NhanVien();
            nv.TenNhanVien = tb_TenNhanVien.Text;
            nv.DiaChi = tb_DiaChi.Text;
            nv.SoDienThoai = tb_SoDienThoai.Text;
            nv.ViTri = cbb_ViTri.Text;
            nv.NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Value);
            if (rb_Nam.Checked == true)
            {
                nv.GioiTinh = "Nam";
            }
            else
            {
                nv.GioiTinh = "Nữ";
            }
            nv.TaiKhoan = tb_TaiKhoan.Text;

            return nv;
        }

        private TaiKhoan GetTaiKhoan()
        {
            TaiKhoan tk = new TaiKhoan();
            tk.TenTaiKhoan = tb_TaiKhoan.Text;
            return tk;

        }
        public void show(string txt)
        {

            dtlv_nv.DataSource = BLL_NhanVien.Instance.GetAllNhanVien();
            dtlv_nv.Columns[0].HeaderText = "ID nhân viên";
            dtlv_nv.Columns[1].HeaderText = "ID tài khoản";
            dtlv_nv.Columns[2].HeaderText = "tên nhân viên";
            dtlv_nv.Columns[3].HeaderText = "Ngày sinh";
            dtlv_nv.Columns[4].HeaderText = "Giới tính";
            dtlv_nv.Columns[5].HeaderText = "Vị trí";
            dtlv_nv.Columns[6].HeaderText = "Số điện thoại";
            dtlv_nv.Columns[7].HeaderText = "Địa chỉ";
            dtlv_nv.Columns[8].HeaderText = "Tên tài khoản";
            //dataGridView1.Columns[0].HeaderText = "ID_NhanVien";
            ResetGUI();
            EnableEdit(false);
        }
        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                if (tb_IdNhanVien.Text == "")
                {
                    string s = tb_TaiKhoan.Text;
                    NhanVien nv = new NhanVien();
                    nv.TenNhanVien = tb_TenNhanVien.Text;
                    nv.DiaChi = tb_DiaChi.Text;
                    nv.SoDienThoai = tb_SoDienThoai.Text;
                    nv.ViTri = cbb_ViTri.Text;
                    nv.NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Value);
                    if (rb_Nam.Checked == true)
                    {
                        nv.GioiTinh = "Nam";
                    }
                    else
                    {
                        nv.GioiTinh = "Nữ";
                    }
                    int tos = -1;
                    SetPass f1 = new SetPass(s, nv.TenNhanVien, nv.DiaChi, nv.SoDienThoai, nv.ViTri, nv.NgaySinh, nv.GioiTinh,tos);
                
                    f1.Show();
                    f1.load = new Action<string>(show);
                    ResetGUI();
                    EnableEdit(false);
                }
                else
                {
                    // chỉnh sửa thông tin nhân viên 
                    int idnv = Convert.ToInt32(dtlv_nv.SelectedRows[0].Cells["ID_Nhanvien"].Value);
                    NhanVien nv = BLL_NhanVien.Instance.BLL_GetNhanVienByID(idnv);
                    //   NhanVien nv = BLL_NhanVien.Instance.
                    nv.ID_NhanVien = idnv;
                    nv.TenNhanVien = tb_TenNhanVien.Text;
                    nv.DiaChi = tb_DiaChi.Text;
                    nv.SoDienThoai = tb_SoDienThoai.Text;
                    nv.ViTri = cbb_ViTri.Text;
                    nv.NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Value);
                    if (rb_Nam.Checked == true)
                    {
                        nv.GioiTinh = "Nam";
                    }
                    else
                    {
                        nv.GioiTinh = "Nữ";
                    }
                    nv.TaiKhoan = tb_TaiKhoan.Text;
                
                    PBLEntities db = new PBLEntities();
                    //CurrentUser.ViTri luôn là "Quản lý"
                    if(db.nhanviens.FirstOrDefault(p => p.ID_NhanVien == idnv).ViTri == CurrentUser.ViTri 
                        && nv.ViTri != CurrentUser.ViTri)
                    {
                        MessageBox.Show("Không thể thay đổi vị trí của quản lý");
                        return;
                    }
                    if(CurrentUser.ID_NhanVien == nv.ID_NhanVien)
                    {
                        CurrentUser.Name = nv.TenNhanVien;
                        changeName();
                    }
                    BLL_NhanVien.Instance.Update(nv);
                    //  BLL_NhanVien.Instance.Update(GetNhanVien1());
                     show("");
                    MessageBox.Show("Bạn đã sửa thông tin nhân viên này thành công !!! ");
  
                }
            }
    }
        
  
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            EnableEdit(true);
            tb_TaiKhoan.Enabled = false;
            if (dtlv_nv.SelectedRows.Count == 1)
            {
                //  int idnv = conv
                // TaiKhoan tk = BLL_NhanVien.Instance.
                int idnv = Convert.ToInt32(dtlv_nv.SelectedRows[0].Cells["ID_Nhanvien"].Value);
                int idtk = Convert.ToInt32(dtlv_nv.SelectedRows[0].Cells["ID_TaiKhoan"].Value);
                NhanVien nv = BLL_NhanVien.Instance.BLL_GetNhanVienByID(idnv);
                TaiKhoan tk = BLL_TaiKhoan.Instance.BLL_GetTaiKhoanByID(idtk);
                GUI_Edit(nv, tk);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để chỉnh sửa thông tin !!! ");

            } 
                
           
        }
        public void GUI_Edit(NhanVien nv, TaiKhoan tk) // hieenj thong tin len bang 
        {
            tb_IdNhanVien.Text = Convert.ToString(nv.ID_NhanVien);
            tb_SoDienThoai.Text = nv.SoDienThoai;
            tb_DiaChi.Text = nv.DiaChi;
            tb_TenNhanVien.Text = nv.TenNhanVien;
            cbb_ViTri.SelectedItem = nv.ViTri;
            dtp_NgaySinh.Value = nv.NgaySinh;
            if (nv.GioiTinh == "Nam")
            {
                rb_Nam.Checked = true;
            }
            else
            {
                rb_Nu.Checked = true;
            }
            tb_TaiKhoan.Text = tk.TenTaiKhoan;
        }
       
        private void EnableEdit(bool b)
        {
            tb_TenNhanVien.Enabled = b;
            tb_SoDienThoai.Enabled = b;
            tb_DiaChi.Enabled = b;
            rb_Nam.Enabled = b;
            rb_Nu.Enabled = b;
            cbb_ViTri.Enabled = b;
            dtp_NgaySinh.Enabled = b;
            tb_TaiKhoan.Enabled = b;
        }
        private bool Validate()
        {

            string tenNhanVien = tb_TenNhanVien.Text;
            string soDienThoai = tb_SoDienThoai.Text;
            string diaChi = tb_DiaChi.Text;
            string taiKhoan = tb_TaiKhoan.Text;
            bool isValid = true;
            if (string.IsNullOrEmpty(tenNhanVien) || !tenNhanVien.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) isValid = false;
            if (string.IsNullOrEmpty(soDienThoai) || !soDienThoai.All(c => char.IsNumber(c))) isValid = false;
            if (string.IsNullOrEmpty(diaChi) || !diaChi.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))) isValid = false;
            if(!rb_Nam.Checked && !rb_Nu.Checked) isValid = false;
            //if(cbb_ViTri.SelectedItem == null) isValid = false;
            if (string.IsNullOrEmpty(taiKhoan)) isValid = false;
            if (string.IsNullOrEmpty(diaChi)) isValid = false;
            if (!isValid)
            {
                isValid = false;
                MessageBox.Show("Bạn đã nhập thiếu hoặc sai thông tin , vui lòng nhập lại !!");
            }
            PBLEntities db = new PBLEntities();
            if(db.taikhoans.Any(p => p.TenTaiKhoan == taiKhoan))
            {
                isValid = false;
                MessageBox.Show("Tên tài khoản đã tồn tại");
            }
            return isValid;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            EnableEdit(true);
            ResetGUI();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không ?", "xác nhận xóa", MessageBoxButtons.YesNo);

            if (dia == DialogResult.Yes)
            {
                if (dtlv_nv.SelectedRows.Count > 0)
                {
                    List<string> list = new List<string>();
                    foreach (DataGridViewRow i in dtlv_nv.SelectedRows)
                    {
                        list.Add(i.Cells["ID_NhanVien"].Value.ToString());

                    }
                    BLL_NhanVien.Instance.DelNhanVien(list);
                    dtlv_nv.DataSource = BLL_NhanVien.Instance.GetAllNhanVien();
                }
            }
            EnableEdit(false);
        }

        private void btn_ResetPassword_Click(object sender, EventArgs e)
        {
            if (dtlv_nv.SelectedRows.Count == 1)
            {
               /* int idtk = Convert.ToInt32(dtlv_nv.SelectedRows[0].Cells["ID_TaiKhoan"].Value);
                TaiKhoan tk = BLL_TaiKhoan.Instance.BLL_GetTaiKhoanByID(idtk);
                string mktk = tk.MatKhau;
                // truyền idtk với mk tk 
                Pass p1 = new Pass(idtk, mktk);
                p1.d = new Pass.MyDel(show);
                p1.Show();*/

                int idnv = Convert.ToInt32(dtlv_nv.SelectedRows[0].Cells["ID_Nhanvien"].Value);
            NhanVien nv = BLL_NhanVien.Instance.BLL_GetNhanVienByID(idnv);
            //   NhanVien nv = BLL_NhanVien.Instance.
            nv.ID_NhanVien = idnv;
            nv.TenNhanVien = tb_TenNhanVien.Text;
            nv.DiaChi = tb_DiaChi.Text;
            nv.SoDienThoai = tb_SoDienThoai.Text;
            nv.ViTri = cbb_ViTri.Text;
            nv.NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Value);
            if (rb_Nam.Checked == true)
            {
                nv.GioiTinh = "Nam";
            }
            else
            {
                nv.GioiTinh = "Nữ";
            }
            nv.TaiKhoan = tb_TaiKhoan.Text;
                int tos = Convert.ToInt32(dtlv_nv.SelectedRows[0].Cells["ID_TaiKhoan"].Value);
                
            //  nv.TaiKhoan = tb_TaiKhoan.Text;
            SetPass set = new SetPass(nv.TaiKhoan, nv.TenNhanVien, nv.DiaChi, nv.SoDienThoai, nv.ViTri, nv.NgaySinh, nv.GioiTinh,tos);
            set.d = new SetPass.MyDel(show);
            set.Show();
        

        }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để đổi mật khẩu !!! ");
            }
        }

      
        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            BLL_NhanVien.Instance.GetAllNhanVien();
            ResetGUI();
            EnableEdit(false);
        }

        private void dtlv_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetGUI();
            EnableEdit(false);
        }
    }
}
