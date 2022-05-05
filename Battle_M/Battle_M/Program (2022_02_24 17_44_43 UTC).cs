using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Battle_M
{
    class Program 
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            Player.Draw();
            Player.DrawBattle();

            ScreenDraw sd = new ScreenDraw();
            ScreenDraw.Draw();

            Battle_Interface bi = new Battle_Interface();
            Battle_Interface.Draw();


            Console.Read();
        }

    }
}
