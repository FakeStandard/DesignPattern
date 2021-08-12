using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_method_pattern.calculate
{
    class SubFactory : IFactory
    {
        public Operation createOperation()
        {
            return new OperationSub();
        }
    }
}
