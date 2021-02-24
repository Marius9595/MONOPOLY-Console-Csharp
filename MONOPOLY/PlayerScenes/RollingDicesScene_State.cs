using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class RollingDicesScene_State : PlayerScenes_States
    {


        public override void Draw(Player player, AbstractSquare[] board, Board Theboard)
        {
            Console.Clear();
            Transition();
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

            int[] dices = Dices.RollDices();

            DisplayDices(dices);

            player.DICES = DicesValue(dices);

            player.DoubleBool(dices);

        }

        

        int DicesValue(int[] dices)
        {
            int SumDices = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                SumDices +=dices[i];
            }

            return SumDices;
        }





        private void DisplayDices(int[] dices)
        {
            for (int i = 0; i < dices.Length; i++)
            {
                switch (dices[i])
                {
                    case 1:
                        Console.WriteLine(Dices.One);
                        break;
                    case 2:
                        Console.WriteLine(Dices.Two);
                        break;
                    case 3:
                        Console.WriteLine(Dices.Three);
                        break;
                    case 4:
                        Console.WriteLine(Dices.Four);
                        break;
                    case 5:
                        Console.WriteLine(Dices.Five);
                        break;
                    case 6:
                        Console.WriteLine(Dices.Six);
                        break;

                    default:
                        Console.WriteLine("FATAL ERROR");
                        break;
                }

              

            }


        }

        //TODO: REFACTORIZAR JUNTO A OTRA ESCENA QUE NO DEPENDE DE JUGADORES O TABLERO
        void Transition()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(".");
                    System.Threading.Thread.Sleep(400);
                }
                Console.Clear();
            }

        }
    }
}
