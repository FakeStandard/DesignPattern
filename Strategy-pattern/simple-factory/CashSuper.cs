using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_pattern.simple_factory
{
    /// <summary>
    /// 現金收取抽象父類別,參數原原價,返回現價
    /// </summary>
    abstract class CashSuper
    {
        public abstract double acceptCash(double money);
    }
}
