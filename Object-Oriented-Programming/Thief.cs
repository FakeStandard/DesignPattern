using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming
{
    /// <summary>
    /// 繼承格式寫法為 => 子類別 : 父類別
    /// </summary>
    class Thief : CareerBasic
    {
        /// <summary>
        /// 調用父類別相同參數類型的建構式，用 base 關鍵字代表父類別
        /// </summary>
        /// <param name="name"></param>
        public Thief(string name) : base(name) { }

        /// <summary>
        /// 原本調用父類別空的建構式，讓子類別重寫
        /// </summary>
        public Thief()
        {
            name = "兩把刀";
        }

        /// <summary>
        /// 調用父類別空的建構式，一樣使用 base 關鍵字來代表父類別
        /// </summary>
        //public Thief() : base() { }

        // Thief 複寫 父類別方法
        public override string PassiveSkill()
        {
            return name + base.PassiveSkill() + "二刀連擊";
        }
    }
}
