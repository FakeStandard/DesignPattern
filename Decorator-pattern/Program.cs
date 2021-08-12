using Decorator_pattern.base_decorator;
using System;

namespace Decorator_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //baseDecorator

            Person person = new Person("阿明");

            Console.WriteLine("第一種裝扮");

            Sneakers sneakers = new Sneakers();
            BigTrouser bigTrouser = new BigTrouser();
            TShirts shirts = new TShirts();

            sneakers.Decorate(person);
            bigTrouser.Decorate(sneakers);
            shirts.Decorate(bigTrouser);
            shirts.Show();
        }

        static void baseDecorator()
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();

            Console.ReadLine();
        }
    }
}
