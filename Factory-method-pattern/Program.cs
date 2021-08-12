using Factory_method_pattern.calculate;
using System;

namespace Factory_method_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // calculate
            //IFactory factory = new AddFactory();
            //Operation operation = factory.createOperation();
            //operation.NumberA = 1;
            //operation.NumberB = 2;
            //double result = operation.GetResult();
            //Console.WriteLine(result);

            INightingaleFactory factory = new UndergraduateFactory();
            Nightingale nightingale = factory.createNightingale();

            nightingale.BuyRice();
            nightingale.Sweep();
            nightingale.Wash();
        }
    }
}
