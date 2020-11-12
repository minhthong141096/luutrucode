using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormQuanLySinhVien
{
    class BangDiem 
    {
        public string  MaLop { get; set; }
        public string MaSV { get; set; }
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }
        public static List<BangDiem> DanhSachBangDiem { get; set; }

        public BangDiem(string maLop, string maSV, double diemToan, double diemLy, double diemHoa)
        {
            MaLop = maLop;
            MaSV = maSV;
            DiemToan = diemToan;
            DiemLy = diemLy;
            DiemHoa = diemHoa;
        }

        public string BangDiem2String()
        {
            return String.Format("{0},{1},{2},{3},{4}", MaLop, MaSV, DiemToan, DiemLy, DiemHoa);
        }
        public List<BangDiem> GetDanhSachBangDiem()
        {
            if (DanhSachBangDiem == null)
                return new List<BangDiem>();
            return DanhSachBangDiem;
        }
        public static void Them(BangDiem bd)
        {
            if (DanhSachBangDiem == null)
                DanhSachBangDiem = new List<BangDiem>();
            DanhSachBangDiem.Add(bd);
        }
        public static void Xoa(string malophoc, string masinhvien )
        {
            DanhSachBangDiem.RemoveAll(iteam => iteam.MaLop== malophoc && iteam.MaSV == masinhvien );
        }
        public static void Sua(BangDiem bd)
        {
            Xoa(bd.MaLop, bd.MaSV);
            Them(bd);
        }

    }
}
