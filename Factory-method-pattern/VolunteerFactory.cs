using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_method_pattern
{
    class VolunteerFactory : INightingaleFactory
    {
        public Nightingale createNightingale()
        {
            return new Volunteer();
        }
    }
}
