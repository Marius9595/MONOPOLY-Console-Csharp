using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace MONOPOLY
{
    class createGameScene_State : Scenes_States
    {
        public override void Draw(List<Player> players, Board board)
        {

            

            int numberofPlayers = 0;
            int attempts = 0;
            ConsoleColor color=ConsoleColor.White;

            while (numberofPlayers < 2 || numberofPlayers > 4)
            {

                if (attempts > 0)
                {

                    Console.WriteLine("Please introduce a number between 2-4");
                    numberofPlayers = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else if (attempts == 0)
                {
                    Console.WriteLine("How many players (2-4)?");
                    numberofPlayers = int.Parse(Console.ReadLine());
                    Console.Clear();
                }

                attempts += 1;
            }



            Console.WriteLine("Okey, we are going to fill information of the player");
            Console.WriteLine();

            for (int i = 0; i < numberofPlayers; i++)
            {
                Console.WriteLine("Player " + (i + 1) + ":");
                Console.Write("Username: ");
                string name = Console.ReadLine();

                switch (i)
                {
                    case 0:
                        color = ConsoleColor.Red;
                            break;
                    case 1:
                        color = ConsoleColor.Cyan;
                        break;
                    case 2:
                        color = ConsoleColor.Magenta;
                        break;
                    case 3:
                        color = ConsoleColor.Yellow;
                        break;
                    default:
                        break;
                }
                Player player = new Player(name, color);
                Console.WriteLine();
                Console.WriteLine($"{player.NAME}, your color will be {color}");
                players.Add(player);
                Console.WriteLine($"\n{player.NAME}, you were successfully added!\n");

                
            }



            System.Threading.Thread.Sleep(2000);

            

            Console.Clear();


            Console.WriteLine("\nPlayers:");
            for (int i = 0; i < numberofPlayers; i++)
            {
                Console.ForegroundColor = players[i].COLOR;
                Console.WriteLine("\n" + players[i].NAME);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress any key to start the game !\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(true);

            config.init();
        }
    }
}


//TODO: afinar paso de numero de jugadores para que no falle al introducir un no número