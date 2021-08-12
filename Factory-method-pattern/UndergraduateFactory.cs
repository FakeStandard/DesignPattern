using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_method_pattern
{
    class UndergraduateFactory : INightingaleFactory
    {
        public Nightingale createNightingale()
        {
            return new Undergraduate();
        }
    }
}
