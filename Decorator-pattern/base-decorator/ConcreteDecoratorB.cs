using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_pattern.base_decorator
{
    class ConcreteDecoratorB:Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具體裝飾物件 B 的操作");

        }

        private void AddedBehavior()
        {
            Console.WriteLine("物件 B 的操作方法");
        }
    }
}
