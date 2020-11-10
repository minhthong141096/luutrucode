using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormQuanLySinhVien
{
    class LopHoc
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string DiaChi { get; set; }
       public static List<LopHoc> DanhSachLopHoc;
        private static LopHoc ThongTinSuaLopHoc;
        public LopHoc()
        {
        }

        public LopHoc(string maLop, string tenLop, string diaChi)
        {
            MaLop = maLop;
            TenLop = tenLop;
            DiaChi = diaChi;
        }
        public string LopHoc2String()
        {
            return String.Format("{0},{1},{2},", MaLop, TenLop, DiaChi);
        }
/// <summary>
/// thêm thông tin đối tượng hiện tại vào danh sách
/// là this
/// </summary>
        public void Them()
        {
            if (DanhSachLopHoc == null)
                DanhSachLopHoc = new List<LopHoc>();
            DanhSachLopHoc.Add(this);

        }
        public static void Xoa(string maLopHoc)
        {
            DanhSachLopHoc.RemoveAll(lophoc => lophoc.MaLop == maLopHoc);
        }
        public static void Sua(LopHoc lopHoc)
        {
            Xoa(lopHoc.MaLop);
            Them(lopHoc);
        }

        private static void Them(LopHoc lopHoc)
        {
            if (DanhSachLopHoc == null)
                DanhSachLopHoc = new List<LopHoc>();
            DanhSachLopHoc.Add(lopHoc);
        }

        public static LopHoc LopHocById(string maLopHoc)
        {
            if(DanhSachLopHoc!= null)
                foreach (var lophoc in DanhSachLopHoc)
                {
                    if (lophoc.MaLop == maLopHoc)
                        return lophoc;
                }
            return new LopHoc();
        }

        public static void SetThongTinSuaLopHoc(LopHoc lhSua)
        {
            ThongTinSuaLopHoc = lhSua;
        }
        public static LopHoc GetThongTinSuaLopHoc()
        {
            if (ThongTinSuaLopHoc != null)
                return ThongTinSuaLopHoc;
            return new LopHoc();
        }
    }
}
