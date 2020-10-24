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
                Console.WriteLine("Nhap Vao so a ");
                double v1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap Vao so b ");
                double v2 = double.Parse(Console.ReadLine());
                double kq =Phuongtrinhbac1(v1, v2);
                Console.WriteLine(kq);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
