using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_M
{
    class ScreenDraw
    {
        public static void Draw()
        {
            InterfaceSide1(56, 0, ConsoleColor.White, 4, 71, 18);
            InterfaceSide2(71, 0, 0, ConsoleColor.White, 18, 71, 23);
        }


        public static void InterfaceSide1(int x, int y, ConsoleColor Color, int LateralY, int RightX, int bottom)
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(x, y);
            int newy = RightX;
            int NewX = x;
            int NewY = 0;

            Console.WriteLine("|");
            while (true)
            {
                if (NewY < bottom)
                {
                    NewY++;
                    Console.SetCursorPosition(x, NewY);
                    Console.WriteLine("|");

                    while (true)
                    {
                        if (NewX < RightX)
                        {
                            NewX++;
                            Console.SetCursorPosition(NewX, LateralY);
                            Console.Write("-");
                        }
                        else if (NewX == RightX)
                        {
                            break;
                        }
                    }
                }
                else if (NewY == bottom)
                {
                    break;
                }
            }
        }

        public static void InterfaceSide2(int x, int y, int X, ConsoleColor Color, int LateralY, int RightX, int bottom)
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(x, y);
            int newy = RightX;
            int NewX = x;
            int NewY = 0;

            Console.WriteLine("|");
            while (true)
            {
                if (NewY < bottom)
                {
                    NewY++;
                    Console.SetCursorPosition(x, NewY);
                    Console.WriteLine("|");

                    while (true)
                    {
                        if (X < RightX)
                        {
                            X++;
                            Console.SetCursorPosition(X, LateralY);
                            Console.Write("-");
                        }
                        else if (NewX == RightX)
                        {
                            break;
                        }
                    }
                }
                else if (NewY == bottom)
                {
                    break;
                }
            }
        }

        public static void MenuBoxSides(int x1, int x2, int y2, ConsoleColor Color, int top, int top2, int bottom)
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(x1, top);
            int NewY = top;
            int NewY2 = top2;

            Console.WriteLine("|");
            while (true)
            {
                if (NewY < bottom)
                {
                    NewY++;
                    Console.SetCursorPosition(x1, NewY);
                    Console.WriteLine("|");

                    while(true)
                    {
                        if(NewY2 < bottom)
                        {
                            NewY2++;
                            Console.SetCursorPosition(x2, NewY2);
                            Console.WriteLine("|");
                        }
                        else if (NewY2 == bottom)
                        {
                            break;
                        }
                    }
                }
                else if (NewY == bottom)
                {
                    break;
                }
            }
        }

        public static void MenuBoxTop(int y1, int y2, ConsoleColor Color, int LeftX, int LeftX2, int RightX)
        {
            Console.ForegroundColor = Color;
            int NewX = LeftX;
            int NewX2 = LeftX2;

            Console.SetCursorPosition(LeftX2, y2);
            Console.WriteLine("+");
            Console.SetCursorPosition(LeftX, y1);
            Console.WriteLine("+");
            while (true)
            {
                if (NewX < RightX)
                {
                    NewX++;
                    Console.SetCursorPosition(NewX, y1);
                    Console.WriteLine("-");

                    while (true)
                    {
                        if (NewX2 < RightX)
                        {
                            NewX2++;
                            Console.SetCursorPosition(NewX2, y2);
                            Console.WriteLine("-");
                        }
                        else if (NewX2 == RightX)
                        {
                            Console.SetCursorPosition(NewX2, y2);
                            Console.WriteLine("+");
                            break;
                        }
                    }
                }
                else if (NewX == RightX)
                {
                    Console.SetCursorPosition(NewX, y1);
                    Console.WriteLine("+");
                    break;
                }
            }
        }
    }
}
