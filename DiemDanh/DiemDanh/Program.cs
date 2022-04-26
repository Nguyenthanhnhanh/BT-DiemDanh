using System;

namespace DiemDanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        class PhuongtrinhBac2
        {
            private double a;
            private double b;
            private double c;
            public PhuongtrinhBac2(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public double A{ get => a; set => a = value; }
            public double B { get => b; set =>a = value; }
            public double C { get => c; set => c = value; }
            public double delta(double a, double b, double c)
            {
                return a * b + c * c;
            }
            public double Nghiem(double a , double b , double c )
            {
                double x1,x2;
                if (delta(a, b, c) < 0)
                    return -1;
                else
                    if (delta(a, b, c) == 0)
                    return 0;
                else
                    return 1;
            }
        }
    }
}
