using System;

namespace Simple_factory_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper;
            double result = 0.00;

            // 加法
            oper = OperationFactory.createOperate("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            result = oper.GetResult();

            Console.WriteLine($"{oper.NumberA} + {oper.NumberB} = {result}");

            // 減法
            oper = OperationFactory.createOperate("-");
            oper.NumberA = 1;
            oper.NumberB = 2;
            result = oper.GetResult();

            Console.WriteLine($"{oper.NumberA} - {oper.NumberB} = {result}");

            // 乘法
            oper = OperationFactory.createOperate("*");
            oper.NumberA = 1;
            oper.NumberB = 2;
            result = oper.GetResult();

            Console.WriteLine($"{oper.NumberA} * {oper.NumberB} = {result}");

            // 除法
            oper = OperationFactory.createOperate("/");
            oper.NumberA = 1;
            oper.NumberB = 2;
            result = oper.GetResult();

            Console.WriteLine($"{oper.NumberA} / {oper.NumberB} = {result}");

            // 除法 除數為 0 的錯誤
            oper = OperationFactory.createOperate("/");
            oper.NumberA = 1;
            oper.NumberB = 0;
            result = oper.GetResult();

            Console.WriteLine($"{oper.NumberA} / {oper.NumberB} = {result}");
        }
    }
}
