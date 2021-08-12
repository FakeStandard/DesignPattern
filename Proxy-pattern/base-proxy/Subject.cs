using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_pattern.base_proxy
{
    /// <summary>
    /// 定義 RealSubject 和 Proxy 共用介面
    /// </summary>
    abstract class Subject
    {
        public abstract void Request();
    }
}
