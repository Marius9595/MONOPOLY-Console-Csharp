using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    abstract class ScenesStates
    {
        protected Scenes scenes;

        public void SetScene(Scenes scenes)
        {
            this.scenes = scenes;
        }

        public abstract void Draw(Player[] players, Board board);

        
    }
}
