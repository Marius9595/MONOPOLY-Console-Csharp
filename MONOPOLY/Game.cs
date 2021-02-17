using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class Game
    {
        //TODO: desgranar el codigo copiado

        private List<Player> players = new List<Player>(); 
        private Board board_game = new Board();

        private AbstractSquare[] TheBoard;
        private int rounds=0; // number of rounds played
        private Player winner;
        private Scenes Scenes = new Scenes(new StartScene_State());

        public void Create()
        {
            this.board_game.CreateBoard();

            this.TheBoard = board_game.board;

            Scenes.Display(players, TheBoard);

            Scenes.TransitionTo(new createGameScene_State());

            Scenes.Display(players, TheBoard);

            Scenes.TransitionTo(new StartingGameScene_State());

            Scenes.Display(players, TheBoard);


        }
        
        private bool IsWinner()
        {
            int LosersCount = 0;
 
            foreach (Player player in players)
            {
                if (player.Loser == true) { LosersCount++; }
            }

            if (LosersCount == players.Count-1) { return true; }
            else {
                LosersCount = 0;
                return false; 
            
            }
        }

        
        public void Start()
        {
            int Player_Index = 0;

            while (!IsWinner())
            {
                Console.Clear();

                rounds++;
                while (!players[Player_Index].Loser)
                {
                    //TODO: aqui abra que poner un if para  que jueguen los que estan en la carcel

                    players[Player_Index].SetScene(new RollingDicesScene_State());
                    players[Player_Index].Display(this.TheBoard);
                    players[Player_Index].MovePlayer();
                    

                    //TODO: CONSECUENCIAS DE ESTAR EN ESA CASILLA ACCIONES

                    PlayerActions(players[Player_Index], TheBoard);


                    if (players[Player_Index].DOUBLEBOOL == true && players[Player_Index].INJAIL == false)
                    {
                        players[Player_Index].SetScene(new RollingDicesScene_State());
                        players[Player_Index].Display(this.TheBoard);

                        if (players[Player_Index].INJAIL == true)
                        {
                            Console.Clear();

                            players[Player_Index].SetScene(new GotoJailScene_State());
                            players[Player_Index].Display(TheBoard);
                            players[Player_Index].INJAIL = true;
                        }
                        else
                        {
                            players[Player_Index].MovePlayer();
                            PlayerActions(players[Player_Index], this.TheBoard);
                        }
                    }
                    




                    if (Player_Index == players.Count - 1)
                    {
                        Player_Index = 0;
                    }
                    else
                    {
                        Player_Index++;
                    }
                    System.Threading.Thread.Sleep(1000); // Transición?
                }


                void PlayerActions(Player player , AbstractSquare[] board)
                {
                    Console.WriteLine($"{player.NAME}, we are you locating in the next square");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();

                    Scenes.TransitionTo(new BoardSituationScene_State());

                    List<Player> playerSituaion = new List<Player>();
                    playerSituaion.Add(player);
                    System.Threading.Thread.Sleep(2000);

                    Scenes.Display(playerSituaion, board);

                    System.Threading.Thread.Sleep(2500);

                    playerSituaion.Remove(player);

                    player.SetScene(new MenuPlayerScene_State());
                    player.Display(board);

                }



                //TODO: Seguir con la Escena pos lnazamiento de dados

                /*

                Console.WriteLine("\nCurrent position :" + current.position + "\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey(true);
                DisplayMenu(current, compt, true);
                while (current.DoubleBool(dices))
                {
                    nbdouble++;
                    if (nbdouble == 3)
                    {
                        Console.WriteLine("You rolled a double for the third time in a row. You must go to jail.");
                        current.jail = true;
                        current.position = 10;
                        Console.WriteLine("You are now in jail.\n");
                        Console.ReadKey(true);
                        break;
                    }
                    Console.WriteLine("\nWow, you got a double, you can roll the dices again !");
                    Console.WriteLine("\nPress any key to roll the dices !\n");
                    Console.ReadKey(true);
                    dices = current.RollDices();
                    current.Move(dices[0] + dices[1]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nCurrent position :" + current.position + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey(true);
                    DisplayMenu(current, compt, true);
                }
                if (compt == players.Count - 1)
                {
                    compt = 0;
                }
                else
                {
                    compt++;
                }
            }
            Console.WriteLine("Gagnant :" + winner.Name);
            Console.ReadKey(true);
        }



        public void DisplayPosition(Player player, int compt)
        {
            Property p = new Property("", Type_Property.Street, 0, 0, Property_Situation.Free, null, 0);
            BoughtProperty bp = new BoughtProperty(p, null);
            HouseProperty hsp = new HouseProperty(bp, null);
            HotelProperty htp = new HotelProperty(hsp, null);
            Card c = new Card(Type_Card.Chance, 0);
            Square s = new Square();


            Console.WriteLine("The square you are currently on is the following:");
            if (board_game.board[player.position].GetType() == p.GetType())
            {
                p = (Property)board_game.board[player.position];
                Console.WriteLine(p.toString());
            }
            else if (board_game.board[player.position].GetType() == bp.GetType())
            {
                bp = (BoughtProperty)board_game.board[player.position];
                Console.WriteLine(bp.toStringOwner());
                if (bp.owner != player)
                {
                    Console.WriteLine("\nYou must pay $" + bp.taxes + " to the owner of this property (" + bp.owner.name + ")");
                    if (player.money < bp.taxes)
                    {
                        Console.WriteLine("You do not have enough money. You lost.");
                        player.loser = true;
                        player.money = 0;
                        Console.WriteLine("\nPress any key to go back to the menu.");
                        Console.ReadKey(true);
                        DisplayMenu(player, compt, false);
                    }
                    else
                    {
                        player.money -= bp.taxes;
                        bp.owner.money += bp.taxes;
                        Console.WriteLine("You now have $" + player.money);
                        Console.WriteLine("The owner (" + bp.owner.name + ") now has $" + bp.owner.money);
                        Console.WriteLine("\nPress any key to go back to the menu.");
                        Console.ReadKey(true);
                        DisplayMenu(player, compt, false);
                    }
                }
            }
            else if (board_game.board[player.position].GetType() == hsp.GetType())
            {
                hsp = (HouseProperty)board_game.board[player.position];
                Console.WriteLine(hsp.toStringOwner());
                if (hsp.owner != player)
                {
                    Console.WriteLine("\nYou must pay $" + hsp.taxes + " to the owner of this property (" + hsp.owner.name + ")");
                    if (player.money < hsp.taxes)
                    {
                        Console.WriteLine("You do not have enough money. You lost.");
                        player.loser = true;
                        player.money = 0;
                        Console.WriteLine("\nPress any key to go back to the menu.");
                        Console.ReadKey(true);
                        DisplayMenu(player, compt, false);
                    }
                    else
                    {
                        player.money -= hsp.taxes;
                        hsp.owner.money += hsp.taxes;
                        Console.WriteLine("You now have $" + player.money);
                        Console.WriteLine("The owner (" + hsp.owner.name + ") now has $" + hsp.owner.money);
                        Console.WriteLine("\nPress any key to go back to the menu.");
                        Console.ReadKey(true);
                        DisplayMenu(player, compt, false);
                    }
                }
            }
            else if (board_game.board[player.position].GetType() == htp.GetType())
            {
                htp = (HotelProperty)board_game.board[player.position];
                Console.WriteLine(htp.toStringOwner());
                if (htp.owner != player)
                {
                    Console.WriteLine("\nYou must pay $" + htp.taxes + " to the owner of this property (" + htp.owner.name + ")");
                    if (player.money < htp.taxes)
                    {
                        Console.WriteLine("You do not have enough money. You lost.");
                        player.loser = true;
                        player.money = 0;
                        Console.WriteLine("\nPress any key to go back to the menu.");
                        Console.ReadKey(true);
                        DisplayMenu(player, compt, false);
                    }
                    else
                    {
                        player.money -= htp.taxes;
                        htp.owner.money += htp.taxes;
                        Console.WriteLine("You now have $" + player.money);
                        Console.WriteLine("The owner (" + htp.owner.name + ") now has $" + htp.owner.money);
                        Console.WriteLine("\nPress any key to go back to the menu.");
                        Console.ReadKey(true);
                        DisplayMenu(player, compt, false);
                    }
                }
            }
            else if (board_game.board[player.position].GetType() == c.GetType())
            {
                c = (Card)board_game.board[player.position];
                Console.WriteLine(c.type.ToString() + " card!");
                CardSquare(c, player, compt);
            }
            else if (board_game.board[player.position].GetType() == s.GetType())
            {
                EmptySquare(player, compt);
            }
        }

        public void CardSquare(Card c, Player player, int compt)
        {
            Console.Write("The card says:");
            int rand_cash = c.RandomCash();
            int rand_int = c.RandomInt();
            Console.WriteLine("'" + c.CardInstruction(c.what, rand_cash, rand_int) + "'");
            if (c.what == 1)
            {
                if (player.jail)
                {
                    Console.WriteLine("This card allows you to get out of jail. You are now free.");
                    player.jail = false;
                }
                else
                {
                    Console.WriteLine("You are not currently in jail. You can keep this card for later.");
                    player.get_out_of_jail_card = true;
                }
            }
            else if (c.what == 2)
            {
                if (rounds < 2)
                {
                    Console.WriteLine("It is your lucky day: nobody played before you! You do not have to pay anything.");
                }
                else
                {
                    if (player.money < rand_cash)
                    {
                        Console.WriteLine("You do not have enough money to pay. You lost.");
                        player.loser = true;

                    }
                    else
                    {
                        players[compt - 1].money += rand_cash;
                        player.money -= rand_cash;
                        Console.WriteLine("You have given $" + rand_cash + " to " + players[compt].name);
                        Console.WriteLine("You now have $" + player.money);
                    }
                }
            }
            else if (c.what == 3)
            {
                if (player.money < rand_cash)
                {
                    Console.WriteLine("You do not have enough money to pay. You lost.");
                    player.loser = true;

                }
                else
                {
                    player.money -= rand_cash;
                    Console.WriteLine("You have paid $" + rand_cash + " for taxes.");
                    Console.WriteLine("You now have $" + player.money);
                }
            }
            else if (c.what == 4)
            {
                player.money += rand_cash;
                Console.WriteLine("You have received $" + rand_cash + " from the bank.");
                Console.WriteLine("You now have $" + player.money);
            }
            else if (c.what == 5)
            {
                player.Move(rand_int);
                Console.WriteLine("Your current position is now: " + player.position);
            }
            else if (c.what == 6)
            {
                player.MoveBackward(rand_int);
                Console.WriteLine("Your current position is now: " + player.position);
            }
            else if (c.what == 7)
            {
                player.position = 10;
                player.jail = true;
                Console.WriteLine("You are now in jail.");
            }
            Console.WriteLine("\nPress any key to go back to the menu.");
            Console.ReadKey(true);
        }

        public void EmptySquare(Player player, int compt)
        {
            if (player.position == 0)
            {
                Console.WriteLine("\nStart square!");
            }
            else if (player.position == 4)
            {
                Console.WriteLine("Income taxes!\nYou have to pay $200.");
                if (player.money < 200)
                {
                    Console.WriteLine("\nYou do not have enough money. You lost.");
                    player.loser = true;
                    Console.WriteLine("\nPress any key to go back to the menu.");
                    Console.ReadKey(true);
                    DisplayMenu(player, compt, false);
                }
                else
                {
                    player.money -= 200;
                    Console.WriteLine("You now have $" + player.money);
                    Console.WriteLine("\nPress any key to go back to the menu.");
                    Console.ReadKey(true);
                    DisplayMenu(player, compt, false);
                }
            }
            else if (player.position == 10)
            {
                Console.WriteLine("\nJail square! But don't worry you are only visiting.");
            }
            else if (player.position == 20)
            {
                Console.WriteLine("\nFree parking!");
            }
            else if (player.position == 30)
            {
                Console.WriteLine("\nGo to jail!");
                player.jail = true;
                player.position = 10;
                Console.WriteLine("You are now in jail.");
                Console.WriteLine("\nPress any key to go back to the menu.");
                Console.ReadKey(true);
                DisplayMenu(player, compt, false);
            }
            else if (player.position == 38)
            {
                Console.WriteLine("Luxury taxes!\nYou have to pay $100.");
                if (player.money < 100)
                {
                    Console.WriteLine("\nYou do not have enough money. You lost.");
                    player.loser = true;
                    Console.WriteLine("\nPress any key to go back to the menu.");
                    Console.ReadKey(true);
                    DisplayMenu(player, compt, false);
                }
                else
                {
                    player.money -= 100;
                    Console.WriteLine("You now have $" + player.money);
                    Console.WriteLine("\nPress any key to go back to the menu.");
                    Console.ReadKey(true);
                    DisplayMenu(player, compt, false);
                }
            }
        }

        public void PurchaseProperty(Player player, int compt)
        {
           
        }

        

        public void BuyHouseProperty(Player player, int compt)
        {
            if (player.properties.Count() == 0)
            {
                Console.WriteLine("You do not have any properties.");
                Console.WriteLine("\nPress any key to go back to the menu.");
            }
            else
            {
                int i = 0;
                Console.WriteLine("For which property do you want to buy a house?\n");
                foreach (Property p in player.properties)
                {
                    Console.Write(i + 1);
                    Console.WriteLine(p.toString() + "\n");
                    i++;
                }
                i = int.Parse(Console.ReadLine()) - 1;
                BoughtProperty bp = new BoughtProperty(player.properties[i], player);
                while (player.properties[i].GetType() != bp.GetType())
                {
                    Console.WriteLine("You cannot buy a house for this property because it already has one.");
                    Console.WriteLine("1 : Chose another property\n2 : Go back to the menu");
                    int r = int.Parse(Console.ReadLine());
                    if (r == 2) { DisplayMenu(player, compt, false); }
                    else if (r == 1)
                    {
                        Console.WriteLine("For which property do you want to buy a house?\n");
                        foreach (Property p in player.properties)
                        {
                            Console.Write(i + 1);
                            Console.WriteLine(p.toString() + "\n");
                            i++;
                        }
                        i = int.Parse(Console.ReadLine());
                    }
                }
                bp = (BoughtProperty)player.properties[i];
                long house_price = bp.buying_cost * 2;
                Console.WriteLine("Buying a house for this property costs $" + house_price);
                if (player.money < house_price)
                {
                    Console.WriteLine("\nYou do not have enough money to go through with this purchase.");
                    Console.WriteLine("Press any key to go back to the menu.");
                    Console.ReadKey(true);
                    DisplayMenu(player, compt, false);
                }
                else
                {
                    Console.WriteLine("\nYou currently have: $" + player.money);
                    int res = 0;
                    while (res != 1 && res != 2)
                    {
                        Console.WriteLine("Are you sure you want to go throught with this purchase?\n1 : YES\n2 : NO");
                        res = int.Parse(Console.ReadLine());
                    }
                    if (res == 1)
                    {
                        Console.Clear();
                        bp = new HouseProperty(bp, player);
                        HouseProperty hsp = (HouseProperty)bp;
                        board_game.board[player.position] = hsp;
                        int j = 0;
                        foreach (Property prop in player.properties)
                        {
                            if (prop.name != hsp.name)
                            {
                                j++;
                            }
                        }
                        player.properties[j] = hsp;
                        Console.WriteLine("Congratulations on your new house!\n");
                        Console.WriteLine(hsp.toStringOwner());
                        Console.WriteLine("\nPress any key to go back to the menu.");
                        Console.ReadKey(true);
                        DisplayMenu(player, compt, false);
                    }
                    else if (res == 2)
                    {
                        Console.WriteLine("\nPress any key to go back to the menu.");
                        Console.ReadKey(true);
                        DisplayMenu(player, compt, false);
                    }
                }
            }
        }

        public void BuyHotelProperty(Player player, int compt)
        {
            if (player.properties.Count() == 0)
            {
                Console.WriteLine("You do not have any properties.");
                Console.WriteLine("\nPress any key to go back to the menu.");
            }
            else
            {
                int i = 0;
                Console.WriteLine("For which property do you want to buy a hotel?\n");
                foreach (Property p in player.properties)
                {
                    Console.Write(i + 1);
                    Console.WriteLine(p.toString() + "\n");
                    i++;
                }
                i = int.Parse(Console.ReadLine()) - 1;
                BoughtProperty bp = new BoughtProperty(player.properties[i], player);
                HouseProperty hsp = new HouseProperty(bp, player);
                while (player.properties[i].GetType() != hsp.GetType())
                {
                    Console.WriteLine("You cannot buy a hotel for this property because it already has one or it does not have a house yet.");
                    Console.WriteLine("1 : Chose another property\n2 : Go back to the menu");
                    int r = int.Parse(Console.ReadLine());
                    if (r == 2) { DisplayMenu(player, compt, false); }
                    else if (r == 1)
                    {
                        Console.WriteLine("For which property do you want to buy a hotel?\n");
                        foreach (Property p in player.properties)
                        {
                            Console.Write(i + 1);
                            Console.WriteLine(p.toString() + "\n");
                            i++;
                        }
                        i = int.Parse(Console.ReadLine());
                    }
                }
                hsp = (HouseProperty)player.properties[i];
                long hotel_price = hsp.buying_cost * 3;
                Console.WriteLine("Buying a hotel for this property costs $" + hotel_price);
                if (player.money < hotel_price)
                {
                    Console.WriteLine("\nYou do not have enough money to go through with this purchase.");
                    Console.WriteLine("Press any key to go back to the menu.");
                    Console.ReadKey(true);
                    DisplayMenu(player, compt, false);
                }
                else
                {
                    Console.WriteLine("\nYou currently have: $" + player.money);
                    int res = 0;
                    while (res != 1 && res != 2)
                    {
                        Console.WriteLine("Are you sure you want to go throught with this purchase?\n1 : YES\n2 : NO");
                        res = int.Parse(Console.ReadLine());
                    }
                    if (res == 1)
                    {
                        Console.Clear();
                        hsp = new HotelProperty(hsp, player);
                        HotelProperty htp = (HotelProperty)hsp;
                        board_game.board[player.position] = htp;
                        int j = 0;
                        foreach (Property prop in player.properties)
                        {
                            if (prop.name != htp.name)
                            {
                                j++;
                            }
                        }
                        player.properties[j] = htp;
                        Console.WriteLine("Congratulations on your new hotel!\n");
                        Console.WriteLine(htp.toStringOwner());
                        Console.WriteLine("\nPress any key to go back to the menu.");
                        Console.ReadKey(true);
                        DisplayMenu(player, compt, false);
                    }
                    else if (res == 2)
                    {
                        Console.WriteLine("\nPress any key to go back to the menu.");
                        Console.ReadKey(true);
                        DisplayMenu(player, compt, false);
                    }
                }*/
            }
        }



        }
}
