using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming
{
    /// <summary>
    /// 職業基礎類別
    /// </summary>
    class CareerBasic
    {
        /// <summary>
        /// 改為保護層級供子類別存取
        /// </summary>
        protected string name = string.Empty;

        protected int num = 2;

        /// <summary>
        /// 攻擊次數公開屬性
        /// </summary>
        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                // 給予限制
                if (value >= 10)
                    num = 10;
                else
                    num = value;
            }
        }

        public CareerBasic(string name)
        {
            this.name = name;
        }
        public CareerBasic()
        {
            this.name = "GM大大";
        }

        /// <summary>
        /// 公開攻擊方法
        /// </summary>
        /// <returns></returns>
        public string Attack()
        {
            string result = string.Empty;

            for (int i = 0; i < num; i++)
            {
                result += name + "使出" + "「基本攻擊」\n";
            }

            return result;
        }

        /// <summary>
        /// 父類別加入虛擬方法，讓子類別可以複寫
        /// </summary>
        /// <returns></returns>
        public virtual string PassiveSkill()
        {
            return " 使出被動技能： ";
        }
    }
}
