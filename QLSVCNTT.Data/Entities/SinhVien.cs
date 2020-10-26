using System;
using System.Collections.Generic;
using System.Text;

namespace QLSVCNTT.Data.Entities
{
    public class SinhVien
    {
       public int MaSinhVien         { set; get; }
       public string TenSinhVien     { set; get; }
        public DateTime NgaySinh     { set; get; }
        public string GioiTinh       { set; get; }
        public string NoiSinh        { set; get; }
        public string QueQuan        { set; get; }
        public string QuocTich       { set; get; }
        public string DanToc         { set; get; }
        public string TonGiao        { set; get; }
        public string NoiThuongTru   { set; get; }
        public string DoiTuongTroCap { set; get; }
        public int SoDienThoai       { set; get; }
        public string Email          { set; get; }
        public int CMTND             { set; get; }
        public string DiaChiBaoTin   { set; get; }
        public string DiaChiTamTru   { set; get; }
        public string TinhTrang      { set; get; }
        public int SV_MaLop          { set; get; }
        public string Image          { set; get; }

    }
}
