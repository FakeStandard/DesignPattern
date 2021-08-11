using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_pattern.base_strategy
{
    /// <summary>
    /// 定義所有支援的演算法的公共介面
    /// </summary>
    abstract class Strategy
    {
        /// <summary>
        /// 演算法方法
        /// </summary>
        public abstract void AlgorithmInterface();
    }
}
