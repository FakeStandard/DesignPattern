using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_pattern
{
    class Sneakers : Finery
    {
        public override void Show()
        {
            Console.Write("球鞋 ");
            base.Show();
        }
    }
}
