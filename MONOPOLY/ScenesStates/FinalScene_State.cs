using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class FinalScene_State : Scenes_States
    {
        public override void Draw(Player[] players, Board board)
        {
            config.init();

            String finish = "Press Any Button to FINISH";
            String Welcome = "";

            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].Loser == false)
                {
                    Welcome = $"THE WINNER IS {players[0].NAME.ToUpper()}";
                }

            }


            for (int i = 0; i < config.HEIGHT / 6; i++) Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Magenta;

            for (int i = 0; i < config.HEIGHT / 5; i++) writeEspecialLine();

            Console.BackgroundColor = ConsoleColor.Black;

            for (int i = 0; i < 3; i++) Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.SetCursorPosition(Console.CursorLeft + config.WIDTH / 2 - Welcome.Length / 2, Console.CursorTop);
            Console.Write(" " + Welcome + " \n");

            Console.WriteLine();

            Console.SetCursorPosition(Console.CursorLeft + config.WIDTH / 2 - finish.Length / 2, Console.CursorTop);
            Console.Write(" " + finish + " \n");

            for (int i = 0; i < 3; i++) Console.WriteLine();





            Console.BackgroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < config.HEIGHT / 4; i++) writeEspecialLine();


            Console.BackgroundColor = ConsoleColor.Black;

            Console.CursorVisible = false;


            var answer = Console.ReadKey();

            if (answer != null) Console.Clear();





            void writeEspecialLine()
            {
                int left = config.WIDTH / 3;
                int right = config.WIDTH - config.WIDTH / 3;

                for (int i = 0; i < config.WIDTH; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (i == left)
                    {
                        Console.Write("+");
                    }
                    else if (i == right)
                    {
                        Console.Write("+");
                    }
                    else if (i == right + 1)
                    {
                        Console.Write("$");
                    }
                    else if (i == left + 1)
                    {
                        Console.Write("$");
                    }
                    else if (i == right - 1)
                    {
                        Console.Write("$");
                    }
                    else if (i == left - 1)
                    {
                        Console.Write("$");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("'");
                    }


                }
                Console.Write("\n");
            }
        }
    }
}
