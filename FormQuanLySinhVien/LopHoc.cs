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
    }
}
