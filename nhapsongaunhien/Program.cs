using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhapsongaunhien
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Nhap vao so a: ");
            a = int.Parse(Console.ReadLine());
            Random b = new Random();
            int kq = b.Next(0, 20);
            Console.WriteLine("Xuat ra ket qua {0}",kq );
            if (a == b.Next(0, 20))
            {
                Console.WriteLine("Ban da doan dung");
            }
            else
                Console.WriteLine("Ban da doan khong dung");
        }
    }
}
