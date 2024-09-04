using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Лабораторная_работа_4._2
{
    internal class Program
    {
        public static Random random = new Random();
        public static List<Weather> snow = new List<Weather>();
        public static List<Weather> rain = new List<Weather>();

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            for (int i = 0; i < 20; i++)
            {
                Weather snow1 = new Snow();
                int X = random.Next(75);
                snow1.Position(X, 1);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(snow1.X, snow1.Y);
                snow1.Move();
                Console.ForegroundColor = ConsoleColor.Black;
                snow.Add(snow1);
                Thread.Sleep(0);
            }

            for (int i = 0; i < 20; i++)
            {
                Weather rain1 = new Rain();
                int X = random.Next(75);
                rain1.Position(X, 1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(rain1.X, rain1.Y);
                rain1.Move();
                Console.ForegroundColor = ConsoleColor.Black;
                rain.Add(rain1);
                Thread.Sleep(0);
            }

            while (true)
            {
                foreach(var r in rain)
                {
                    Console.SetCursorPosition(r.X, r.Y);
                    if (random.Next(2) == 0)
                    {
                        r.Y += 1;
                        Console.SetCursorPosition(r.X, r.Y + 10);
                        Console.Write(" ");

                        if (r.Y > 20)
                        {
                            r.Y = 1;
                        }

                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(r.X, r.Y);
                    r.Move();
                    Console.ForegroundColor = ConsoleColor.Black;
                    if (r.Y > 10)
                    {
                        Console.SetCursorPosition(r.X, r.Y - 10);
                        Console.Write(" ");
                    }

                    Thread.Sleep(2);
                }
                foreach(var s in snow)
                {
                    Console.SetCursorPosition(s.X, s.Y);
                    if (random.Next(2) == 0)
                    {
                        s.Y += 1;
                        Console.SetCursorPosition(s.X, s.Y + 10);
                        Console.Write(" ");

                        if (s.Y > 20)
                        {
                            s.Y = 1;
                        }

                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(s.X, s.Y);
                    s.Move();
                    Console.ForegroundColor = ConsoleColor.Black;
                    if (s.Y > 10)
                    {
                        Console.SetCursorPosition(s.X, s.Y - 10);
                        Console.Write(" ");
                    }

                    Thread.Sleep(0);
                }
            }
        }
    }
}
