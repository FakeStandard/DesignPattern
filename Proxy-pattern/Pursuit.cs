using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_pattern
{
    class Pursuit : IGiveGift
    {
        SchoolGirl mm;
        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }
        public void GiveChocolate()
        {
            Console.WriteLine($"{mm.Name}送妳巧克力!");
        }

        public void GiveDolls()
        {
            Console.WriteLine($"{mm.Name}送妳洋娃娃!");
        }

        public void GiveFlowers()
        {
            Console.WriteLine($"{mm.Name}送妳鮮花!");
        }
    }
}
