using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class RollingDicesScene_State : PlayerScenes_States
    {


        public override void Draw(Player player)
        {
            Console.Clear();

            Console.BackgroundColor = player.COLOR;
            Console.ForegroundColor = player.COLOR;
            Console.WriteLine($" {player.NAME.ToUpper()}               ");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($" {player.NAME.ToUpper()} is your turn  ");

            Console.BackgroundColor = player.COLOR;
            Console.ForegroundColor = player.COLOR;
            Console.WriteLine($" {player.NAME.ToUpper()}               ");
            config.init();
            Console.WriteLine();

            config.init();
            Console.WriteLine("\nPress any key to roll the dices!\n");
            Console.ReadKey(true);


            int[] Dados = Dices.RollDices();

            player.DisplayDices(Dados);
        }


    }
}
