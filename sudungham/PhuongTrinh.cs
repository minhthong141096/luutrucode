using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudungham
{
    class PhuongTrinh
    {/// <summary>
     /// Tinh tong 2 so nguyen (tuong tu nhu Random)
     /// </summary>
     /// <param name="a"></param>
     /// <param name="b"></param>
     /// <returns></returns>
        public double Tong(double a, double b)
        {
            return a + b;
        }
        public double Hieu(double c, double d)
        {
            return c - d;
        }
        public double Thuong(double c, double d)
        {
            return c / d;
        }
        public double Tich(double c, double d)
        {
            return c * d;
        }

        public double PhuongTrinhBac1(double v1, double v2)
        {
            if (v1 == 0)
                if (v2 == 0)
                    throw new Exception("Phuong trinh vo so nghiem");
                else
                    throw new Exception("Phuong trinh vo nghiem");
            Console.WriteLine("PT co nghiem la {0} ", -v2 / v1);
            return -v2 / v1;
        }

        public double[] PhuongTrinhBacHai(double v12, double v13, double v14)
        {
            if (v12 == 0)
                throw new Exception("Khong Phai phuong trinh bac 2");
            double d = v13*v13 - 4 * v12 * v14;
            if(d<0)
                throw new Exception("Vo nghiem");
            double[] nghiem = new double[2];
            nghiem[0] = (-v13 + Math.Sqrt(d)) / (2 * v12);
            nghiem[1] = (-v13 - Math.Sqrt(d)) / (2 * v12);
            return nghiem;
        }

        public double Timmax(double x, double y, double z)
        {
            double max = x;
            if (max < y)
                max=y;
            if (max < z)
                max = z;
            return max;
        }

        internal double Timmin(double x, double y, double z)
        {
            double min = x;
            if (min > y)
                min = y;
            if (min > z)
                min = z;
            return min;
        }
    }
}
