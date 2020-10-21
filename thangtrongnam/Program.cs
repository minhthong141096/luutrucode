using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thangtrongnam
{
    class Program
    {
        static void Main(string[] args)
        {
            int thang, nam;
            Console.WriteLine("nhap thang : ");
            thang = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap nam : ");
            nam = int.Parse(Console.ReadLine());
            if (thang == 2)
            {
                if (nam % 4 == 0 && nam % 100 > 0)
                {
                    Console.WriteLine("Thang 2 co 29 ngay");
                }
                else
                {
                    Console.WriteLine("thang 2 co 28 ngay");
                }
            }
            else
            {
                switch (thang)
                {
                    case 1: Console.WriteLine("Thang 1 co 31 ngay"); break;

                    case 3: Console.WriteLine("Thang 3 co 31 ngay"); break;

                    case 4: Console.WriteLine("Thang 4 co 30 ngay"); break;

                    case 5: Console.WriteLine("Thang 5 co 31 ngay"); break;

                    case 6: Console.WriteLine("Thang 6 co 30 ngay"); break;

                    case 7: Console.WriteLine("Thang 7 co 31 ngay"); break;

                    case 8: Console.WriteLine("Thang 8 co 31 ngay"); break;

                    case 9: Console.WriteLine("Thang 9 co 30 ngay"); break;

                    case 10: Console.WriteLine("Thang 10 co 31 ngay"); break;

                    case 11: Console.WriteLine("Thang 11 co 30 ngay"); break;

                    case 12: Console.WriteLine("Thang 12 co 31 ngay"); break;
                    default: Console.WriteLine("Nhap Thang khong phu hop"); break;
                }
            }
        }
    }
}
