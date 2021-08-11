using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_pattern.simple_factory
{
    /// <summary>
    /// 現今收取工廠
    /// </summary>
    class CashFactory
    {
        public static CashSuper createCashAccept(string type)
        {
            CashSuper cs = null;

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

            return cs;
        }
    }
}
