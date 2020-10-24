using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudungmang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masinhvien = { 1, 2, 3, 4, 5, 8, 99};
            string[] danhsachtensinhvien = new string[3];
            for (int i = 0; i < masinhvien.Length; i++)
            {
                Console.WriteLine("Phan tu thu {0} la {1}", i, masinhvien[i]);
            }
            for (int k = 0; k < danhsachtensinhvien.Length; k++)
            {
                Console.WriteLine("Nhap ten sinh vien thu {0}  ", k+1);
                danhsachtensinhvien[k] = Console.ReadLine();
            }
            for (int j = 0; j < danhsachtensinhvien.Length; j++)
            {
                Console.WriteLine("Ten sinh vien thu {0} la {1}", j + 1,danhsachtensinhvien[j]);
                
            }
            Array.Sort(masinhvien);
            
        }
    }
}
