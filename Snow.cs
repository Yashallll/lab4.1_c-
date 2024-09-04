using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4._2
{
    
    public class Snow : Weather
    {
        public static Random random3 = new Random();
        public char face = '*';

        public override void Position(int x, int y)
        {
            (X, Y) = (x, y);
        }

        public override void Move()
        {
            Console.Write(face);
        }
    }
}
