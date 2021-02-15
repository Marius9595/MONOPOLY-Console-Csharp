using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
   class StartScene_State : Scenes_States
    {
        public override void Draw(List<Player> players, Board board)
        {

            config.init();


            String start = "Press Any Button to start!";



            header();

            

            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;


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


        void header()
        {

            String File = @"C:\Users\Mario\Desktop\PROYECTO C#\MONOPOLY\monopoly.txt";

            String line;
            int counter = 0;

            System.IO.StreamReader file = new System.IO.StreamReader(File);

            int top = 2;
            while ((line = file.ReadLine()) != null)
            {
                Console.SetCursorPosition(Console.WindowWidth / 10, top);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                System.Console.WriteLine(line);
                counter++;
                top++;
            }
            config.init();
            file.Close();

        }
    }



}
