using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class MenuPlayerScene_State : PlayerScenes_States
    {
        Scenes scenes = new Scenes(new BoardSituationScene_State());
        List<Player> Players = new List<Player>();

        public override void Draw(Player player , AbstractSquare[] board)
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

            int answer = 0;
            Console.WriteLine("\nPlease Make a Selection :\n");
            Console.WriteLine("0 : Game Status");
            Console.WriteLine("1 : Finish Turn");
            Console.WriteLine("2 : Your DashBoard");
            Console.WriteLine("3 : Purchase the property");
            Console.WriteLine("4 : Buy House for property (developing...)");
            Console.WriteLine("5 : Buy Hotel for property(developing...)");
            Console.WriteLine("6 : Declare Bankrupt");
            Console.WriteLine("7 : Quit Game");
            Console.Write("(1-7)>");

            Console.WriteLine("Please Introduce your Selection: ");
            answer = int.Parse(Console.ReadLine());
            

            switch (answer)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Game Status :");

                        Console.WriteLine("\n" + player.toString());
  
                    Console.ReadKey();
                    Console.Clear();
                    Draw(player, board);
                    break;
                case 1:
                    break;
                case 2:
                    Players.Add(player);
                    Dashboard(player, board);
                    Players.Remove(player);
                    break;
                case 3:
                    player.SetStrategy(new BuyProperty_Strategy());
                    player.Action(player, board);
                    break;
                case 4:
                    //BuyHouseProperty(player, compt);
                    break;
                case 5:
                    //BuyHotelProperty(player, compt);
                    break;
                case 6:
                    player.Loser = true;
                    break;
                case 7:
                    player.CURRENTMONEY = 0;
                    player.Loser = true;
                    break;
            }
        }


        private void Dashboard(Player player , AbstractSquare[] board)
        {
            Console.Clear();

            scenes.Display(Players, board);

            Console.WriteLine();

            Console.WriteLine("Your position is: " + player.ACTUALPOSITION);
            Console.WriteLine("You have: $" + player.CURRENTMONEY);
            Console.WriteLine("You own " + player.properties.Count + " properties:\n");
            if (player.properties.Count != 0)
            {
                foreach (IAbstractTitleDeed TitleDeed in player.properties)
                {
                    Console.WriteLine(TitleDeed.NAME);
                }
            }

            

            Console.WriteLine();
            Console.WriteLine("\nPress any key to go back to the menu.");
            Console.ReadKey(true);
            Draw(player,board);
        }
    }
}
