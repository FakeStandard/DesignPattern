using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_pattern
{
    class Suit : Finery
    {
        public override void Show()
        {
            Console.Write("西裝 ");
            base.Show();
        }
    }
}
