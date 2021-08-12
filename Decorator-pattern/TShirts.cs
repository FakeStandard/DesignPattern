using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_pattern
{
    class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("大T恤 ");
            base.Show();
        }
    }
}
