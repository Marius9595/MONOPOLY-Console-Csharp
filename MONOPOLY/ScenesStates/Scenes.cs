using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
     class Scenes
    {
        private Scenes_States state;

        public Scenes(Scenes_States state)
        {
            this.TransitionTo(state);
        }

        public void TransitionTo(Scenes_States state)
        {
            this.state = state;
            this.state.SetScene(this);
        }

        public void Display(List<Player> players, Board board)
        {
            this.state.Draw(players, board);
        }

    }
}
