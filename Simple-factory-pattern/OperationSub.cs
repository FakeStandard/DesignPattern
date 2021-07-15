using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_factory_pattern
{
    public class OperationSub:Operation
    {
        /// <summary>
        /// 減法類別（繼承運算類別）
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            return (double)(NumberA - NumberB);
        }
    }
}
