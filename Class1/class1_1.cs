using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaHua
{
    class class1_1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("輸入第1個數字A:");
            string a = Console.ReadLine();
            Console.WriteLine("輸入+.-.*./");
            string operate = Console.ReadLine();
            Console.WriteLine("輸入第2個數字B:");
            string b = Console.ReadLine();

            if (operate == "+")
            {
                Console.WriteLine(Convert.ToDouble(a) + Convert.ToDouble(b));
            }
            else if (operate == "-")
            {
                Console.WriteLine(Convert.ToDouble(a) - Convert.ToDouble(b));
            }
            else if (operate == "*")
            {
                Console.WriteLine(Convert.ToDouble(a) * Convert.ToDouble(b));
            }
            else if (operate == "/")
            {
                if (Convert.ToDouble(b) != 0)
                {
                    Console.WriteLine(Convert.ToDouble(a) / Convert.ToDouble(b));
                }
                else
                {
                    Console.WriteLine("B不能為0");
                }
            }
            else
            {
                Console.WriteLine("輸入有誤");
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
