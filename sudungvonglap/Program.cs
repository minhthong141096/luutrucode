using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudungvonglap
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vong lap for
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("xin chao {0}", i);
                }
            }
            #endregion
            #region Nhap day so tu ban phim
            int a;
            Console.WriteLine("Nhap so a : ");
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
            #region Bang cuu chuong
            //int b;
            //Console.WriteLine("Nhap mot so bat ki");
            //b = int.Parse(Console.ReadLine());
            Console.WriteLine("Bang cuu chuong");
            for (int i = 2; i <= 9; i++)
            {
                for (int k = 2; k <= 10; k++)
                {
                    Console.WriteLine("{0} x {1}= {2} ", i,k, i *k);
                }
              
            }
            #endregion
            
        }
    }
}

