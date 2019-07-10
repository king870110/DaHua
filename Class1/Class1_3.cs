using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaHua.Class1
{
    class Class1_3
    {
        //物件導向化
        public static double GetResult(double numA, double numB, string GetOperate)
        {
            double result = 0;
            switch (GetOperate)
            {
                case "+":
                    result = numA + numB;
                    break;
                case "-":
                    result = numA - numB;
                    break;
                case "*":
                    result = numA * numB;
                    break;
                case "/":
                    //因為result是int，在else的地方不能用string，只能給0，這邊還有待修正
                    if (numB != 0)
                    {
                        result = numA / numB;
                    }
                    else
                    {
                        result = 0;
                    }
                    
                    break;

            }
            return result;
        }
        static void Main(string[] args)
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
                //這邊寫Class1_3.GetResult....和GetResult是一樣的，因為都在同個類別裡
                string result = Convert.ToString(Class1_3.GetResult(Convert.ToDouble(a),Convert.ToDouble(b),operate));

                Console.WriteLine("Ans is " + result);


            }
            catch (Exception ex)
            {
                Console.WriteLine("輸入有誤" + ex.Message);
            }

            Console.Write("Press key to continue...");
            Console.ReadKey();
        }
    }
}
