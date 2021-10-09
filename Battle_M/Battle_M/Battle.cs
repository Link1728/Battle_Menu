using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_M
{
    class Battle
    {

        public static int BattleCount = 0;
        static public int CurrentPlayerHealth = Player.CurrentHealth;

        public static void RandomBattle(int x, int y, ConsoleColor Color, int X1, int Y1, int X2, int Y2)
        {
            BattleCount = 0;
            Random rnd = new Random();

            int EnemyDamage = rnd.Next(x, y);
            int PlayerDamage = rnd.Next(x, y);

            //Console.SetCursorPosition(X1, Y1);
            //Console.ForegroundColor = Color;
            //Console.WriteLine(EnemyDamage);

            Console.SetCursorPosition(X2, Y2);
            Console.ForegroundColor = Color;
            Console.WriteLine(PlayerDamage + " Hit!");

            Player.Weapon();
            CurrentPlayerHealth = CurrentPlayerHealth - PlayerDamage;
            BattleCount++;

            Console.Read();
            PlayerDeath();

            
                                

        }

        public static void PlayerDeath()
        {
            Console.Read();
            if(CurrentPlayerHealth <= 0)
            {
                Console.SetCursorPosition(0, 20);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(CurrentPlayerHealth + "/" + Player.MaxHealth);

                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game Over");
                Console.Read();
                
            }

            else if(CurrentPlayerHealth != 0)
            {
                EnemyDeath();
            }

            //else if(CurrentPlayerHealth > Player.MaxHealth)
            //{
            //    CurrentPlayerHealth = Player.MaxHealth;
            //}
        }

        public static void EnemyDeath()
        {
            if (Enemy.CurrentEnemyHealth <= 0)
            {
                Console.SetCursorPosition(15, 0);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Enemy.CurrentEnemyHealth + "/" + Enemy.EnemyMaxHealth + " ");

                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enemy slain!");
                Console.Read();

            }

            else if (Enemy.CurrentEnemyHealth != 0)
            {
                NextRound();
            }
        }

        public static void NextRound()
        {
            if (BattleCount == 1)
            {
                Console.Clear();
                Player.DrawBattle();
                ScreenDraw.Draw();
                Battle_Interface.Draw();
            }
            else if(BattleCount != 1)
            {
                Console.Read();
            }
        }
    }
}
