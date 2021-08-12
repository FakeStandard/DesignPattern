using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_pattern
{
    class Person
    {
        private string name;
        public Person() { }
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"裝扮的{name}");
        }
    }
}
