using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class Game
    {
        private List<Player> players = new List<Player>(); 
        private Board board_game = new Board();
        private int rounds; // number of rounds played
        private Player winner;
        private Scenes Scenes = new Scenes(new StartScene_State());

        public void Create()
        {
            Scenes.Display(players, board_game);

            Scenes.TransitionTo(new createGameScene_State());

            Scenes.Display(players, board_game);

        }



    }
}
