using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_method_pattern.calculate
{
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            return (double)(NumberA - NumberB);
        }
    }
}
