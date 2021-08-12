using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_pattern.base_decorator
{
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具體物件的操作");
        }
    }
}
