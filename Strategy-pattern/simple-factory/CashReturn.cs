using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_pattern.simple_factory
{
    /// <summary>
    /// 紅利收費
    /// </summary>
    class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;

        /// <summary>
        /// 初始化時,必須輸入紅利條件和紅利值
        /// </summary>
        /// <param name="moneyCondition"></param>
        /// <param name="moneyReturn"></param>
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }
        public override double acceptCash(double money)
        {
            double result = money;

            if (money >= moneyCondition)
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;

            return result;
        }
    }
}
