using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    class AbstractSquare
    {
        private int position;

        public int POSITION { get => position; set => position = value; }

        public AbstractSquare(int Position)
        {
            this.position = Position;
        }

        public AbstractSquare() { }




    }
}
