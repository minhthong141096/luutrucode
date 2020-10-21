using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaiphuongtrinhbac2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, d, x;
            Console.WriteLine("Nhap vao so a: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao so b: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao so c: ");
            c = float.Parse(Console.ReadLine());
            d = b * b - 4 * a * c;
            if (a == 0)
            {
                Console.WriteLine("Phuong trinh vo nghia");
            }
            else
            {

                if (d > 0)
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet x1={0}, x2={1}", (-b + Math.Sqrt(d)) / 2 * a, (-b - Math.Sqrt(d)) / 2 * a);
                }
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
    }
}
