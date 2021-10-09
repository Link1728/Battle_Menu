using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_M
{
    class Enemy
    {
        static public string HeadArmour;
        static public int HeadDef = 0;
        static public string ChestArmour;
        static public int ChestDef = 0;
        static public string LegArmour;
        static public int LegDef = 0;

        static public int EnemyMaxHealth = 100;
        static public int EnemyLevel = 1;
        static public int CurrentEnemyHealth = EnemyMaxHealth;



        public static void Draw()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(15, 0);
            Console.WriteLine(CurrentEnemyHealth + "/" + EnemyMaxHealth);
        }

        public static void Armour()
        {
            Random rnd = new Random();

        }

        public static void Weapon()
        {

        }

        public static void EnemyChooser()
        {

        }

    }
}
