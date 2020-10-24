using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vonglapwhile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Uoc chung lon nhat
            int a, b;
            Console.WriteLine("Nhap vao so a ");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Nhap vao so b ");
            int.TryParse(Console.ReadLine(), out b);
            //0*1=0=>while sai (5)
            while (a * b > 0)
            {

                //10>3(1)
                //1>3 false=>if sai(3)
                if (a > b)
                {
                    //10%3=1(2)
                    a = a % b;
                }
                //3%1=0(4)
                else
                    b = b % a;
            }
            Console.WriteLine("UCLN la : {0}", a + b);
            #endregion
            #region La so nguyen to
            {
                int c;
                Console.WriteLine("Nhap so c: ");
                int.TryParse(Console.ReadLine(), out c);
                int i = 2;
                while (i <= c)
                {
                    if (c % i == 0)
                    {
                        if (c == i)
                        {
                            Console.WriteLine("La so nguyen to");
                        }
                        else
                            Console.WriteLine("Khong la nguyen to");
                        break;
                    }
                    else
                        i++;

                }
            }
            #endregion
            #region Do_While
            {
                int d;
                bool kt;
                Console.WriteLine("Nhap so nguyen: ");
                do
                {

                    kt = int.TryParse(Console.ReadLine(), out d);
                    Console.WriteLine("Nhap lai ");
                    if (kt == true)
                    {
                        if (d <= 0)
                        {
                            kt = false;
                        }
                    }
                } while (kt == false);

            }
            #endregion
        }
    }
}


