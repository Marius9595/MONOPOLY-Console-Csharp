using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class BuyProperty_Strategy : Player_AbstractStrategy
    {
        //TODO: Ajustar y darle más sentido a temas como la presentación de la información etc etc
        public override void Action(Player player ,AbstractSquare[] board)
        {
            

            if ((board[player.ACTUALPOSITION] is IAbstractTitleDeed))
            {
                IAbstractTitleDeed TitleDeed = ((IAbstractTitleDeed)board[player.ACTUALPOSITION]);


                ProcessToBuyTitleDeed(TitleDeed, board, player);

            }
            else
            {
                Console.Clear();
                Console.WriteLine("This square is not a property, you cannot purchase it.");
                Console.WriteLine("\nPress any key to choose another action.\n");
                Console.ReadKey(true);
                player.SetScene(new MenuPlayerScene_State());
                player.Display(board);
            }
            
        }

        private void ProcessToBuyTitleDeed(IAbstractTitleDeed TitleDeed, AbstractSquare[] board ,Player player)
        {
            if (TitleDeed.SITUATION == TitleDeedSituation.Bought)
            {
                Console.Clear();
                Console.WriteLine($"This property is not available, his owner is {TitleDeed.OWNER}");
                Console.WriteLine("Press any key to go back to the menu.");
                Console.ReadKey(true);

                player.SetScene(new MenuPlayerScene_State());
                player.Display(board);
            }
            else if (TitleDeed.SITUATION == TitleDeedSituation.Free)
            {
                Console.Clear();
                Console.WriteLine("The property you want to buy is the following:\n");

                if (TitleDeed is PropertySquare)
                {
                    Console.BackgroundColor = ((PropertySquare)TitleDeed).COLOR_PROPERTY;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                
                Console.WriteLine(TitleDeed.NAME);

                config.init();

                Console.WriteLine();

                Evaluating_BuyingCapabilityofPlayer(TitleDeed, board, player);

            }
        }

        private void Evaluating_BuyingCapabilityofPlayer(IAbstractTitleDeed TitleDeed, AbstractSquare[] board, Player player)
        {
            if (TitleDeed.BUYING_COST > player.CURRENTMONEY)
            {
                Console.WriteLine("\nYou do not have enough money to go through with this purchase.");
                Console.WriteLine("Press any key to go back to the menu.");
                Console.ReadKey(true);
                player.SetScene(new MenuPlayerScene_State());
                player.Display(board);
            }
            else
            {
                BuyingProcess_Player(TitleDeed, board, player);
            }


        }


        void BuyingProcess_Player(IAbstractTitleDeed TitleDeed, AbstractSquare[] board, Player player)
        {
            Console.WriteLine("\nYou currently have: $" + player.CURRENTMONEY);
            int res = 0;
            while (res != 1 && res != 2)
            {
                Console.WriteLine("Are you sure you want to go throught with this purchase?\n1 : YES\n2 : NO");
                res = int.Parse(Console.ReadLine());
            }
            if (res == 1)
            {
                Console.Clear();

                player.properties.Add(TitleDeed);

                player.CURRENTMONEY -= TitleDeed.BUYING_COST;

                TitleDeed.AssignOwner(player);

                TitleDeed.SITUATION = TitleDeedSituation.Bought;

                Console.WriteLine("Congratulations on your new property!\n");
                Console.WriteLine();
                Console.WriteLine("\nPress any key to go back to the menu.");
                Console.ReadKey(true);
                player.SetScene(new MenuPlayerScene_State());
                player.Display(board);
            }
            else if (res == 2)
            {
                Console.WriteLine("\nPress any key to go back to the menu.");
                Console.ReadKey(true);
                player.SetScene(new MenuPlayerScene_State());
                player.Display(board);
            }
        }



    }
}
