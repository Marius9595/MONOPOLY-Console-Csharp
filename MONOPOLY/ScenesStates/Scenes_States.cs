using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
   abstract class Scenes_States
    {
        protected Scenes scenes;

        public void SetScene(Scenes scenes)
        {
            this.scenes = scenes;
        }

        public abstract void Draw(Player[] players, Board board);

        
    }
}
