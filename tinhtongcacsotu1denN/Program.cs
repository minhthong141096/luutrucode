using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitoanvonglap
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  #region tinh tong tu 1 den n
              int n,tong = 0;
              Console.WriteLine("Nhap cac so n: ");
              n = int.Parse(Console.ReadLine());
              for (int i = 1; i <= n; i++)
              {
                  tong = tong + i;  
              }
              Console.WriteLine("tong tu 1 toi {1} la {0}", tong, n);
              #endregion
              #region Tinh n!
              int a;
              int giaithua = 1;
              Console.WriteLine("Nhap so a: ");
              a = int.Parse(Console.ReadLine());
              for(int j=1;j<=a;j++)
              {
                  giaithua = giaithua * j;
              }
              Console.WriteLine("Giai thua cua {0}! = {1}", a, giaithua);
              #endregion
              #region Tinh tong day so
              {
                  double b, p=1, s = 0;  
                  Console.WriteLine("Nhap so b ");
                  b = double.Parse(Console.ReadLine());
                  for(int k=1;k<=b;k++)
                      //Cach 1 
                  //{
                    //  p = p * k; 
                      //s = s + (1 / p);
                  //}
                  //Cach 2
                  {
                      s = s + (double)(1.0 / k);
                  }
                  Console.WriteLine("tong day so= {0}", s );

              }
              #endregion*/
            int soNguyen;
            for (; ; )
            {
                bool kt = int.TryParse(Console.ReadLine(), out soNguyen);
                if (kt == true)
                {
                    break;
                }
                Console.WriteLine("nhap lai so nguyen");
            }
        }
    }
}
