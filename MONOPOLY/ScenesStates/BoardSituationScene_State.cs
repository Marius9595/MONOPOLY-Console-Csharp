using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class BoardSituationScene_State : Scenes_States
    {
        public override void Draw(List<Player> players, AbstractSquare[] board)
        {
            
            Console.Clear();

            header(players[0]);

            Console.WriteLine();

            config.init();
            Console.WriteLine($"{players[0].NAME},Information of the Square where you are:");

            Console.WriteLine();

            FormatSquareInfo(board[players[0].ACTUALPOSITION]);
            Console.WriteLine(board[players[0].ACTUALPOSITION].InfoSquare());

            config.init();
        }


        void header(Player player)
        {
            Console.BackgroundColor = player.COLOR;
            Console.ForegroundColor = player.COLOR;
            Console.WriteLine($"           {player.NAME} STATUS         ");
            Console.BackgroundColor = player.COLOR;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"           {player.NAME} STATUS         ");
            Console.BackgroundColor = player.COLOR;
            Console.ForegroundColor = player.COLOR;
            Console.WriteLine($"           {player.NAME} STATUS         ");
            

        }


        void FormatSquareInfo(AbstractSquare Square)
        {
            if (Square is PropertySquare)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ((PropertySquare)Square).COLOR_PROPERTY;

            }
            else if (Square is ServicesSquare)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }



    }
}
