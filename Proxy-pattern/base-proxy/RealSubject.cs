using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_pattern.base_proxy
{
    /// <summary>
    /// 定義 Proxy 所代表的真實實體
    /// </summary>
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("真實請求");
        }
    }
}
