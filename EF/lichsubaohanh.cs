//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Do_An.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class lichsubaohanh
    {
        public int STT { get; set; }
        public int ID_BaoHanh { get; set; }
        public int ID_NhanVien { get; set; }
        public Nullable<System.DateTime> NgayBaoHanh { get; set; }
        public string GhiChuBaoHanh { get; set; }
        public string TinhTrang { get; set; }
    
        public virtual nhanvien nhanvien { get; set; }
        public virtual thongtinbaohanh thongtinbaohanh { get; set; }
    }
}
