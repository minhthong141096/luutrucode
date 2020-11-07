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
