using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Лабораторная_работа_4._2
{
    public abstract class Weather
    {
        public int X, Y;
        public ConsoleColor Color;

        public abstract void Position(int x, int y);//задаем позицию
        public abstract void Move();//выводим

    }
}
