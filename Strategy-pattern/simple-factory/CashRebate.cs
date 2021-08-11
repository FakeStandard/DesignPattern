using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_pattern.simple_factory
{
    /// <summary>
    /// 打折收費
    /// </summary>
    class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;

        /// <summary>
        /// 初始化時必須輸入折扣率, ex:0.8
        /// </summary>
        /// <param name="moneyRebate"></param>
        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }
        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
