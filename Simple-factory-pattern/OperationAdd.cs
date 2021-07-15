using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_factory_pattern
{
    /// <summary>
    /// 加法類別（繼承運算類別）
    /// </summary>
    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return (double)(NumberA + NumberB);
        }
    }
}
