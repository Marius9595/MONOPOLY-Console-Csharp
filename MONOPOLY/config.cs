using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    static class config
    {
        static int height = 30;
        static int width = 100;
        static ConsoleColor BackgroundColor = ConsoleColor.Black;
        static ConsoleColor ForeGroundColor = ConsoleColor.White;

        static public int HEIGHT { get => height; }
        static public int WIDTH { get => width; }

        static public ConsoleColor BACK_GROUND_COLOR { get => BackgroundColor;}
        static public ConsoleColor FORE_GROUND_COLOR { get => ForeGroundColor; }



        static public void init()
        {
            Console.WindowHeight = height;
            Console.WindowWidth = width;
            Console.BackgroundColor = BackgroundColor;
            Console.ForegroundColor = ForeGroundColor;
        }
    }
}
