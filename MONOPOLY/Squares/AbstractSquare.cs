using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    abstract class  AbstractSquare
    {
        private int position;

        public int POSITION { get => position; set => position = value; }

        public AbstractSquare(int Position)
        {
            this.position = Position;
        }


        abstract public string InfoSquare();




    }
}
