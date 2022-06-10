using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2_B21
{
    class Program
    {
        static void Main(string[] args)
        {
            double dc139, d1139, d2139, d3139, sum;
            char kv139, dt139;
            Console.Write("Nhap diem chuan: ");
            dc139 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap diem 3 mon thi: ");
            Console.Write("Mon 1: ");
            d1139 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mon 2:");
            d2139 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mon 3: ");
            d3139 = Convert.ToDouble(Console.ReadLine());
            if (d1139 * d2139 * d3139 != 0)
            {
                Console.Write("Nhap vao khu vuc (A,B,C,X): ");
                kv139 = Convert.ToChar(Console.ReadLine());
                Console.Write("Nhap vao doi tuong(1,2,3,0): ");
                dt139 = Convert.ToChar(Console.ReadLine());
                sum = d1139 + d2139 + d3139;
                switch (kv139)
                {
                    case 'A':
                        {
                            sum += 2;
                            break;
                        }
                    case 'B':
                        {
                            sum += 1;
                            break;
                        }
                    case 'C':
                        {
                            sum += 0.5;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

                switch (dt139)
                {
                    case '1':
                        {
                            sum += 2.5;
                            break;
                        }
                    case '2':
                        {
                            sum += 1.5;
                            break;
                        }
                    case '3':
                        {
                            sum += 1;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                if (sum >= dc139)
                {
                    Console.WriteLine("Dau - " + sum);
                }
                else
                {
                    Console.WriteLine("Rot - " + sum);
                }
            }
            else
            {
                Console.WriteLine("Rot - " + (d1139 + d2139 + d3139));
            }
            Console.ReadKey();
        }
    }
}