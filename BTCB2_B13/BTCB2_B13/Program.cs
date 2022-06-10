using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2_B13
{
    class Program
    {
        static void Main(string[] args)
        {
            int d139, m139, y139, top, dayofweek;
            Console.Write("Nhap vao ngay = ");
            d139 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao thang = ");
            m139 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao nam = ");
            y139 = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (d139 < 1 || d139 > 31)
                {
                    Console.WriteLine("Ngay ko hop le");
                    break;
                }
                if (m139 < 1 || m139 > 12)
                {
                    Console.WriteLine("Thang ko hop le");
                    break;
                }
                if (y139 < 1582)
                {
                    Console.WriteLine("Nam ko hop le");
                    break;
                }
                switch (m139)
                {
                    case 4:
                        {
                            top = 30;
                            break;
                        }
                    case 6:
                        {
                            top = 30;
                            break;
                        }
                    case 9:
                        {
                            top = 30;
                            break;
                        }
                    case 11:
                        {
                            top = 30;
                            break;
                        }
                    case 2:
                        {
                            if ((y139 % 4 == 0 && y139 % 100 != 0) || (y139 % 400 == 0))
                            {
                                top = 29;
                                break;
                            }
                            else
                            {
                                top = 28;
                                break;
                            }

                        }
                    default:
                        {
                            top = 31;
                            break;
                        }
                }
                Console.WriteLine("Hop le.");
                y139 -= (14 - m139) / 12;
                m139 += 12 * ((14 - m139) / 12) - 2;
                dayofweek = (d139 + y139 + y139 / 4 - y139 / 100 + y139 / 400 + (31 * m139) / 12) % 7;
                if (dayofweek == 0)
                {
                    Console.WriteLine("Chu nhat");
                    break;
                }
                else
                {
                    dayofweek++;
                    Console.WriteLine("Thu " + dayofweek);
                    break;
                }
            }
            Console.ReadKey();
        }

    }
}