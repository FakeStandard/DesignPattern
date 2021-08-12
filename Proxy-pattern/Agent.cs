using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_pattern
{
    class Agent : IGiveGift
    {
        Pursuit gg;

        public Agent(SchoolGirl mm)
        {
            gg = new Pursuit(mm);
        }

        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
    }
}
