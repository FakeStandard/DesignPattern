using Strategy_pattern.base_strategy;
using Strategy_pattern.simple_factory;
using System;

namespace Strategy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //First();
            //SimpleFactory();
            //BaseStrategy();
            CashStrategy();
        }

        static void CashStrategy()
        {
            Console.Write("請輸入單價:");
            double price = double.Parse(Console.ReadLine());
            Console.Write("請輸入數量:");
            double quantity = double.Parse(Console.ReadLine());
            Console.WriteLine("請選擇計算方式:");
            Console.WriteLine("1.正常收費");
            Console.WriteLine("2.滿 300 送 100");
            Console.WriteLine("3.打八折");
            string type = Console.ReadLine();
            Console.WriteLine();

            CashContext cashContext = new CashContext(type);
            double total = 0d;
            total = cashContext.GetResult(price * quantity);

            string result = $"單價:{price}, 數量:{quantity}, 計費方式:{type}, 合計:{total}";

            Console.WriteLine(result);

            Console.ReadLine();
        }

        static void BaseStrategy()
        {
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
        }

        static void SimpleFactory()
        {
            Console.Write("請輸入單價:");
            double price = double.Parse(Console.ReadLine());
            Console.Write("請輸入數量:");
            double quantity = double.Parse(Console.ReadLine());
            Console.WriteLine("請選擇計算方式:");
            Console.WriteLine("1.正常收費");
            Console.WriteLine("2.滿 300 送 100");
            Console.WriteLine("3.打八折");
            string type = Console.ReadLine();
            Console.WriteLine();

            CashSuper cSuper = CashFactory.createCashAccept(type);
            double total = 0d;
            total = cSuper.acceptCash(price * quantity);

            string result = $"單價:{price}, 數量:{quantity}, 計費方式:{type}, 合計:{total}";

            Console.WriteLine(result);

            Console.ReadLine();
        }

        static void First()
        {
            Console.Write("請輸入單價:");
            int price = int.Parse(Console.ReadLine());
            Console.Write("請輸入數量:");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("請選擇計算方式:");
            Console.WriteLine("1.正常收費");
            Console.WriteLine("2.打八折");
            Console.WriteLine("3.打七折");
            Console.WriteLine("4.打五折");
            int type = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double total = 0d;
            string typestr = "";
            switch (type)
            {
                case 1:
                    total = price * quantity;
                    typestr = "正常收費";
                    break;
                case 2:
                    total = price * quantity * 0.8;
                    typestr = "打八折";
                    break;
                case 3:
                    total = price * quantity * 0.7;
                    typestr = "打七折";
                    break;
                case 4:
                    total = price * quantity * 0.5;
                    typestr = "打五折";
                    break;
                default:
                    total = price * quantity;
                    typestr = "正常收費";
                    break;
            }

            string result = $"單價:{price}, 數量:{quantity}, 計費方式:{typestr}, 合計:{total}";

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
