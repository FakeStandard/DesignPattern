using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_pattern.simple_factory
{
    /// <summary>
    /// 正常收費,原價返回
    /// </summary>
    class CashNormal : CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }
}
