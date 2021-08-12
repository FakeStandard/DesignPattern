using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_pattern
{
    class Finery : Person
    {
        protected Person component;

        /// <summary>
        /// 裝扮
        /// </summary>
        /// <param name="component"></param>
        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component != null)
                component.Show();
        }
    }
}
