using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_pattern
{
    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("垮褲 ");
            base.Show();
        }
    }
}
