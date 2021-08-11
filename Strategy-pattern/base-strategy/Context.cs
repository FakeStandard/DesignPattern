using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_pattern.base_strategy
{
    /// <summary>
    /// 上下文
    /// </summary>
    class Context
    {
        Strategy strategy;

        /// <summary>
        /// 初始化時,傳入具體的策略物件
        /// </summary>
        /// <param name="strategy"></param>
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        /// <summary>
        /// 根據具體的策略物件,調用其演算法物件
        /// </summary>
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
