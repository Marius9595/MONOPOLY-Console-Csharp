using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
   class StartScene_State : Scenes_States
    {
        public override void Draw(Player[] players, Board board)
        {

            config.init();

            String Welcome = "WELCOME TO MONOPOLY";

            String start = "Press Any Button to start!";

            void writeEspecialLine()
            {
                int left = config.WIDTH / 3;
                int right = config.WIDTH - config.WIDTH / 3;

                for (int i = 0; i < config.WIDTH; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    if (i == left)
                    {
                        Console.Write("#");
                    }
                    else if (i == right)
                    {
                        Console.Write("#");
                    }
                    else if (i == right + 1)
                    {
                        Console.Write("#");
                    }
                    else if (i == left + 1)
                    {
                        Console.Write("#");
                    }
                    else if (i == right - 1)
                    {
                        Console.Write("#");
                    }
                    else if (i == left - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("*");
                    }


                }
                Console.Write("\n");
            }

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            for (int i = 0; i < config.HEIGHT / 5; i++) writeEspecialLine();

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.SetCursorPosition(Console.CursorLeft + config.WIDTH / 2 - Welcome.Length / 2, Console.CursorTop);
            Console.Write(" " + Welcome + " \n");

            Console.WriteLine();

            Console.SetCursorPosition(Console.CursorLeft + config.WIDTH / 2 - start.Length / 2, Console.CursorTop);
            Console.Write(" " + start + " \n");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.BackgroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < config.HEIGHT / 4; i++) writeEspecialLine();


            Console.BackgroundColor = ConsoleColor.Black;

            Console.CursorVisible = false;


            var answer = Console.ReadKey();

            if (answer != null) Console.Clear();

        }
    }



}
