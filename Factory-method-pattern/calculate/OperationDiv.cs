using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_method_pattern.calculate
{
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
                throw new Exception("除數不能為 0");

            return (double)(NumberA / NumberB);
        }
    }
}
