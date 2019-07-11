using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaHua.Class1
{
    class Class1_4
    {
        public static Operation createOperation(string operate)
        {
            //宣告Operation物件
            Operation oper = null;  
            switch (operate)
            {
                case "+":
                    //物件實體化，叫做建構式，和類別同名，無返回值，也不須加void，在定義OperationAdd沒有OperationAdd()，系統會自動生成空的，單純實體化
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
            }
            return oper;
        }
    }
    public class Operation      //定義運算類別，public是為了讓其他地方使用
    {
        private double _numA = 0;
        private double _numB = 0;

        public double NumA { get => _numA; set => _numA = value; }//快速建構會自己跑出來
        public double NumB { get => _numB; set => _numB = value; }
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
    class OperationAdd: Operation  //繼承Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumA + NumB;
            return result;
        }
    }
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumA - NumB;
            return result;
        }
    }
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumA * NumB;
            return result;
        }
    }
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumB == 0)
            {
                throw new Exception("除數不能為0");
            }
            result = NumA / NumB;
            return result;
        }
    }
}
