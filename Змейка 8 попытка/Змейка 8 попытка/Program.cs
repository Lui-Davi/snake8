﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка_8_попытка
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';

            /*int x1 = 1;
            int y1 = 3;
            char sym1 = '*';*/
            Draw(p1.x, p1.y, p1.sym);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '$';
            Draw(x2, y2, sym2);

            Console.ReadLine();

        }
        static void Draw(int x, int y, char sym )
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
