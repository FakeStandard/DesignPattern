using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_method_pattern.calculate
{
    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return (double)(NumberA + NumberA);
        }
    }
}
