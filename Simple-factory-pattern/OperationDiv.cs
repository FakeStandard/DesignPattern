using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_factory_pattern
{
    /// <summary>
    /// 除法類別（繼承運算類別）
    /// </summary>
    public class OperationDiv:Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
                throw new Exception("除數不能為 0");

            return (double)(NumberA / NumberB);
        }
    }
}
