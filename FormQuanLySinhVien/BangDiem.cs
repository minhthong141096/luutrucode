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
        public static List<BangDiem> DanhSachBangDiem;
        public BangDiem()
        {
        }

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
        public static void Them(BangDiem bangDiem)
        {
            if (DanhSachBangDiem == null)
                DanhSachBangDiem = new List<BangDiem>();
            DanhSachBangDiem.Add(bangDiem);
        }
        public static void Xoa(string diem)
        {
            DanhSachBangDiem.RemoveAll(bangdiem => bangdiem.MaSV == diem);
        }
        public static void Sua(BangDiem bangDiem)
        {
            Xoa(bangDiem.MaSV);
            Them(bangDiem);
        }

    }
}
