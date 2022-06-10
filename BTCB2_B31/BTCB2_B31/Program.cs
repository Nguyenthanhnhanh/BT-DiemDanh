using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2_B31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bang Cuu Chuong: ");
            for (int i139 = 1; i139 <= 10; i139++)
            {
                for (int j139 = 2; j139 <= 9; j139++)
                {
                    Console.Write("{0} x {1} = {2}  ---    ", j139, i139, j139 * i139);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}