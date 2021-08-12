using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_pattern.base_proxy
{
    /// <summary>
    /// 保存一個參考使得代理可以存取實體,並提供一個與 Subject 相同的介面
    /// 代理就可以用來代替實體
    /// </summary>
    class Proxy : Subject
    {
        RealSubject realSubject;
        public override void Request()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }

            realSubject.Request();
        }
    }
}
