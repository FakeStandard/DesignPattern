using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming
{
    /// <summary>
    /// 劍士
    /// </summary>
    class Swordman : CareerBasic
    {
        public Swordman(string name) : base(name) { }
        public Swordman() : base() { }

        // Swordman 複寫 父類別方法
        public override string PassiveSkill()
        {
            return name + base.PassiveSkill() + "攻擊弱點";
        }
    }
}
