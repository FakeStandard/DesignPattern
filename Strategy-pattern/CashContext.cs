using Strategy_pattern.simple_factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_pattern
{
    class CashContext
    {
        private CashSuper cs;

        public CashContext(string type)
        {
            switch (type)
            {
                // 正常收費
                case "1":
                    cs = new CashNormal();
                    break;
                // 滿 300 送 100
                case "2":
                    CashReturn cReturn = new CashReturn("300", "100");
                    cs = cReturn;
                    break;
                // 打 8 折
                case "3":
                    CashRebate cRebate = new CashRebate("0.8");
                    cs = cRebate;
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}
