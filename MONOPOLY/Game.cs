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
        private int rounds = 0; // number of rounds played
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




        public void Start()
        {


            int Player_Index = 0;

            while (IsWinner(players)!=true)
            {
                Console.Clear();

                rounds++;
                JailRoundsForPlayer(players[Player_Index]);


                if (!players[Player_Index].Loser && !players[Player_Index].INJAIL)
                {
                    //TODO: aqui abra que poner un if para  que jueguen los que estan en la carcel

                    
                    players[Player_Index].SetScene(new RollingDicesScene_State());
                    players[Player_Index].Display(this.TheBoard);

                    players[Player_Index].MovePlayer();

                    WhatHappensInthePosition(players, TheBoard, Player_Index);
                    //TODO: CONSECUENCIAS DE ESTAR EN ESA CASILLA ACCIONES

                    PlayerActions(players[Player_Index], TheBoard);

                     IfDoobleBoolOccurs(players[Player_Index], this.TheBoard);

                    System.Threading.Thread.Sleep(1000); // Transición?
                }


                Player_Index = ChancetheTurn(Player_Index, players);

            }


            if (!LookingWinner(players).Loser)
            {
                Scenes.TransitionTo(new FinalScene_State());
                Scenes.Display(players, TheBoard);
            }
        }



        private void WhatHappensInthePosition(List<Player> players, AbstractSquare[] board, int PlayerIndex)
        {
            AbstractSquare Square = board[players[PlayerIndex].ACTUALPOSITION];
            Player CurrentPlayer = players[PlayerIndex];
            Player Owner;

            if (Square is IAbstractTitleDeed && !(((IAbstractTitleDeed)Square).OWNER is null))
            {
                Owner = ((IAbstractTitleDeed)Square).OWNER;

                if (CurrentPlayer!=Owner)
                {
                    CurrentPlayer.CURRENTMONEY -= ((IAbstractTitleDeed)Square).PAYTOOWNER;
                    Owner.CURRENTMONEY+= ((IAbstractTitleDeed)Square).PAYTOOWNER; ;
                }
            } 
            else if (Square is CardSquare)

            {
                ActionOfCard(CurrentPlayer,(CardSquare)Square);
                
            }
            else if (Square is IncomeTaxSquare)
            {
                CurrentPlayer.CURRENTMONEY += ((IncomeTaxSquare)Square).TAX;
            }
            else if (Square is JailSquare && Square.POSITION==10)
            {
                CurrentPlayer.INJAIL = true;
            }

        }


        //TODO: PODRÍA CREARSE UN REFACTORIZADO O MEJOR DICHO METER DENTRO DE UN PATRON
        private void ActionOfCard(Player player, CardSquare card)
        {
            if (card.typeofCard == TypeofCard.Community)
            {
                switch (card.CONTENT)
                {
                    case (int)Community.GotoJail:
                        card.GotoJail(player);
                        break;
                    case (int)Community.GetoutfromJail:
                        card.GetoutfromJail(player);
                        break;
                    case (int)Community.MoveBackward:
                        card.MoveBackward(player);
                        break;
                    case (int)Community.MoveForward:
                        card.MoveForward(player);
                        break;
                    case (int)Community.Paytaxes:
                        card.Paytaxes(player);
                        break;
                    case (int)Community.ReceivefromBank:
                        card.ReceivefromBank(player);
                        break;
                    default:
                        break;
                }
            }
            if (card.typeofCard == TypeofCard.Chance)
            {
                switch (card.CONTENT)
                {
                    case (int)Chances.GotoJail:
                        card.GotoJail(player);
                        break;
                    case (int)Chances.GetoutfromJail:
                        card.GetoutfromJail(player);
                        break;
                    case (int)Chances.MoveBackward:
                        card.MoveBackward(player);
                        break;
                    case (int)Chances.MoveForward:
                        card.MoveForward(player);
                        break;
                    case (int)Chances.Paytaxes:
                        card.Paytaxes(player);
                        break;
                    case (int)Chances.ReceivefromBank:
                        card.ReceivefromBank(player);
                        break;
                    default:
                        break;
                }
            }

        }



        private Player LookingWinner(List<Player> players)
        {
            Player Winner;

            foreach (Player player in players)
            {
                if (player.Loser==false) winner = player;
            }

            return winner;
        }



        private bool IsWinner(List<Player> players)
        {

            List<Player> Losers = new List<Player>();

            foreach (Player player in players)
            {
                if (!(Losers.Contains(player)))
                {
                    if (player.Loser == true) Losers.Add(player);
                }
                                                
            }

            if (Losers.Count == (players.Count - 1)) return true;
            else return false;

        }


        private int ChancetheTurn(int Player_Index, List<Player> players)
        {
            int index =0;

            if (Player_Index == players.Count-1)
            {
                return index = 0;
            }
            else
            {
               return index+=1;
            }
        }


        private  void JailRoundsForPlayer(Player player)
        {
            if (player.INJAIL && player.ROUNDSINJAIL < 3)
            {
                player.ROUNDSINJAIL += 1;
            }
            else if (player.INJAIL && player.ROUNDSINJAIL < 3)
            {
                player.INJAIL = false;
                player.ROUNDSINJAIL = 0;
            }
        }


        private void IfDoobleBoolOccurs(Player player, AbstractSquare[] board)
        {
            if (player.DOUBLEBOOL == true && player.INJAIL == false && player.Loser == false)
            {
                player.SetScene(new RollingDicesScene_State());
                player.Display(board);

                if (player.INJAIL == true)
                {
                    Console.Clear();

                    player.SetScene(new GotoJailScene_State());
                    player.Display(board);
                    player.INJAIL = true;
                    player.ACTUALPOSITION = 10;
                }
                else
                {
                    player.MovePlayer();
                    PlayerActions(player, board);
                }
            }
        }



        private void PlayerActions(Player player, AbstractSquare[] board)
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
    }
}
