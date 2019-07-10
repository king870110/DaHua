using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaHua.Class1
{
    class Class1_2
    {
        static void Main2(string[] args)
        {
            //相對於1-1是更好的版本
            //try catch 可以避免輸入非數字的錯誤
            try
            {
                Console.WriteLine("輸入第1個數字A:");
                string a = Console.ReadLine();
                Console.WriteLine("輸入+.-.*./");
                string operate = Console.ReadLine();
                Console.WriteLine("輸入第2個數字B:");
                string b = Console.ReadLine();
                string result = " ";

                //如果用1-1的方法，寫4次if判斷太多了，switch指判斷一次相對來說較好
                switch (operate)
                {
                    case "+":
                        result = Convert.ToString(Convert.ToDouble(a) + Convert.ToDouble(b));
                        break;
                    case "-":
                        result = Convert.ToString(Convert.ToDouble(a) - Convert.ToDouble(b));
                        break;
                    case "*":
                        result = Convert.ToString(Convert.ToDouble(a) * Convert.ToDouble(b));
                        break;
                    case "/":
                        if (b != "0")
                        {
                            result = Convert.ToString(Convert.ToDouble(a) / Convert.ToDouble(b));
                        }
                        else
                        {
                            result = "b不可為0";
                        }
                        break;

                }
                Console.WriteLine("Ans is " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("輸入有誤"+ex.Message);
            }
            Console.Write("Press key to continue...");
            Console.ReadKey();
        }
    }
}
