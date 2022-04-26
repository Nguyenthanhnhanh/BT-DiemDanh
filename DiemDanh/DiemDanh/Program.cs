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
            private double a139;
            private double b139;
            private double c139;
            public PhuongtrinhBac2(double a139, double b139, double c139)
            {
                this.a139 = a139;
                this.b139 = b139;
                this.c139 = c139;
            }
            public double A139{ get => a139; set => a139 = value; }
            public double B139 { get => b139; set =>a139 = value; }
            public double C139 { get => c139; set => c139 = value; }
            public double delta(double a139, double b139, double c139)
            {
                return b139 * b139 - 4 * c139 * a139;
            }
            public double Nghiem(double a139 , double b139 , double c139 )
            {
                double x1139,x2139;
                if (delta(a139, b139, c139) < 0)
                    return -1;
                else
                    if (delta(a139, b139, c139) == 0)
                    return 0;
                else
                    return 1;
            }
        }
    }
}
