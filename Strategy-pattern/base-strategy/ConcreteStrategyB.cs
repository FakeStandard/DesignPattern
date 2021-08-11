using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_pattern.base_strategy
{
    /// <summary>
    /// 具體演算法 B
    /// </summary>
    class ConcreteStrategyB : Strategy
    {
        /// <summary>
        /// 演算法 B 實現方法
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("實現演算法 B");
        }
    }
}
