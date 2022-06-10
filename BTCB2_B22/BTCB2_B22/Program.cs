using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2_B22
{
    class Program
    {
        static void Main(string[] args)
        {
            int d139, t139, so139;
            Console.Write("nhap vao so: ");
            so139 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cac uoc so:");
            d139 = 0;
            t139 = 0;
            for (int i139 = 1; i139 <= so139; i139++)
            {
                if (so139 % i139 == 0)
                {
                    d139++;
                    t139 += i139;
                    Console.Write(" " + i139);

                }

            }
            Console.WriteLine("\nSo uoc: " + d139);
            Console.WriteLine("Tong cac uoc: " + t139);
            Console.ReadKey();
        }
    }
}