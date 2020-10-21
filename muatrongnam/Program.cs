using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muatrongnam
{
    class Program
    {
        static void Main(string[] args)
        {
            int thang;
            Console.WriteLine("Nhap vao thang tuong ung: ");
            thang = int.Parse(Console.ReadLine());
            switch (thang)
            {
                case 1: Console.WriteLine("mua xuan"); break;
                case 2: Console.WriteLine("mua xuan"); break;
                case 3: Console.WriteLine("mua xuan"); break;
                case 4: Console.WriteLine("mua ha"); break;
                case 5: Console.WriteLine("mua ha"); break;
                case 6: Console.WriteLine("mua ha"); break;
                case 7: Console.WriteLine("mua thu"); break;
                case 8: Console.WriteLine("mua thu"); break;
                case 9: Console.WriteLine("mua thu"); break;
                case 10: Console.WriteLine("mua dong"); break;
                case 11: Console.WriteLine("mua dong"); break;
                case 12: Console.WriteLine("mua dong"); break;
                default: Console.WriteLine("nhap thang khong ton tai"); break;
            }
        }
    }
}