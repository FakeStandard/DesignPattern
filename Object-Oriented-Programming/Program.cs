using System;

namespace Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            // 宣告名為離人劍的 swordman 物件並實體化
            Swordman swordman = new Swordman("離人劍");

            // 調用攻擊方法
            string attack = swordman.Attack();
            Console.WriteLine(attack);

            // 宣告不帶參數的 gm 物件並實體化
            Swordman gm = new Swordman();

            // 調用公告方法
            string announcement = gm.Announcement();
            Console.WriteLine(announcement);

            // 變更攻擊次數，指派屬性 Num 的值，新的值會調用 set 訪問器
            swordman.Num = 5;
            Console.WriteLine("\n變更攻擊次數為 5 次，開始攻擊！\n");
            Console.WriteLine(swordman.Attack());

            swordman.Num = 11;
            Console.WriteLine("\n變更攻擊次數為 11 次，開始攻擊！\n");
            Console.WriteLine(swordman.Attack());
            Console.WriteLine("\n因受到限制，實際上只攻擊了 10 次！\n");

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Swordman 類別
    /// </summary>
    class Swordman
    {
        // 名稱私有屬性
        private string name;

        // 攻擊次數私有欄位
        private int num = 1;

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

        /// <summary>
        /// 公告次數公開屬性，初始化為 3
        /// </summary>
        public int Count { get; set; } = 3;

        /// <summary>
        /// 空建構式
        /// </summary>
        public Swordman()
        {
            this.name = "GM大大";
        }

        /// <summary>
        /// 帶有 string 參數的建構式
        /// </summary>
        /// <param name="name"></param>
        public Swordman(string name)
        {
            this.name = name;
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
        /// 公開公告方法
        /// </summary>
        /// <returns></returns>
        public string Announcement()
        {
            string result = string.Empty;

            for (int i = 0; i < Count; i++)
            {
                result += "「明天早上10點進行更新」\n";
            }

            return name + "說：\n" + result + "很重要所以說三遍！";
        }
    }
}
