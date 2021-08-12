using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_method_pattern.calculate
{
    interface IFactory
    {
        Operation createOperation();
    }
}
