using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_factory_pattern
{
    /// <summary>
    /// 簡單工廠運算類別
    /// </summary>
    public class OperationFactory
    {
       public static Operation createOperate(string operate)
        {
            Operation oper = null;

            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
            }

            return oper;
        }
    }
}
