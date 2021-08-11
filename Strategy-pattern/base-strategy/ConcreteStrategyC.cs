using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_pattern.base_strategy
{
    /// <summary>
    /// 具體演算法 C
    /// </summary>
    class ConcreteStrategyC : Strategy
    {
        /// <summary>
        /// 演算法 C 實現方法
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("實現演算法 C");
        }
    }
}
