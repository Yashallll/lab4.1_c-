using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4._2
{
    internal class Position
    {
        public static Random random1 = new Random();
        public static void Pos(char sym, int x, int y, ConsoleColor color)//работа с объектами
        {
            if (x <= 75 && y <= 25)
            {
                try
                {
                    Console.SetCursorPosition(x, y);
                    var defaultColor = Console.BackgroundColor;
                    Console.ForegroundColor = color;
                    Console.Write(sym);
                    Console.ForegroundColor = defaultColor;
                    Console.SetCursorPosition(0, 0);
                }
                catch (Exception e)
                {
                }
            }
            else if (x >= 75 || y >= 25)
            {
                Pos(sym, random1.Next(1, 75), 1, color);
            }
            else if (x <= 0 || y <= 0)
            {
                Pos(sym, x + random1.Next(1, 75), 1, color);
            }
        }
    }
}
