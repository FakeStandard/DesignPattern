using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_factory_pattern
{
    /// <summary>
    /// 乘法類別（繼承運算類別）
    /// </summary>
    public class OperationMul:Operation
    {
        public override double GetResult()
        {
            return (double)(NumberA * NumberB);
        }
    }
}
