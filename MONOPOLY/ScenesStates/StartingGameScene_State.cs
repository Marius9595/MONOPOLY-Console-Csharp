using System;
using System.Collections.Generic;
using System.Text;


namespace MONOPOLY
{
    class StartingGameScene_State : Scenes_States
    {
        public override void Draw(List<Player> players, Board board)
        {
            Console.WindowHeight = 40;
            Console.WindowWidth = 160;

            int motion = 10;

            Console.WriteLine();

            for (int i = 0; i < motion; i++)
            {
               
                Message();
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                for (int j = 0; j < i+1; j++)
                {
                    Console.WriteLine("\n");
                } 

            }

            config.init();
            


            void Message()
            {
                String File = @"C:\Users\Mario\Desktop\PROYECTO C#\MONOPOLY\starting_soon.txt";

                String line;
                int counter = 0;

                System.IO.StreamReader file = new System.IO.StreamReader(File);
                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    counter++;
                }

                file.Close();
            }
        }
    }
}
