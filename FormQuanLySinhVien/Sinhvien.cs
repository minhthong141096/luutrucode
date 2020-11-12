using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace FormQuanLySinhVien
{
    class Sinhvien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public static List<Sinhvien> DanhSachSinhVien;
        private static Sinhvien ThongTinSinhVienSua;
        public Sinhvien() { }
        public Sinhvien(string maSV, string tenSV, string sDT, string diaChi, bool gioiTinh, DateTime ngaySinh)
        {
            MaSV = maSV;
            TenSV = tenSV;
            SDT = sDT;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
        }

        public static List<Sinhvien> GetDanhSachSinhVien()
        {
            if (DanhSachSinhVien == null)
                return new List<Sinhvien>();
            return DanhSachSinhVien;
        }

        public int Tuoi()
        {
            int nam = DateTime.Now.Year;
            int namsinh = this.NgaySinh.Year;
            return nam - namsinh;
        }
        public string SinhVien2String()
        {
            return String.Format(@"{0}, {1}, {2}, {3}, {4}, {5}", MaSV, TenSV, SDT, DiaChi, GioiTinh, NgaySinh);
        }

        public static Sinhvien SinhVienbyId(string masV)
        {
            foreach (var sv in DanhSachSinhVien)
            {
                if (sv.MaSV == masV)
                    return sv;
            }
            return new Sinhvien();
        }
        //gán thông tin sinh viên cần sửa
        public static void SetSinhVienSua(Sinhvien svSua)
        {
            ThongTinSinhVienSua = svSua;
        }
        public static Sinhvien  GetSinhVienSua()
        {
            if(ThongTinSinhVienSua == null)
            {
                return new Sinhvien();
            }    
           return ThongTinSinhVienSua;
        }
        /// <summary>
        /// Class thêm sinh viên
        /// </summary>
        public void Them()
        {
            if (DanhSachSinhVien == null)
                DanhSachSinhVien = new List<Sinhvien>();
            DanhSachSinhVien.Add(this);
        }
        /// <summary>
        /// Sinhvien thêm sinhvien
        /// </summary>
        /// <param name="sv"></param>
        public static void Them(Sinhvien sv)
        {
            if (DanhSachSinhVien == null)
                DanhSachSinhVien = new List<Sinhvien>();
            DanhSachSinhVien.Add(sv);
        }
        public static void Xoa(string maSV)
        {
            DanhSachSinhVien.RemoveAll(sv => sv.MaSV == maSV);
        }
        public static void Sua(Sinhvien sinhvien)
        {
            Xoa(sinhvien.MaSV);
            Them(sinhvien);
        }
    }
}
