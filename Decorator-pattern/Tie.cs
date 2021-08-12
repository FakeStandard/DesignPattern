using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_pattern
{
    class Tie : Finery
    {
        public override void Show()
        {
            Console.Write("領帶 ");
            base.Show();
        }
    }
}
