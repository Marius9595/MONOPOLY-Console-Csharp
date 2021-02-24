using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class GotoJailScene_State : PlayerScenes_States
    {
        public override void Draw(Player player, AbstractSquare[] board, Board Theboard)
        {
            message();

            System.Threading.Thread.Sleep(2500);
            Console.Clear();

            image();

            System.Threading.Thread.Sleep(2500);
            Console.Clear();
            config.init();

        }

        void message()
        {
            Console.Clear();

            Console.WindowHeight = 25;
            Console.WindowWidth = 70;
            String File = @"C:\Users\Mario\Desktop\PROYECTO C#\MONOPOLY\messagegotojail.txt";

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

        void image()
        {
            Console.WindowHeight = 60;
            Console.WindowWidth = 70;
            String File = @"C:\Users\Mario\Desktop\PROYECTO C#\MONOPOLY\gotojail.txt";

            String line;
            int counter = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            System.IO.StreamReader file = new System.IO.StreamReader(File);
            while ((line = file.ReadLine()) != null)
            {
                System.Threading.Thread.Sleep(50);
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();

            System.Threading.Thread.Sleep(2500);
            Console.Clear();
            config.init();
        }
    }
}
