using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
     class Scenes
    {
        private ScenesStates state;

        public Scenes(ScenesStates state)
        {
            this.TransitionTo(state);
        }

        public void TransitionTo(ScenesStates state)
        {
            this.state = state;
            this.state.SetScene(this);
        }

        public void Display(Player[] players, Board board)
        {
            this.state.Draw(players, board);
        }

    }
}
