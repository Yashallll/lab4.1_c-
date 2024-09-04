using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4._2
{
    public class Rain : Weather
    {
        public static Random random4 = new Random();
        public char Mface = '|';

        public override void Position(int x, int y)
        {
            (X, Y) = (x, y);
        }

        public override void Move()
        {
            Console.Write(Mface);
        }
    }
}
