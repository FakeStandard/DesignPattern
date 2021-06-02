using System;

namespace Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Thief thief = new Thief();
            thief.Num = 5;
            Console.WriteLine(thief.Attack());
            Console.WriteLine(thief.PassiveSkill());

            // 宣告名為離人劍的 swordman 物件並實體化
            Swordman swordman = new Swordman("離人劍");

            // 調用攻擊方法
            string attack = swordman.Attack();
            Console.WriteLine(attack);

            // 宣告不帶參數的 gm 物件並實體化
            Swordman gm = new Swordman();

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
}
