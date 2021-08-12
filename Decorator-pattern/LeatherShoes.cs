using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_pattern
{
    class LeatherShoes : Finery
    {
        public override void Show()
        {
            Console.Write("皮鞋 ");
            base.Show();
        }
    }
}
