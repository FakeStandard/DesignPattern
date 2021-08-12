using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_method_pattern.calculate
{
    class AddFactory : IFactory
    {
        public Operation createOperation()
        {
            return new OperationAdd();
        }
    }
}
