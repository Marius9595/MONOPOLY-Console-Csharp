using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY.Factories
{
    class NeutralFactory : SquareFactory
    {
        public override AbstractSquare GetSquare(int position)
        {
            return new Squares.NeutralSquare(position);
        }
    }
}
