using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class BuyProperty_Strategy : Player_AbstractStrategy
    {
        public override void Action(Player player ,Board board)
        {
            IAbstractTitleDeed TitleDeed = ((IAbstractTitleDeed)board.board[player.ACTUALPOSITION]);

            if (!(board.board[player.ACTUALPOSITION] is IAbstractTitleDeed))
            {



                if (TitleDeed.SITUATION == TitleDeedSituation.Bought)
                {
                    Console.Clear();
                    Console.WriteLine("This property is not available.");
                    Console.WriteLine("Press any key to go back to the menu.");
                    Console.ReadKey(true);

                    player.SetScene(new MenuPlayerScene_State());
                    player.Display();
                }
                else if (TitleDeed.SITUATION == TitleDeedSituation.Free)
                {
                    Console.Clear();
                    Console.WriteLine("The property you want to buy is the following:\n");
                    Console.WriteLine(TitleDeed.NAME);

                    Console.WriteLine();

                    if (TitleDeed.BUYING_COST > player.CURRENTMONEY)
                    {
                        Console.WriteLine("\nYou do not have enough money to go through with this purchase.");
                        Console.WriteLine("Press any key to go back to the menu.");
                        Console.ReadKey(true);
                        player.SetScene(new MenuPlayerScene_State());
                        player.Display();
                    }
                    else
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

                            Console.WriteLine("Congratulations on your new property!\n");
                            Console.WriteLine();
                            Console.WriteLine("\nPress any key to go back to the menu.");
                            Console.ReadKey(true);
                            player.SetScene(new MenuPlayerScene_State());
                            player.Display();
                        }
                        else if (res == 2)
                        {
                            Console.WriteLine("\nPress any key to go back to the menu.");
                            Console.ReadKey(true);
                            player.SetScene(new MenuPlayerScene_State());
                            player.Display();
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("This square is not a property, you cannot purchase it.");
                Console.WriteLine("\nPress any key to choose another action.\n");
                Console.ReadKey(true);
                player.SetScene(new MenuPlayerScene_State());
                player.Display();
            }
            
        }
    }
}
