using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudungham
{
    class Program
        
    {
        static void Main(string[] args)
        {
            //XinChao();
            //XinChao(Console.ReadLine());
            try
            {
                Menu();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }

        private static void Menu()
        {
            Console.WriteLine("Chon Phuong Trinh");
            Console.WriteLine("1. Giai phuong trinh bac 1");
            Console.WriteLine("2. Tinh giai thua");
            Console.WriteLine("3. Tinh Tong hai so nguyen");
            Console.WriteLine("4. Tinh Hieu hai so nguyen");
            Console.WriteLine("5. Phep chia hai so nguyen");
            Console.WriteLine("6. Phep nhan hai so nguyen");
            Console.WriteLine("7. Giai Phuong trinh bac 2");
            Console.WriteLine("8. Tim so lon nhat");
            Console.WriteLine("8. Tim so be nhat");


            Console.WriteLine("Chon:");
            string chon = Console.ReadLine();
            switch(chon)
            {
                case "1": Phuongtrinhbac1(); break;
                case "2": Tinhgiaithua(); break;
                case "3": TinhTong(); break;
                case "4": TinhHieu(); break;
                case "5": TinhThuong(); break;
                case "6": TinhTich(); break;
                case "7": GiaiPhuongTrinhbac2(); break;
                case "8": Timsolonnhat(); break;
                case "9": Timsobenhat(); break;

                case "exit": return;
            }
            Console.WriteLine(" ");
            Menu();
        }

        private static void Timsobenhat()
        {
            double x, y, z;
            Console.WriteLine("Nhap vao so thu nhat");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Nhap vao so thu hai");
            double.TryParse(Console.ReadLine(), out y);
            Console.WriteLine("Nhap vao so thu ba");
            double.TryParse(Console.ReadLine(), out z);
            PhuongTrinh pt = new PhuongTrinh();
            double kq10 = pt.Timmin(x,y,z);

        }

        private static void Timsolonnhat()
        {
            double x, y, z;
            Console.WriteLine("Nhap vao so thu nhat ");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Nhap vao so thu hai");
            double.TryParse(Console.ReadLine(), out y);
            Console.WriteLine("Nhap vao so thu ba ");
            double.TryParse(Console.ReadLine(), out z);
            PhuongTrinh pt = new PhuongTrinh();
            double kq9 = pt.Timmax(x, y, z);
            Console.WriteLine("Ket Qua {0}", kq9);
        }

        private static void GiaiPhuongTrinhbac2()
        {
            double v12, v13,v14;
            Console.WriteLine("Nhap vao so thu nhat ");
            double.TryParse(Console.ReadLine(), out v12);
            Console.WriteLine("Nhap vao so thu hai");
            double.TryParse(Console.ReadLine(), out v13);
            Console.WriteLine("Nhap vao so thu ba ");
            double.TryParse(Console.ReadLine(), out v14);
            PhuongTrinh pt = new PhuongTrinh();
            double [] kq8 = pt.PhuongTrinhBacHai(v12, v13, v14);
            Console.WriteLine("Ket Qua nghiem thu 1 {0}", kq8[0]);
            Console.WriteLine("Ket Qua nghiem thu 2 {0}", kq8[1]);

        }

        private static void TinhTich()
        {
            double v10, v11;
            Console.WriteLine("Nhap vao so thu nhat ");
            double.TryParse(Console.ReadLine(), out v10);
            Console.WriteLine("Nhap vao so thu hai ");
            double.TryParse(Console.ReadLine(), out v11);
            PhuongTrinh pt = new PhuongTrinh();
            double kq7 = pt.Tich(v10, v11);
            Console.WriteLine("Ket Qua {0}", kq7);
        }

        private static void TinhThuong()
        {
            double v8, v9;
            Console.WriteLine("Nhap vao so thu nhat ");
            double.TryParse(Console.ReadLine(), out v8);
            Console.WriteLine("Nhap vao so thu hai ");
            double.TryParse(Console.ReadLine(), out v9);
            PhuongTrinh pt = new PhuongTrinh();
            double kq6 = pt.Thuong(v8, v9);
            Console.WriteLine("Ket Qua {0}", kq6);
        }

        private static void TinhHieu()
        {
            double v6, v7;
            Console.WriteLine("Nhap vao so thu nhat ");
            double.TryParse(Console.ReadLine(), out v6);
            Console.WriteLine("Nhap vao so thu hai ");
            double.TryParse(Console.ReadLine(), out v7);
            PhuongTrinh pt = new PhuongTrinh();
            double kq5 = pt.Hieu(v6, v7);
            Console.WriteLine("Ket Qua {0}", kq5);

        }

        private static void TinhTong()
        {
            double v4, v5;
            Console.WriteLine("Nhap vao so thu nhat ");
            double.TryParse(Console.ReadLine(), out v4);
            Console.WriteLine("Nhap vao so thu hai ");
            double.TryParse(Console.ReadLine(), out v5);
            PhuongTrinh pt = new PhuongTrinh();
            double kq4 = pt.Tong(v4, v5);
            Console.WriteLine("Ket Qua {0}", kq4);
        }

        private static void Tinhgiaithua()
        {
            int v3;
            Console.WriteLine("Nhap vao so c");
            int.TryParse(Console.ReadLine(), out v3);
            int kq1 = Tinhgiaithua(v3);
            Console.WriteLine("Ket qua {0}", kq1);

        }

        private static int Tinhgiaithua(int v3)
        {
            if (v3 == 1)
                return 1;
            return v3 * Tinhgiaithua(v3 - 1);
        
        }
        private static void Phuongtrinhbac1()
        {
            double v1, v2;
                    Console.WriteLine("Nhap Vao so a ");
            double.TryParse(Console.ReadLine(), out v1);
                    Console.WriteLine("Nhap Vao so b ");
            double.TryParse(Console.ReadLine(), out v2);
            PhuongTrinh pt = new PhuongTrinh();
            double kq = pt.PhuongTrinhBac1(v1, v2);
            Console.WriteLine("Ket qua {0}", kq);
        }

        private static double Phuongtrinhbac1(double v1, double v2)
            {
                if (v1 == 0)
                    if (v2 == 0)
                        throw new Exception("Phuong trinh vo so nghiem");
                    else
                        throw new Exception("Phuong trinh vo nghiem");
                Console.WriteLine("PT co nghiem la {0} ", -v2 / v1);
                return -v2 / v1;
            }

            private static void XinChao(string v)
            {
                Console.WriteLine("Xin chao! {0} ", v);
            }

            private static void XinChao()
            {
                Console.WriteLine("Xin Chao:");
            }
        }

        
    }

