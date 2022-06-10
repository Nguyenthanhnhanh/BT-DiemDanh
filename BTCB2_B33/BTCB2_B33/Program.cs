using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2_B33
{
    class Program
    {
        static void Main(string[] args)
        {
            int demcs139;
            double tong139;
            Console.WriteLine("So ArmsTrong co 3,4 Chu so: ");
            for (int i139 = 100; i139 <= 9999; i139++)
            {
                tong139 = 0;
                if (i139 <= 999)
                {
                    demcs139 = 3;
                }
                else
                {
                    demcs139 = 4;
                }
                int t139 = i139;
                while (t139 != 0)
                {
                    int x139 = t139 % 10;
                    tong139 += Math.Pow(x139, demcs139);
                    t139 = t139 / 10;
                }
                if (tong139 == i139)
                {
                    Console.Write(i139 + " ");
                }
            }
            Console.ReadKey();
        }
    }
}