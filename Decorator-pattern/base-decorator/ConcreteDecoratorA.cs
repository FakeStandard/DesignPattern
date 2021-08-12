using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_pattern.base_decorator
{
    class ConcreteDecoratorA : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("具體裝飾物件A的操作");
        }
    }
}
