using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
   abstract public class PlayerScenes_States
    {
        protected Player player;

        public void SetScene(Player player)
        {
            this.player = player;
        }

        public abstract void Draw(Player player, AbstractSquare[] board);
    }
}
