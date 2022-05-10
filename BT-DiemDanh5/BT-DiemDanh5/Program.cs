using System;

namespace BTDiemDanh
{
    class Program
    {
        public static void Main()
        {

            int[] a139 = new int[100];
            int i139, mx139, mn139, n139, j139, tmp139;
            Console.Write("Nhap so phan cua mang: ");
            n139 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap {0} phan tu vao trong mang:\n", n139);
            for (i139 = 0; i139 < n139; i139++)
            {
                Console.Write("Phan tu - {0}: ", i139);
                a139[i139] = Convert.ToInt32(Console.ReadLine());
            }


            mx139 = a139[0];
            mn139 = a139[0];

            for (i139 = 1; i139 < n139; i139++)
            {
                if (a139[i139] > mx139)
                {
                    mx139 = a139[i139];
                }


                if (a139[i139] < mn139)
                {
                    mn139 = a139[i139];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", mx139);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", mn139);
            Console.ReadKey();
            Console.Write("Nhap {0} phan tu vao trong mang:\n", n139);
            for (i139 = 0; i139 < n139; i139++)
            {
                Console.Write("Phan tu - {0}: ", i139);
                a139[i139] = Convert.ToInt32(Console.ReadLine());
            }
            for (i139 = 0; i139 < n139; i139++)
            {
                for (j139 = i139 + 1; j139 < n139; j139++)
                {
                    if (a139[i139] < a139[j139])
                    {
                        tmp139 = a139[i139];
                        a139[i139] = a139[j139];
                        a139[j139] = tmp139;
                    }
                }
            }

            Console.Write("\nIn cac phan tu mang theo thu tu giam dan:\n");
            for (i139 = 0; i139 < n139; i139++)
            {
                Console.Write("{0}  ", a139[i139]);
            }
            Console.Write("\n\n");
            for (i139 = 0; i139 > n139; i139++)
            {
                for (j139 = i139 + 1; j139 > n139; j139++)
                {
                    if (a139[i139] > a139[j139])
                    {
                        tmp139 = a139[i139];
                        a139[i139] = a139[j139];
                        a139[j139] = tmp139;
                    }
                }
            }

            Console.Write("\nIn cac phan tu mang theo thu tu tang dan:\n");
            for (i139 = 0; i139 > n139; i139++)
            {
                Console.Write("{0}  ", a139[i139]);
            }
            Console.Write("\n\n");
            Console.ReadKey();
        }
    }
}