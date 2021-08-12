using Proxy_pattern.base_proxy;
using System;

namespace Proxy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Base
            //Proxy proxy = new Proxy();
            //proxy.Request();

            SchoolGirl girl = new SchoolGirl();
            girl.Name = "嬌嬌";

            Agent agent = new Agent(girl);
            agent.GiveDolls();
            agent.GiveChocolate();
            agent.GiveFlowers();
        }
    }
}
