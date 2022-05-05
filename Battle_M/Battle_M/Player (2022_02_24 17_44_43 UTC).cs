using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Battle_M
{
    class Player
    {
        static public string Name;
        static public string UserColor;

        static public int Gold = 0;
        static public int Experience = 0;
        static public int Level = 0;
        static public int CurrentHealth = 999;
        static public int MaxHealth = 999;

        static public int CurrentDefense = 25;
        static public int MaxDefense = 25;
        static public int MailDefense = 0;
        static public int ArmourDefense = 0;
        static public int OverAllDefense = 0;

        //Not currently used
        static public int Score = 0;
        static public int HighScore = 0;

        static public int wDamage = 0;
        static public int CurrentDamage = 0;


        public static void Draw()
        {
            Console.WriteLine("Highscore: " + HighScore);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("What is your name? ");
            Name = Console.ReadLine();
            ColorDeterminator("What is your favorite color? ");
            Console.Clear();          

        }

        public static void DrawBattle()
        {
            Console.SetCursorPosition(60, 0);
            Console.Write(Name);
            Console.SetCursorPosition(0, 20);
            Console.Write(Battle.CurrentPlayerHealth + "/" + MaxHealth);
            Console.SetCursorPosition(0, 23);
            Console.WriteLine(CurrentDefense + "/" + MaxDefense);
            Console.SetCursorPosition(18, 19);
            Console.WriteLine(Level);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(0, 19);
            Console.WriteLine("Health:");
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("Defence:");
            Console.SetCursorPosition(11, 19);
            Console.WriteLine("Level: ");

            Armour(true, true, true);
            Mail(true, true, true);
            OverAllDefense = ArmourDefense + MailDefense;

            Console.SetCursorPosition(11, 21);
            Console.WriteLine(OverAllDefense + "% Defence");


        }

        static void ColorDeterminator(string Question)
        {
            Console.Write(Question);
            UserColor = Console.ReadLine();

            while (true)
            {
                if (UserColor == "Blue" || UserColor == "blue")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                }
                else if (UserColor == "Cyan" || UserColor == "cyan")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                }
                else if (UserColor == "Dark Blue" || UserColor == "dark blue")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                }
                else if (UserColor == "Dark Cyan" || UserColor == "dark cyan")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                }
                else if (UserColor == "Dark Gray" || UserColor == "dark gray" || UserColor == "Grey" || UserColor == "grey")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                }
                else if (UserColor == "Dark Green" || UserColor == "dark green")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                }
                else if (UserColor == "Dark Magenta" || UserColor == "dark magenta")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                }
                else if (UserColor == "Dark Red" || UserColor == "dark red")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                }
                else if (UserColor == "Dark Yellow" || UserColor == "dark yellow")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                }
                else if (UserColor == "Gray" || UserColor == "gray" || UserColor == "Grey" || UserColor == "grey")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }
                else if (UserColor == "Green" || UserColor == "green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                }
                else if (UserColor == "Magenta" || UserColor == "magenta")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                }
                else if (UserColor == "Red" || UserColor == "red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                }
                else if (UserColor == "White" || UserColor == "white")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                else if (UserColor == "Yellow" || UserColor == "yellow")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
        }

        //Not used...yet
        static public void Weapon()
        {
            Console.SetCursorPosition(57, 12);
            Random rnd = new Random();
            Random rndW = new Random();
            Random rndT = new Random();

            int wD = 0;
            int weapon = 1;
            if (weapon == 1)
            {
                //Console.WriteLine("Sword");
                wD = rnd.Next(0, 11);
                wDamage = rnd.Next(5, 11);
                if (wD == 6 || wD == 9)
                {
                    Console.WriteLine("Miss!");
                    Battle.NextRound();
                }

                if (wD == 5)
                {
                    wDamage = wDamage * 2;
                    Enemy.CurrentEnemyHealth = Enemy.CurrentEnemyHealth - wDamage;
                    Console.WriteLine(wDamage + " -Double");
                    Console.SetCursorPosition(63, 13);
                    Console.WriteLine("Strike!");
                }
                else if(wD != 5 && wD != 6 && wD != 9)
                {
                    Enemy.CurrentEnemyHealth = Enemy.CurrentEnemyHealth - wDamage;
                    Console.WriteLine(wDamage + " -Enemy HP");
                }
                    

                    

            }
            else if (weapon == 2)
            {
                Console.WriteLine("Lance");
                wDamage = 15;
            }
            else if (weapon == 3)
            {
                Console.WriteLine("Bow");
                wDamage = 40;
            }
        }

        static public void Armour(bool HeadArmour, bool ChestArmour, bool LegArmour)
        {
            while(true)
            {
                if ((HeadArmour == true && ChestArmour == false && LegArmour == false)
                    || (HeadArmour == false && ChestArmour == true && LegArmour == false)
                    || (HeadArmour == false && ChestArmour == false && LegArmour == true))
                {
                    ArmourDefense += (100 / 25);
                    break;

                }

                else if ((HeadArmour == true && ChestArmour == true && LegArmour == false)
                        || (HeadArmour == true && ChestArmour == false && LegArmour == true)
                        || (HeadArmour == false && ChestArmour == true && LegArmour == true))
                {
                    ArmourDefense = (100 / 25) * 2;
                    break;
                }

                else if (HeadArmour == true && ChestArmour == true && LegArmour == true)
                {
                    ArmourDefense = ((100 / 25) * 3) + (1/2);
                    break;
                }

                else if (HeadArmour == false && ChestArmour == false && LegArmour == false)
                {
                    ArmourDefense = 0;
                    break;
                }           
                        
                    
                
            }
        }

        static public void Mail(bool HeadMail, bool ChestMail, bool LegMail)
        {
            while (true)
            {
                if ((HeadMail == true && ChestMail == false && LegMail == false)
                    || (HeadMail == false && ChestMail == true && LegMail == false)
                    || (HeadMail == false && ChestMail == false && LegMail == true))
                {
                    MailDefense = (100 / 25);
                    break;

                }

                else if ((HeadMail == true && ChestMail == true && LegMail == false)
                        || (HeadMail == true && ChestMail == false && LegMail == true)
                        || (HeadMail == false && ChestMail == true && LegMail == true))
                {
                    MailDefense = (100 / 25) * 2;
                    break;
                }

                else if (HeadMail == true && ChestMail == true && LegMail == true)
                {
                    MailDefense = ((100 / 25) * 3) + (1/2);
                    break;
                }

                else if (HeadMail == false && ChestMail == false && LegMail == false)
                {
                    MailDefense = 0;
                    break;
                }



            }
        }

        //Not used
        static public void Defence()
        {

        }

    }
}
