using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Battle_M
{
    class Battle_Interface
    {
        public static void Draw()
        {

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(62, 1);
            Console.WriteLine("Weapon");
            Console.SetCursorPosition(62, 2);
            Console.WriteLine("Map");
            Console.SetCursorPosition(62, 3);
            Console.WriteLine("Equip");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 18);
            Console.WriteLine("-");
            Console.SetCursorPosition(23, 18);
            Console.WriteLine("+");
            Console.SetCursorPosition(23, 19);
            Console.WriteLine("|");
            Console.SetCursorPosition(23, 20);
            Console.WriteLine("|");
            Console.SetCursorPosition(23, 21);
            Console.WriteLine("|");
            Console.SetCursorPosition(23, 22);
            Console.WriteLine("|");
            Console.SetCursorPosition(23, 23);
            Console.WriteLine("|");

            Enemy.Draw();
            TextScrolling(25, 19, "^[A scaley, orange dragon appears]", ConsoleColor.DarkYellow, false);
            TextScrolling(25, 20, "^[Rolling flames pour from its mouth.]", ConsoleColor.DarkYellow, false);

            Console.SetCursorPosition(58, 1);
            MenuBattle(58, 1, ConsoleColor.Red, "->", 1, 3, ConsoleColor.Gray, "Sword", 1, "Items", 2, " ", 3, 60, 5);

            Battle.RandomBattle(1, 17, ConsoleColor.Gray, 57, 12, 57, 14);

        }

        static void TextScrolling(int XCoord, int line, string text, ConsoleColor Color, bool Pause)
        {
            int SpeechX = XCoord; int SpeechY = line;
            Console.ForegroundColor = Color;

            string[] message = text.Select(x => x.ToString()).ToArray();
            foreach (string letter in message)
            {
                Console.SetCursorPosition(SpeechX, SpeechY);
                Thread.Sleep(35);
                Console.Write(letter);
                SpeechX++;
            }

            Console.ForegroundColor = ConsoleColor.Black;
            if (Pause)
            {
                while (true)
                {
                    ConsoleKeyInfo input = Console.ReadKey();
                    if (input.Key == ConsoleKey.Spacebar || input.Key == ConsoleKey.Enter)
                    {
                        break;
                    }

                }
            }
        }



        static void MenuBattle(int x, int y, ConsoleColor Color, string Pointer, int top, int bottom, ConsoleColor Color2, string a1, int y1, string a2, int y2, string a3, int y3, int X, int Y)
        {
            int NewY = y;
            Console.CursorVisible = false;
            ConsoleKeyInfo input;
            Console.ForegroundColor = Color;
            Console.Write(Pointer);

            while (true)
            {
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(x, NewY);
                    Console.Write("  ");
                    NewY--;

                    if (NewY < top)
                    {
                        Console.SetCursorPosition(x, bottom);
                        Console.Write("  ");
                        NewY = bottom;
                    }
                    Console.SetCursorPosition(x, NewY);
                    Console.Write(Pointer);
                }

                if (input.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(x, NewY);
                    Console.Write("  ");
                    NewY++;

                    if (NewY > bottom)
                    {
                        Console.SetCursorPosition(x, bottom);
                        Console.Write("  ");
                        NewY = top;
                    }
                    Console.SetCursorPosition(x, NewY);
                    Console.Write(Pointer);
                }

                if (input.Key == ConsoleKey.Enter)
                {
                    if (NewY == y1)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.ForegroundColor = Color2;
                        Console.Write(a1);
                        TextScrolling(57, 7, "Where will you", ConsoleColor.White, false);
                        TextScrolling(57, 8, "attack?", ConsoleColor.White, false);

                        ScreenDraw.MenuBoxSides(1, 11, 5, ConsoleColor.White, 5, 4, 15);
                        ScreenDraw.MenuBoxTop(4, 16, ConsoleColor.White, 1, 1, 11);

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(5, 5);
                        Console.WriteLine("Head");
                        Console.SetCursorPosition(5, 10);
                        Console.WriteLine("Chest");
                        Console.SetCursorPosition(5, 15);
                        Console.WriteLine("Legs");

                        Console.SetCursorPosition(2, 5);
                        InternalMenu(2, 5, ConsoleColor.Red, "->", 5, 5, 15, ConsoleColor.White, "Head", 5, "Chest", 10, "Legs", 15, 57, 10);

                        break;
                    }
                    else
                    if (NewY == y2)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.ForegroundColor = Color2;
                        Console.Write(a2);
                        TextScrolling(57, 7, "What item will", ConsoleColor.White, false);
                        TextScrolling(57, 8, "you use?", ConsoleColor.White, false);
                        break;
                    }
                    else
                    if (NewY == y3)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.ForegroundColor = Color2;
                        Console.Write(a3);
                        TextScrolling(57, 7, "What'll you", ConsoleColor.White, false);
                        TextScrolling(57, 8, "change out?", ConsoleColor.White, false);

                        ScreenDraw.MenuBoxSides(1, 11, 5, ConsoleColor.White, 5, 4, 15);
                        ScreenDraw.MenuBoxTop(4, 16, ConsoleColor.White, 1, 1, 11);

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(5, 5);
                        Console.WriteLine("Weapon");
                        Console.SetCursorPosition(5, 10);
                        Console.WriteLine("Armour");
                        Console.SetCursorPosition(5, 15);
                        Console.WriteLine("Extra");

                        Console.SetCursorPosition(2, 5);
                        InternalMenu(2, 5, ConsoleColor.Red, "->", 5, 5, 15, ConsoleColor.White, "Weapon", 5, "Armour", 10, "Extra", 15, 57, 10);



                        break;
                    }

                }
            }
        }

        static void InternalMenu(int x, int y, ConsoleColor Color, string Pointer,int value, int top, int bottom, ConsoleColor Color2, string a1, int y1, string a2, int y2, string a3, int y3, int X, int Y)
        {
            int NewY = y;
            Console.CursorVisible = false;
            ConsoleKeyInfo input;
            Console.ForegroundColor = Color;
            Console.Write(Pointer);

            while (true)
            {
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(x, NewY);
                    Console.Write("  ");
                    NewY = NewY - value;

                    if (NewY < top)
                    {
                        Console.SetCursorPosition(x, bottom);
                        Console.Write("  ");
                        NewY = bottom;
                    }
                    Console.SetCursorPosition(x, NewY);
                    Console.Write(Pointer);
                }

                if (input.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(x, NewY);
                    Console.Write("  ");
                    NewY = NewY + value;

                    if (NewY > bottom)
                    {
                        Console.SetCursorPosition(x, bottom);
                        Console.Write("  ");
                        NewY = top;
                    }
                    Console.SetCursorPosition(x, NewY);
                    Console.Write(Pointer);
                }

                if (input.Key == ConsoleKey.Enter)
                {
                    if (NewY == y1)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.ForegroundColor = Color2;
                        Console.Write(a1);
                        break;
                    }
                    else
                    if (NewY == y2)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.ForegroundColor = Color2;
                        Console.Write(a2);
                        break;
                    }
                    else
                    if (NewY == y3)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.ForegroundColor = Color2;
                        Console.Write(a3);
                        break;
                    }
                }
            }
        }




    }
}
